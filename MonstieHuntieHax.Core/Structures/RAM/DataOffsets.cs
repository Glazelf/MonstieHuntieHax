namespace MonstieHuntieHax.Core
{
    public static class DataOffsets
    {
        /// <summary>
        /// Main game pointers
        ///Main game pointers are currently working upto 1.0.3, theoretically item pointers can be found around the bottlecap pointers
        /// </summary>

        /// <summary>
        /// Demo pointers
        /// no work needed
        /// </summary>
        
        // Pointer list
        public const string PointerZeni = "[heap+40732670]"; //1.0.3 zenny, u32 datatype
        public const string PointerBottleCaps = "[heap+407335FE]"; //1.0.3 bottle caps, u16 datatype

        /// <summary>
        /// Distances
        /// </summary>

        /// <summary>
        /// Everything below here is deprecated
        /// </summary

        /// <summary>
        /// Unused
        /// </summary>
       
        // Rider HP, can't be updated like this mid-battle, have not found another good usecase for it yet.
        // public const string PointerRiderHP = "[[[[[main+2161A70]+98]+148]+60]+10]"; ///need to change to an address in heap.
    }
}
