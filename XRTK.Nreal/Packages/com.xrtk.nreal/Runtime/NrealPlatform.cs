// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using NRKernal;
using UnityEngine;
using XRTK.Interfaces;

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the Nreal platform.
    /// </summary>
    [Guid("1C4598F7-A765-4934-A4B2-3E3F451F87A7")]
    public class NrealPlatform : BasePlatform
    {
        private static readonly Version NoVersion = new Version();
        private static Version NRSDKVersion => new Version(NRVersionInfo.GetVersion());

        /// <inheritdoc />
        public override bool IsAvailable => !Application.isEditor && NRSDKVersion > NoVersion;

        /// <inheritdoc />
        public override bool IsBuildTargetAvailable
        {
            get
            {
#if UNITY_EDITOR
                return UnityEditor.EditorUserBuildSettings.activeBuildTarget == UnityEditor.BuildTarget.Android && NRSDKVersion > NoVersion;
#else
                return false;
#endif
            }
        }

        /// <inheritdoc />
        public override IMixedRealityPlatform[] PlatformOverrides { get; } =
        {
            new AndroidPlatform()
        };
    }
}
