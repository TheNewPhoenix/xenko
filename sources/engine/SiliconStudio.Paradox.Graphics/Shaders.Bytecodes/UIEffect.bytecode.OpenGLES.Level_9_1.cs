﻿#if SILICONSTUDIO_PARADOX_GRAPHICS_API_OPENGLES
//------------------------------------------------------------------------------
// <auto-generated>
//     Paradox Effect Compiler File Generated:
//     Effect [UIEffect]
//
//     Command Line: C:\DEV\paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --platform=Windows --profile=Windows --graphics-platform=OpenGLES --output-path=C:\DEV\paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\DEV\paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.pdxpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Paradox.Graphics 
{
    internal partial class UIEffect
    {
        private static readonly byte[] binaryBytecode = new byte[] {
1, 192, 254, 239, 0, 4, 0, 0, 0, 8, 85, 73, 69, 102, 102, 101, 99, 116, 1, 114, 213, 133, 104, 138, 191, 37, 63, 207, 193, 172, 169, 12, 118, 120, 21, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 168, 47, 144, 37, 113, 115, 64, 72, 185, 71, 225, 75, 134, 154, 255, 245, 16, 83, 
104, 97, 100, 101, 114, 66, 97, 115, 101, 83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 67, 83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 0, 0, 1, 0, 0, 
0, 0, 0, 1, 0, 0, 0, 0, 34, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 46, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 0, 23, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 
101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 3, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 0, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 9, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 
0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 11, 79, 112, 101, 
110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 10, 0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 
0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 4, 0, 0, 243, 3, 117, 110, 105, 102, 111, 114, 109, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 118, 97, 114, 121, 
105, 110, 103, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 
99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 
82, 68, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 97, 116, 116, 114, 105, 98, 117, 116, 101, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 
118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 
61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 
32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 
79, 78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 40, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 
46, 121, 41, 59, 10, 125, 10, 10, 253, 3, 35, 118, 101, 114, 115, 105, 111, 110, 32, 51, 48, 48, 32, 101, 115, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 10, 32, 
32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 111, 117, 116, 32, 102, 108, 111, 
97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 10, 105, 110, 32, 
118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 
111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 120, 119, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 120, 119, 59, 10, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 
32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 32, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 32, 97, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 
61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 40, 40, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 122, 32, 42, 32, 50, 46, 48, 41, 32, 45, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 
78, 48, 46, 119, 41, 59, 10, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 40, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 46, 
121, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 91, 87, 14, 125, 28, 85, 154, 109, 81, 137, 251, 58, 153, 126, 169, 92, 0, 5, 0, 0, 0, 0, 0, 8, 0, 0, 135, 4, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 
102, 108, 111, 97, 116, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 
50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 118, 97, 114, 121, 105, 110, 103, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 
76, 79, 82, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 109, 101, 100, 105, 117, 109, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 
95, 50, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 51, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 50, 68, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 
83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 52, 59, 10, 32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 67, 72, 
95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 52, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 51, 59, 10, 32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 
118, 97, 114, 95, 52, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 51, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 40, 116, 109, 112, 118, 97, 114, 95, 52, 32, 42, 32, 118, 95, 67, 79, 76, 79, 82, 48, 41, 59, 10, 
32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 125, 10, 10, 148, 4, 35, 118, 101, 114, 115, 105, 111, 
110, 32, 51, 48, 48, 32, 101, 115, 10, 112, 114, 101, 99, 105, 115, 105, 111, 110, 32, 104, 105, 103, 104, 112, 32, 102, 108, 111, 97, 116, 59, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 
103, 115, 32, 123, 10, 32, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 10, 125, 59, 10, 111, 117, 116, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 
68, 97, 116, 97, 91, 49, 93, 59, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 
95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 10, 105, 110, 32, 102, 108, 111, 97, 116, 32, 118, 95, 66, 65, 84, 67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 59, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 10, 118, 111, 105, 100, 32, 109, 97, 
105, 110, 32, 40, 41, 10, 123, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 116, 109, 112, 118, 97, 114, 95, 49, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 32, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 
51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 41, 59, 10, 32, 32, 108, 111, 119, 112, 32, 118, 101, 99, 52, 32, 116, 109, 112, 118, 97, 114, 95, 50, 59, 10, 32, 32, 105, 102, 32, 40, 40, 118, 95, 66, 65, 84, 
67, 72, 95, 83, 87, 73, 90, 90, 76, 69, 48, 32, 61, 61, 32, 48, 46, 48, 41, 41, 32, 123, 10, 32, 32, 32, 32, 116, 109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 59, 10, 32, 32, 125, 32, 101, 108, 115, 101, 32, 123, 10, 32, 32, 32, 32, 116, 
109, 112, 118, 97, 114, 95, 50, 32, 61, 32, 116, 109, 112, 118, 97, 114, 95, 49, 46, 120, 120, 120, 120, 59, 10, 32, 32, 125, 59, 10, 32, 32, 95, 103, 108, 101, 115, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 40, 116, 109, 112, 118, 97, 114, 95, 50, 32, 42, 32, 118, 
95, 67, 79, 76, 79, 82, 48, 41, 59, 10, 125, 10, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 106, 139, 124, 76, 90, 110, 36, 65, 164, 11, 131, 242, 253, 226, 56, 206, 
        };
    }
}
#endif
