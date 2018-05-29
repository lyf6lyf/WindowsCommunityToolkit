// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// The blade mode.
    /// </summary>
    public enum BladeMode
    {
        /// <summary>
        /// Default mode : each blade will take the specified Width and Height
        /// </summary>
        Normal,

        /// <summary>
        /// Fullscreen mode : each blade will take the entire Width and Height of the UI control container (cf <see cref="BladeView"/>)
        /// </summary>
        Fullscreen
    }
}
