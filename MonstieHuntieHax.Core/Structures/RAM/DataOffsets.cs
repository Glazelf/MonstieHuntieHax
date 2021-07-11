namespace MonstieHuntieHax.Core
{
    public static class DataOffsets
    {
        /// <summary>
        /// Main game pointers for game version 1.0.3
        /// </summary>
        public const string PointerZeni = "[heap+40732670]"; // u32
        public const string PointerBottleCaps = "[heap+407335FE]"; //u16

        /// <summary>
        /// Distances
        /// </summary>


        /// <summary>
        /// Deprecated (for an older game version)
        /// </summary


        /// <summary>
        /// Unused (And possibly also deprecated)
        /// </summary>
        // Rider HP, can't be updated like this mid-battle, have not found another good usecase for it yet.
        // public const string PointerRiderHP = "[[[[[main+2161A70]+98]+148]+60]+10]"; // Might need to change to an address in heap.
    }
}
