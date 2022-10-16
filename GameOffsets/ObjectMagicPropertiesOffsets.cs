using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ObjectMagicPropertiesOffsets
    {
        [FieldOffset(0x13C)] public int Rarity;  //3.19.1c=> 0x120 + 0x1c
        [FieldOffset(0x160)] public NativePtrArray Mods; //3.19.1c
    }
}
