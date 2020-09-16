// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/channelmap.h in PulseAudio 12.2
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

namespace TerraFX.Interop
{
    public enum pa_channel_position
    {
        PA_CHANNEL_POSITION_INVALID = -1,
        PA_CHANNEL_POSITION_MONO = 0,
        PA_CHANNEL_POSITION_FRONT_LEFT,
        PA_CHANNEL_POSITION_FRONT_RIGHT,
        PA_CHANNEL_POSITION_FRONT_CENTER,
        PA_CHANNEL_POSITION_LEFT = PA_CHANNEL_POSITION_FRONT_LEFT,
        PA_CHANNEL_POSITION_RIGHT = PA_CHANNEL_POSITION_FRONT_RIGHT,
        PA_CHANNEL_POSITION_CENTER = PA_CHANNEL_POSITION_FRONT_CENTER,
        PA_CHANNEL_POSITION_REAR_CENTER,
        PA_CHANNEL_POSITION_REAR_LEFT,
        PA_CHANNEL_POSITION_REAR_RIGHT,
        PA_CHANNEL_POSITION_LFE,
        PA_CHANNEL_POSITION_SUBWOOFER = PA_CHANNEL_POSITION_LFE,
        PA_CHANNEL_POSITION_FRONT_LEFT_OF_CENTER,
        PA_CHANNEL_POSITION_FRONT_RIGHT_OF_CENTER,
        PA_CHANNEL_POSITION_SIDE_LEFT,
        PA_CHANNEL_POSITION_SIDE_RIGHT,
        PA_CHANNEL_POSITION_AUX0,
        PA_CHANNEL_POSITION_AUX1,
        PA_CHANNEL_POSITION_AUX2,
        PA_CHANNEL_POSITION_AUX3,
        PA_CHANNEL_POSITION_AUX4,
        PA_CHANNEL_POSITION_AUX5,
        PA_CHANNEL_POSITION_AUX6,
        PA_CHANNEL_POSITION_AUX7,
        PA_CHANNEL_POSITION_AUX8,
        PA_CHANNEL_POSITION_AUX9,
        PA_CHANNEL_POSITION_AUX10,
        PA_CHANNEL_POSITION_AUX11,
        PA_CHANNEL_POSITION_AUX12,
        PA_CHANNEL_POSITION_AUX13,
        PA_CHANNEL_POSITION_AUX14,
        PA_CHANNEL_POSITION_AUX15,
        PA_CHANNEL_POSITION_AUX16,
        PA_CHANNEL_POSITION_AUX17,
        PA_CHANNEL_POSITION_AUX18,
        PA_CHANNEL_POSITION_AUX19,
        PA_CHANNEL_POSITION_AUX20,
        PA_CHANNEL_POSITION_AUX21,
        PA_CHANNEL_POSITION_AUX22,
        PA_CHANNEL_POSITION_AUX23,
        PA_CHANNEL_POSITION_AUX24,
        PA_CHANNEL_POSITION_AUX25,
        PA_CHANNEL_POSITION_AUX26,
        PA_CHANNEL_POSITION_AUX27,
        PA_CHANNEL_POSITION_AUX28,
        PA_CHANNEL_POSITION_AUX29,
        PA_CHANNEL_POSITION_AUX30,
        PA_CHANNEL_POSITION_AUX31,
        PA_CHANNEL_POSITION_TOP_CENTER,
        PA_CHANNEL_POSITION_TOP_FRONT_LEFT,
        PA_CHANNEL_POSITION_TOP_FRONT_RIGHT,
        PA_CHANNEL_POSITION_TOP_FRONT_CENTER,
        PA_CHANNEL_POSITION_TOP_REAR_LEFT,
        PA_CHANNEL_POSITION_TOP_REAR_RIGHT,
        PA_CHANNEL_POSITION_TOP_REAR_CENTER,
        PA_CHANNEL_POSITION_MAX,
    }
}
