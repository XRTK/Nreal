// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using NRKernal;
using UnityEngine;
using XRTK.Interfaces;

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the Nreal platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("1C4598F7-A765-4934-A4B2-3E3F451F87A7")]
    public class NrealPlatform : BasePlatform
    {
        private static readonly System.Version NoVersion = new System.Version();
        private static System.Version NRSDKVersion
        {
            get
            {
                var versionString = NRVersionInfo.GetVersion();
                Debug.Log($"Found NRSDK Version: {versionString}");
                return new Version();
            }
        }

        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
                return !UnityEngine.Application.isEditor && NRSDKVersion > NoVersion;
            }
        }

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
