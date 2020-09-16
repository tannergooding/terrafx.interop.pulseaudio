// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/volume.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Pulse
    {
        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_cvolume_equal([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_init([NativeTypeName("pa_cvolume *")] pa_cvolume* a);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set([NativeTypeName("pa_cvolume *")] pa_cvolume* a, [NativeTypeName("unsigned int")] uint channels, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_cvolume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_sw_cvolume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_cvolume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("const pa_cvolume *")] pa_cvolume* c, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, int print_dB);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_volume_snprint([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_sw_volume_snprint_dB([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* pa_volume_snprint_verbose([NativeTypeName("char *")] sbyte* s, [NativeTypeName("size_t")] nuint l, [NativeTypeName("pa_volume_t")] uint v, int print_dB);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_avg([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_avg_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_max([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_max_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_min([NativeTypeName("const pa_cvolume *")] pa_cvolume* a);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_min_mask([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_cvolume_valid([NativeTypeName("const pa_cvolume *")] pa_cvolume* v);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_cvolume_channels_equal_to([NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_multiply([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_multiply([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_multiply_scalar([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_divide([NativeTypeName("pa_volume_t")] uint a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_divide([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_sw_cvolume_divide_scalar([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("pa_volume_t")] uint b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_from_dB(double f);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern double pa_sw_volume_to_dB([NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_sw_volume_from_linear(double v);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern double pa_sw_volume_to_linear([NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_remap([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* from, [NativeTypeName("const pa_channel_map *")] pa_channel_map* to);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_cvolume_compatible([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_sample_spec *")] pa_sample_spec* ss);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern int pa_cvolume_compatible_with_channel_map([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern float pa_cvolume_get_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_balance([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern float pa_cvolume_get_fade([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_fade([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_fade);

        [DllImport("libpulse", ExactSpelling = true)]
        public static extern float pa_cvolume_get_lfe_balance([NativeTypeName("const pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_lfe_balance([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, float new_balance);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_scale([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_scale_mask([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint max, [NativeTypeName("const pa_channel_map *")] pa_channel_map* cm, [NativeTypeName("pa_channel_position_mask_t")] nuint mask);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_set_position([NativeTypeName("pa_cvolume *")] pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_channel_position_t")] pa_channel_position t, [NativeTypeName("pa_volume_t")] uint v);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_volume_t")]
        public static extern uint pa_cvolume_get_position([NativeTypeName("const pa_cvolume *")] pa_cvolume* cv, [NativeTypeName("const pa_channel_map *")] pa_channel_map* map, [NativeTypeName("pa_channel_position_t")] pa_channel_position t);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_merge([NativeTypeName("pa_cvolume *")] pa_cvolume* dest, [NativeTypeName("const pa_cvolume *")] pa_cvolume* a, [NativeTypeName("const pa_cvolume *")] pa_cvolume* b);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_inc_clamp([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc, [NativeTypeName("pa_volume_t")] uint limit);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_inc([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint inc);

        [DllImport("libpulse", ExactSpelling = true)]
        [return: NativeTypeName("pa_cvolume *")]
        public static extern pa_cvolume* pa_cvolume_dec([NativeTypeName("pa_cvolume *")] pa_cvolume* v, [NativeTypeName("pa_volume_t")] uint dec);
    }
}
