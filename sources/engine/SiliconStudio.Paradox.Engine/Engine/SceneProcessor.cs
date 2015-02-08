﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;

using SiliconStudio.Core;
using SiliconStudio.Paradox.EntityModel;
using SiliconStudio.Paradox.Games;

namespace SiliconStudio.Paradox.Engine
{
    /// <summary>
    /// The scene processor to handle a scene. See remarks.
    /// </summary>
    /// <remarks>
    /// This processor is handling specially an entity with a scene component. If an scene component is found, it will
    /// create a sub-<see cref="EntitySystem"/> dedicated to handle the entities inside the scene.
    /// </remarks>
    public sealed class SceneProcessor : EntityProcessor<SceneProcessor.SceneState>
    {
        private readonly Entity sceneEntityRoot;

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneProcessor"/> class.
        /// </summary>
        public SceneProcessor() : base(new []{ SceneComponent.Key })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneProcessor"/> class.
        /// </summary>
        /// <param name="sceneEntityRoot">The scene entity root.</param>
        /// <exception cref="System.ArgumentNullException">sceneEntityRoot</exception>
        public SceneProcessor(Entity sceneEntityRoot)
            : this()
        {
            if (sceneEntityRoot == null) throw new ArgumentNullException("sceneEntityRoot");
            this.sceneEntityRoot = sceneEntityRoot;
            Scenes = new List<SceneState>();
        }

        public List<SceneState> Scenes { get; private set; }

        protected override SceneState GenerateAssociatedData(Entity entity)
        {
            return (entity == sceneEntityRoot) ? null : new SceneState(this.EntitySystem.Services, entity);
        }

        protected override void OnEntityAdding(Entity entity, SceneState data)
        {
            if (data != null)
            {
                Scenes.Add(data);
            }
        }

        protected override void OnEntityRemoved(Entity entity, SceneState data)
        {
            if (data != null)
            {
                Scenes.Remove(data);
            }
        }

        internal override bool ShouldStopProcessorChain(Entity entity)
        {
            // If the entity being added is not the scene entity root, don't run other processors, as this is handled 
            // by a nested EntitySystem
            return !ReferenceEquals(entity, sceneEntityRoot);
        }

        public override void Update(GameTime time)
        {
            foreach (var sceneEntityAndState in Scenes)
            {
                sceneEntityAndState.EntitySystem.Update(time);
            }
        }

        public override void Draw(GameTime time)
        {
            foreach (var sceneEntityAndState in Scenes)
            {
                sceneEntityAndState.EntitySystem.Draw(time);
            }
        }

        public class SceneState
        {
            public SceneState(IServiceRegistry services, Entity sceneEntityRoot)
            {
                if (services == null) throw new ArgumentNullException("services");
                Scene = sceneEntityRoot;
                EntitySystem = services.GetSafeServiceAs<SceneSystem>().CreateSceneEntitySystem(sceneEntityRoot);
            }

            public Entity Scene { get; private set; }

            /// <summary>
            /// Entity System dedicated to this scene.
            /// </summary>
            public EntitySystem EntitySystem { get; private set; }
        }
    }
}