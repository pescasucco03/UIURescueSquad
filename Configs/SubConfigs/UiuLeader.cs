﻿namespace UIURescueSquad.Configs.SubConfigs
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Enums;

    /// <summary>
    /// Configs for UIU Leader, equivalent of <see cref="RoleType.NtfCaptain"/>.
    /// </summary>
    public class SeeNoEvilLeader
    {
        /// <summary>
        /// Gets UIU Leader health.
        /// </summary>
        [Description("UIU Leader health.")]
        public float Health { get; private set; } = 160f;

        /// <summary>
        /// Gets UIU Leader inventory.
        /// </summary>
        [Description("UIU Leader inventory:")]
        public List<string> Inventory { get; private set; } = new List<string>
        {
            "KeycardNTFLieutenant",
            "GunE11SR",
            "GunCOM18",
            "Medkit",
            "Adrenaline",
            "Radio",
            "GrenadeFrag",
            "ArmorHeavy",
        };

        /// <summary>
        /// Gets UIU Leader ammo.
        /// </summary>
        [Description("UIU Leader ammo:")]
        public Dictionary<AmmoType, ushort> Ammo { get; private set; } = new Dictionary<AmmoType, ushort>
        {
            { AmmoType.Nato556, 140 },
            { AmmoType.Nato762, 0 },
            { AmmoType.Nato9, 120 },
        };

        /// <summary>
        /// Gets UIU Leader rank seen in-game instead of standard NTF role.
        /// </summary>
        [Description("UIU Leader rank seen in-game.")]
        public string Rank { get; private set; } = "Comandante SeeNoEvil";
    }
}
