// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from pulse/introspect.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport(libraryPath, EntryPoint = "pa_context_get_sink_info_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sink_info_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sink_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sink_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_volume_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_volume_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_volume_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_volume_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_mute_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_mute_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_mute_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_mute_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_suspend_sink_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_sink_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* sink_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_suspend_sink_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_sink_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_port_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_port_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_port_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_port_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_source_info_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_source_info_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_source_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_source_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_volume_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_volume_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_volume_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_volume_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_mute_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_mute_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_mute_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_mute_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_suspend_source_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_source_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* source_name, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_suspend_source_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_suspend_source_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int suspend, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_port_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_port_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_port_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_port_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* port, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_server_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_server_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_server_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_module_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_module_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_module_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_module_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_module_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_module_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_load_module", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_load_module([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_unload_module", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_unload_module([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_client_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_client_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_client_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_client_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_client_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_client_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_kill_client", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_client([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_card_info_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_card_info_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_card_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_card_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_card_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_card_profile_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_card_profile_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_card_profile_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_card_profile_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* profile, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_port_latency_offset", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_port_latency_offset([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* card_name, [NativeTypeName("const char *")] sbyte* port_name, [NativeTypeName("int64_t")] IntPtr offset, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sink_input_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_input_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sink_input_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sink_input_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sink_input_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sink_input_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_move_sink_input_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_sink_input_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* sink_name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_move_sink_input_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_sink_input_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint sink_idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_input_volume", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_input_volume([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_sink_input_mute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_sink_input_mute([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_kill_sink_input", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_sink_input([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_source_output_info", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_output_info([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_source_output_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_source_output_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_source_output_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_source_output_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_move_source_output_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_source_output_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const char *")] sbyte* source_name, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_move_source_output_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_move_source_output_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("uint32_t")] uint source_idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_output_volume", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_output_volume([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("const pa_cvolume *")] pa_cvolume* volume, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_set_source_output_mute", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_set_source_output_mute([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, int mute, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_kill_source_output", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_kill_source_output([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_stat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_stat([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_stat_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sample_info_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sample_info_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_sample_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_sample_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_sample_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_autoload_info_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_autoload_info_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_get_autoload_info_list", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_get_autoload_info_list([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("pa_autoload_info_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_add_autoload", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_add_autoload([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("const char *")] sbyte* module, [NativeTypeName("const char *")] sbyte* argument, [NativeTypeName("pa_context_index_cb_t")] IntPtr param5, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_remove_autoload_by_name", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_autoload_by_name([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("pa_autoload_type_t")] pa_autoload_type type, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);

        [DllImport(libraryPath, EntryPoint = "pa_context_remove_autoload_by_index", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("pa_operation *")]
        public static extern pa_operation* pa_context_remove_autoload_by_index([NativeTypeName("pa_context *")] pa_context* c, [NativeTypeName("uint32_t")] uint idx, [NativeTypeName("pa_context_success_cb_t")] IntPtr cb, [NativeTypeName("void *")] void* userdata);
    }
}
