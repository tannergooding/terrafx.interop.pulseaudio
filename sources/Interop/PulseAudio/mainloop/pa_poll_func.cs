// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int pa_poll_func([NativeTypeName("struct pollfd *")] pollfd* ufds, [NativeTypeName("unsigned long")] UIntPtr nfds, int timeout, [NativeTypeName("void *")] void* userdata);
}