// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/mainloop-api.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_defer_event_destroy_cb_t([NativeTypeName("pa_mainloop_api *")] pa_mainloop_api* a, [NativeTypeName("pa_defer_event *")] pa_defer_event* e, [NativeTypeName("void *")] void* userdata);
}