// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/scache.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_connect_upload([NativeTypeName("pa_stream *")] pa_stream* s, [NativeTypeName("size_t")] nuint length);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_stream_finish_upload([NativeTypeName("pa_stream *")] pa_stream* s);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_sample([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_play_sample([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_play_sample_with_proplist([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* dev, [NativeTypeName("pa_volume_t")] uint volume, [NativeTypeName("const pa_proplist *")] pa_proplist* proplist, [NativeTypeName("pa_context_play_sample_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
