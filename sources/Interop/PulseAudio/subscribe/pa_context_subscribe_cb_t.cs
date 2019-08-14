// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/subscribe.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void pa_context_subscribe_cb_t([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_subscription_event_type_t")] pa_subscription_event_type t, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("void *")] void* userdata);
}