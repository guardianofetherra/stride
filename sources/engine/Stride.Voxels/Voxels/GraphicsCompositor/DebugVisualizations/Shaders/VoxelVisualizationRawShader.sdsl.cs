﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.Voxels.Debug
{
    public static partial class VoxelVisualizationRawShaderKeys
    {
        public static readonly ValueParameterKey<Vector2> range = ParameterKeys.NewValue<Vector2>();
        public static readonly ValueParameterKey<float> rangeOffset = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> mip = ParameterKeys.NewValue<float>();
    }
}