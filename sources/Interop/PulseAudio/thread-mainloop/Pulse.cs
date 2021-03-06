// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/thread-mainloop.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_threaded_mainloop *")]
        public static extern IntPtr pa_threaded_mainloop_new();

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_free([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_threaded_mainloop_start([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_stop([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_lock([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_unlock([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_wait([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_signal([NativeTypeName("pa_threaded_mainloop *")] IntPtr m, int wait_for_accept);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_accept([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_threaded_mainloop_get_retval([NativeTypeName("const pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_mainloop_api *")]
        public static extern pa_mainloop_api* pa_threaded_mainloop_get_api([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_threaded_mainloop_in_thread([NativeTypeName("pa_threaded_mainloop *")] IntPtr m);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_set_name([NativeTypeName("pa_threaded_mainloop *")] IntPtr m, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern void pa_threaded_mainloop_once_unlocked([NativeTypeName("pa_threaded_mainloop *")] IntPtr m, [NativeTypeName("void (*)(pa_threaded_mainloop *, void *)")] delegate* unmanaged<IntPtr, void*, void> callback, [NativeTypeName("void *")] void* userdata);
    }
}
