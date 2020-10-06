﻿using MCDSaveEdit.Save.Models.Profiles;
using System.Collections.Generic;
using System.Linq;

namespace MCDSaveEdit.Save.Models.Enums
{
    public static class EnchantmentExtensions
    {
        private static HashSet<string> powerful = new HashSet<string>() {
            "FinalShout",
            "Chilling",
            "Protection",
            "GravityPulse",
            
            "CriticalHit",
            "Exploding",
            "RadianceMelee",
            "GravityMelee",
            "Shockwave",
            "Swirling",
            
            "Gravity",
            "TempoTheft",
            "ChainReaction",
            "RadianceRanged",
        };

        public static HashSet<string> forArmor = new HashSet<string>() {
            "Swiftfooted",
            "PotionFortification",
            "Snowing",
            "SurpriseGift",
            "Burning",
            "Cowardice",
            "Deflecting",
            "Electrified",
            "Thorns",
            "Explorer",
            "Frenzied",
            "Celerity",
            "Recycler",
            "FoodReserves",
            "FireTrail",
            "HealthSynergy",
            "SpeedSynergy",
            "SpiritSpeed",
            
            "FinalShout",
            "Chilling",
            "Protection",
            "GravityPulse",
        };

        public static HashSet<string> forMelee = new HashSet<string>() {
            "Weakening",
            "FireAspect",
            "Looting",
            "Chains",
            "Echo",
            "Stunning",
            "Rampaging",
            "Freezing",
            "Committed",
            "PoisonedMelee",
            "Prospector",
            "EnigmaResonatorMelee",
            "SoulSiphon",
            "Thundering",
            "Sharpness",
            "Leeching",
            
            "CriticalHit",
            "Exploding",
            "RadianceMelee",
            "GravityMelee",
            "Shockwave",
            "Swirling",
        };

        public static HashSet<string> forRanged = new HashSet<string>() {
            "Accelerating",
            "Growing",
            "AnimaConduitRanged",
            "RapidFire",
            "Infinity",
            "Unchanting",
            "Piercing",
            "Power",
            "WildRage",
            "Punch",
            "Ricochet",
            "Supercharge",
            "FuseShot",
            "BonusShot",
            "FireAspect",
            "MultiShot",
            
            "Gravity",
            "TempoTheft",
            "ChainReaction",
            "RadianceRanged",
        };

        public static bool isPowerful(this Enchantment enchantment)
        {
            return powerful.Contains(enchantment.Id);
        }

        public static int pointsCost(this Enchantment enchantment)
        {
            if (enchantment.isPowerful())
            {
                if(enchantment.Level < GameCalculator.powerfulEnchantmentCostForLevel.Length)
                {
                    return GameCalculator.powerfulEnchantmentCostForLevel[enchantment.Level];
                }
                else
                {
                    return GameCalculator.powerfulEnchantmentCostForLevel.Last();
                }
            }
            else
            {
                if(enchantment.Level < GameCalculator.enchantmentCostForLevel.Length)
                {
                    return GameCalculator.enchantmentCostForLevel[enchantment.Level];
                }
                else
                {
                    return GameCalculator.enchantmentCostForLevel.Last();
                }
            }
        }
    }
}
