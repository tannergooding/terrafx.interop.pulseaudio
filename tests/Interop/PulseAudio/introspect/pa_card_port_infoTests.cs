// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/pulse/introspect.h in PulseAudio 13.0
// Original source is Copyright © Holders. Licensed under the GNU Lesser Public License 2.1 (LGPL-2.1). See Notice.md in the repository root for more information.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="pa_card_port_info" /> struct.</summary>
    public static unsafe class pa_card_port_infoTests
    {
        /// <summary>Validates that the <see cref="pa_card_port_info" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<pa_card_port_info>(), Is.EqualTo(sizeof(pa_card_port_info)));
        }

        /// <summary>Validates that the <see cref="pa_card_port_info" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(pa_card_port_info).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="pa_card_port_info" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(pa_card_port_info), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(pa_card_port_info), Is.EqualTo(40));
            }
        }
    }
}