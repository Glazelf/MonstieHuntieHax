namespace MonstieHuntieHax.Core
{
    public static class DataOffsets
    {
        /// <summary>
        /// Pointers for game version 1.0.3
        /// </summary>
        public const string PointerZeni = "[heap+40732670]"; // u32
        public const string PointerBottleCaps = "[heap+407335FE]"; // u16

        /// <summary>
        /// Pointers that should really be optimized out as to not need this many pointers (mostly items)
        /// </summary>
        public const string PointerCharmTraining = "[heap+407333FE]"; // All items are u16
        public const string PointerDustOfLife = "[heap+407326A6]";
        public const string PointerAncientPotion = "[heap+407326B6]";
        public const string PointerHeartChurro = "[heap+407354E6]";
        public const string PointerSurrogateGem = "[heap+407328EE]";
        public const string PointerPowerPaintball = "[heap+40732B0E]";
        public const string PointerSuperWhetstone = "[heap+407327EE]";
        public const string PointerWeaponSphereL = "[heap+4073550E]";

        /// <summary>
        /// Distances between offsets
        /// </summary>
        // Make these interpolated once that isn't a preview feature anymore
        public const string PointerCharmGathering = PointerCharmTraining + "+16";
        public const string PointerCharmLucky = PointerCharmGathering + "+8";
        public const string PointerCharmFinding = PointerCharmLucky + "+8";
        public const string PointerCharmMounting = PointerCharmFinding + "+8";
        public const string PointerCharmSelling = PointerCharmMounting + "+8";
        public const string PointerCharmBuying = PointerCharmSelling + "+8";
        public const string PointerCharmAdamant = PointerCharmBuying + "+8";
        public const string PointerCharmMight = PointerCharmAdamant + "+8";
        public const string PointerCharmRecovery = PointerCharmMight + "+8";


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
