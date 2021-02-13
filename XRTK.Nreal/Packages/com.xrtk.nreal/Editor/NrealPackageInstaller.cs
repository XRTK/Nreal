// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.IO;
using UnityEditor;
using XRTK.Editor;
using XRTK.Extensions;
using XRTK.Editor.Utilities;

namespace XRTK.Nreal.Editor
{
    [InitializeOnLoad]
    internal static class NrealPackageInstaller
    {
        private static readonly string DefaultPath = $"{MixedRealityPreferences.ProfileGenerationPath}Nreal";
        private static readonly string HiddenPath = Path.GetFullPath($"{PathFinderUtility.ResolvePath<IPathFinder>(typeof(NrealPathFinder)).ToForwardSlashes()}\\{MixedRealityPreferences.HIDDEN_PROFILES_PATH}");

        static NrealPackageInstaller()
        {
            if (!EditorPreferences.Get($"{nameof(NrealPackageInstaller)}", false))
            {
                EditorPreferences.Set($"{nameof(NrealPackageInstaller)}", PackageInstaller.TryInstallAssets(HiddenPath, DefaultPath));
            }
        }
    }
}
