// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.CameraSystem;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.CameraSystem;
using XRTK.Providers.CameraSystem;

namespace XRTK.Nreal.Providers.CameraSystem
{
    [RuntimePlatform(typeof(NrealPlatform))]
    [System.Runtime.InteropServices.Guid("#INSERT_GUID_HERE#")]
    public class NrealCameraDataProvider : BaseCameraDataProvider
    {
        /// <inheritdoc />
        public NrealCameraDataProvider(string name, uint priority, BaseMixedRealityCameraDataProviderProfile profile, IMixedRealityCameraSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}
