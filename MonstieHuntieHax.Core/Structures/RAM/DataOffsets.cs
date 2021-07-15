namespace MonstieHuntieHax.Core
{
    public static class DataOffsets
    {
        /// <summary>
        /// Main game pointers for game version 1.0.3
        /// </summary>
        public const string PointerZeni = "[heap+40732670]"; // u32
        public const string PointerBottleCaps = "[heap+407335FE]"; // u16
        public const string PointerCharmMight = "[heap+40733446]"; // u16
        public const string PointerCharmMounting = "[heap+40733426]"; // u16

        /// <summary>
        /// Distances
        /// </summary>


        /// <summary>
        /// Deprecated (for an older game version)
        /// </summary


        /// <summary>
        /// Unused (And possibly also deprecated)
        /// </summary>
        // Rider HP for v1.0.3, can't be updated in battle so use is limited. Might need a heap address.
        // public const string PointerRiderHP = "[[[[[main+2161A70]+98]+148]+60]+10]";
    }
}
