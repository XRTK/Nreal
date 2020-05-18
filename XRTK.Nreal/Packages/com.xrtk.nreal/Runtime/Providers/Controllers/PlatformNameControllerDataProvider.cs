// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.Nreal.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.Nreal.Providers.Controllers
{
    [RuntimePlatform(typeof(NrealPlatform))]
    [System.Runtime.InteropServices.Guid("#INSERT_GUID_HERE#")]
    public class NrealControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public NrealControllerDataProvider(string name, uint priority, NrealControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}

