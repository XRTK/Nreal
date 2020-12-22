// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the Nreal platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("1C4598F7-A765-4934-A4B2-3E3F451F87A7")]
    public class NrealPlatform : BasePlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override bool IsBuildTargetAvailable
        {
            get
            {
                return false;
            }
        }
    }
}
