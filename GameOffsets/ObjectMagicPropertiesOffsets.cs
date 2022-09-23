using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ObjectMagicPropertiesOffsets
    {
        [FieldOffset(0x13C)] public int Rarity;
        [FieldOffset(0x160)] public NativePtrArray Mods;
    }
}
