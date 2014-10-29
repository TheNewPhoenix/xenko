﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SiliconStudio.Assets;
using SiliconStudio.Core.Extensions;
using SiliconStudio.Core.IO;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Core.Serialization.Assets;
using SiliconStudio.Core.Storage;
using SiliconStudio.Paradox.Assets.Model;
using SiliconStudio.Paradox.Assets.Model.Analysis;
using SiliconStudio.Paradox.EntityModel;

namespace SiliconStudio.Paradox.Assets.Tests
{
    [TestFixture]
    public class TestModelAsset
    {
        [TestFixtureSetUp]
        public void Initialize()
        {
            AssetRegistry.RegisterAssembly(typeof(ModelAsset).Assembly);
        }

        [Test]
        public void TestImportModelSimple()
        {
            var file = Path.Combine(Environment.CurrentDirectory, @"scenes\goblin.fbx");

            // Create a project with an asset reference a raw file
            var project = new Package { FullPath = Path.Combine(Environment.CurrentDirectory, "ModelAssets", "ModelAssets" + Package.PackageFileExtension) };
            using (var session = new PackageSession(project))
            {
                var importSession = new AssetImportSession(session);

                // ------------------------------------------------------------------
                // Step 1: Add files to session
                // ------------------------------------------------------------------
                importSession.AddFile(file, project, UDirectory.Empty);

                // ------------------------------------------------------------------
                // Step 2: Stage assets
                // ------------------------------------------------------------------
                var stageResult = importSession.Stage();
                Assert.IsTrue(stageResult);
                Assert.AreEqual(0, project.Assets.Count);

                // ------------------------------------------------------------------
                // Step 3: Import asset directly
                // ------------------------------------------------------------------
                importSession.Import();
                Assert.AreEqual(4, project.Assets.Count);
                var assetItem = project.Assets.FirstOrDefault(item => item.Asset is EntityAsset);
                Assert.NotNull(assetItem);

                EntityAnalysis.UpdateEntityReferences((EntityAsset)assetItem.Asset);

                var assetCollection = new AssetItemCollection();
                // Remove directory from the location
                assetCollection.Add(assetItem);

                Console.WriteLine(assetCollection.ToText());

                //session.Save();

                // Create and mount database file system
                var objDatabase = new ObjectDatabase("/data/db", "index", "/local/db");
                var databaseFileProvider = new DatabaseFileProvider(objDatabase);
                AssetManager.GetFileProvider = () => databaseFileProvider;

                ((EntityAsset)assetItem.Asset).Data.Entities[0].Components.RemoveWhere(x => x.Key != SiliconStudio.Paradox.Engine.TransformationComponent.Key);
                //((EntityAsset)assetItem.Asset).Data.Entities[1].Components.RemoveWhere(x => x.Key != SiliconStudio.Paradox.Engine.TransformationComponent.Key);

                var assetManager = new AssetManager();
                assetManager.Save("Entity1", ((EntityAsset)assetItem.Asset).Data);

                assetManager = new AssetManager();
                var entity = assetManager.Load<Entity>("Entity1");

                var entity2 = entity.Clone();
            }
        }
    }
}