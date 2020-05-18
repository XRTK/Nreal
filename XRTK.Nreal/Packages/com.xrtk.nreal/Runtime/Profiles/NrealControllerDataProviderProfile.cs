// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.Nreal.Providers.Controllers;

namespace XRTK.Nreal.Profiles
{
    public class NrealControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(NrealController), Handedness.Left),
                new ControllerDefinition(typeof(NrealController), Handedness.Right)
            };
        }
    }
}

