// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop-signal.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_signal_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* api, [NativeTypeName("pa_signal_event *")] pa_signal_event* e, [NativeTypeName("void *")] void* userdata);
}
