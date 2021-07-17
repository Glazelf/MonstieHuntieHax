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
        /// Pointers that should really be optimized out as to not need this many pointers (mostly items).
        /// All items are u16, max 999
        /// </summary>
        // Other Items
        public const string PointerDustOfLife = "[heap+407326A6]";
        public const string PointerAncientPotion = "[heap+407326B6]";
        public const string PointerHeartChurro = "[heap+407354E6]";
        public const string PointerSurrogateGem = "[heap+407328EE]";
        public const string PointerPowerPaintball = "[heap+40732B0E]";
        public const string PointerSuperWhetstone = "[heap+407327EE]";
        public const string PointerMegaBarrelBomb = "[heap+40732B16]";
        public const string PointerWeaponSphereL = "[heap+4073550E]";
        public const string PointerArmorSphereL = "[heap+407354F6]";

        /// <summary>
        /// Distances between offsets
        /// </summary>
        public const int DifferenceCharmGathering = 0x10;
        public const int DifferenceCharms = 0x8;

        /// <summary>
        /// Altering Pointers
        /// </summary>
        // Charms
        private static readonly int OffsetCharmTraining = 0x407333FE;
        private static readonly int OffsetCharmGathering = OffsetCharmTraining + DifferenceCharmGathering;
        private static readonly int OffsetCharmLucky = OffsetCharmGathering + DifferenceCharms * 1;
        private static readonly int OffsetCharmFinding = OffsetCharmGathering + DifferenceCharms * 2;
        private static readonly int OffsetCharmMounting = OffsetCharmGathering + DifferenceCharms * 3;
        private static readonly int OffsetCharmSelling = OffsetCharmGathering + DifferenceCharms * 4;
        private static readonly int OffsetCharmBuying = OffsetCharmGathering + DifferenceCharms * 5;
        private static readonly int OffsetCharmAdamant = OffsetCharmGathering + DifferenceCharms * 6;
        private static readonly int OffsetCharmMight = OffsetCharmGathering + DifferenceCharms * 7;
        private static readonly int OffsetCharmRecovery = OffsetCharmGathering + DifferenceCharms * 8;

        public static string PointerCharmTraining = $"[heap+{OffsetCharmTraining:X}]";
        public static string PointerCharmGathering = $"[heap+{OffsetCharmGathering:X}]";
        public static string PointerCharmLucky = $"[heap+{OffsetCharmLucky:X}]";
        public static string PointerCharmFinding = $"[heap+{OffsetCharmFinding:X}]";
        public static string PointerCharmMounting = $"[heap+{OffsetCharmMounting:X}]";
        public static string PointerCharmSelling = $"[heap+{OffsetCharmSelling:X}]";
        public static string PointerCharmBuying = $"[heap+{OffsetCharmBuying:X}]";
        public static string PointerCharmAdamant = $"[heap+{OffsetCharmAdamant:X}]";
        public static string PointerCharmMight = $"[heap+{OffsetCharmMight:X}]";
        public static string PointerCharmRecovery = $"[heap+{OffsetCharmRecovery:X}]";


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
