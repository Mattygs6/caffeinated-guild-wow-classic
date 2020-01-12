using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace json_lua_converter
{
    class Program
    {
        // TODO: Read source json
        static void Main(string[] args)
        {
						var raid_drop_data = @"[
    {
        ""name"": ""Aegis of Preservation"",
        ""price"": 0,
        ""id"": 19345,
        ""fortank"": ""No"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19345"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Amulet of Shadow Shielding"",
        ""price"": 0,
        ""id"": 21529,
        ""fortank"": ""Yes"",
        ""bosses"": ""Nefarius's Corruption"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=21529"",
        ""type"": ""Neck""
    },
    {
        ""name"": ""Angelista's Grasp"",
        ""price"": 5,
        ""id"": 19388,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19388"",
        ""type"": ""Cloth Waist""
    },
    {
        ""name"": ""Arcane Infused Gem"",
        ""price"": 0,
        ""id"": 19336,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19336"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Archimtiros' Ring of Reckoning"",
        ""price"": 5,
        ""id"": 19376,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19376"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Ashjre'thul, Crossbow of Smiting"",
        ""price"": 65,
        ""id"": 19361,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19361"",
        ""type"": ""Ranged Crossbow""
    },
    {
        ""name"": ""Ashkandi, Greatsword of the Brotherhood"",
        ""price"": 45,
        ""id"": 19364,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19364"",
        ""type"": ""Two-hand Sword""
    },
    {
        ""name"": ""Band of Dark Dominion"",
        ""price"": 20,
        ""id"": 19434,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19434"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Band of Forced Concentration"",
        ""price"": 30,
        ""id"": 19403,
        ""fortank"": ""No"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19403"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Belt of Transcendence"",
        ""price"": 15,
        ""id"": 16925,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16925"",
        ""type"": ""Cloth Waist""
    },
    {
        ""name"": ""Bindings of Transcendence"",
        ""price"": 15,
        ""id"": 16926,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16926"",
        ""type"": ""Cloth Wrists""
    },
    {
        ""name"": ""Black Ash Robe"",
        ""price"": 0,
        ""id"": 19399,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19399"",
        ""type"": ""Cloth Chest""
    },
    {
        ""name"": ""Black Brood Pauldrons"",
        ""price"": 2,
        ""id"": 19373,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19373"",
        ""type"": ""Mail Shoulders""
    },
    {
        ""name"": ""Bloodfang Belt"",
        ""price"": 15,
        ""id"": 16910,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16910"",
        ""type"": ""Leather Waist""
    },
    {
        ""name"": ""Bloodfang Boots"",
        ""price"": 20,
        ""id"": 16906,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16906"",
        ""type"": ""Leather Feet""
    },
    {
        ""name"": ""Bloodfang Bracers"",
        ""price"": 15,
        ""id"": 16911,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16911"",
        ""type"": ""Leather Wrists""
    },
    {
        ""name"": ""Bloodfang Chestpiece"",
        ""price"": 25,
        ""id"": 16905,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16905"",
        ""type"": ""Leather Chest""
    },
    {
        ""name"": ""Bloodfang Gloves"",
        ""price"": 5,
        ""id"": 16907,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16907"",
        ""type"": ""Leather Hands""
    },
    {
        ""name"": ""Bloodfang Spaulders"",
        ""price"": 20,
        ""id"": 16832,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16832"",
        ""type"": ""Leather Shoulders""
    },
    {
        ""name"": ""Boots of Pure Thought"",
        ""price"": 20,
        ""id"": 19437,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19437"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Boots of the Shadow Flame"",
        ""price"": 40,
        ""id"": 19381,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19381"",
        ""type"": ""Leather Feet""
    },
    {
        ""name"": ""Boots of Transcendence"",
        ""price"": 20,
        ""id"": 16919,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16919"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Bracelets of Wrath"",
        ""price"": 15,
        ""id"": 16959,
        ""fortank"": ""Yes"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16959"",
        ""type"": ""Plate Wrists""
    },
    {
        ""name"": ""Bracers of Arcane Accuracy"",
        ""price"": 25,
        ""id"": 19374,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19374"",
        ""type"": ""Cloth Wrists""
    },
    {
        ""name"": ""Breastplate of Wrath"",
        ""price"": 25,
        ""id"": 16966,
        ""fortank"": ""Yes"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16966"",
        ""type"": ""Plate Chest""
    },
    {
        ""name"": ""Chromatic Boots"",
        ""price"": 65,
        ""id"": 19387,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19387"",
        ""type"": ""Plate Feet""
    },
    {
        ""name"": ""Chromatically Tempered Sword"",
        ""price"": 50,
        ""id"": 19352,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19352"",
        ""type"": ""One-hand Sword""
    },
    {
        ""name"": ""Circle of Applied Force"",
        ""price"": 10,
        ""id"": 19432,
        ""fortank"": ""No"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19432"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Claw of Chromaggus"",
        ""price"": 40,
        ""id"": 19347,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19347"",
        ""type"": ""One-hand Dagger""
    },
    {
        ""name"": ""Claw of the Black Drake"",
        ""price"": 5,
        ""id"": 19365,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19365"",
        ""type"": ""Main Hand Fist""
    },
    {
        ""name"": ""Cloak of Draconic Might"",
        ""price"": 30,
        ""id"": 19436,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19436"",
        ""type"": ""Cloth Back""
    },
    {
        ""name"": ""Cloak of Firemaw"",
        ""price"": 15,
        ""id"": 19398,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19398"",
        ""type"": ""Cloth Back""
    },
    {
        ""name"": ""Cloak of the Brood Lord"",
        ""price"": 20,
        ""id"": 19378,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19378"",
        ""type"": ""Cloth Back""
    },
    {
        ""name"": ""Crul'shorukh, Edge of Chaos"",
        ""price"": 20,
        ""id"": 19363,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19363"",
        ""type"": ""One-hand Axe""
    },
    {
        ""name"": ""Doom's Edge"",
        ""price"": 10,
        ""id"": 19362,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19362"",
        ""type"": ""One-hand Axe""
    },
    {
        ""name"": ""Draconic Avenger"",
        ""price"": 5,
        ""id"": 19354,
        ""fortank"": ""No"",
        ""bosses"": ""Death Talon Wyrmguard"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19354"",
        ""type"": ""Two-hand Axe""
    },
    {
        ""name"": ""Draconic Maul"",
        ""price"": 10,
        ""id"": 19358,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19358"",
        ""type"": ""Two-hand Mace""
    },
    {
        ""name"": ""Dragon's Touch"",
        ""price"": 5,
        ""id"": 19367,
        ""fortank"": ""No"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19367"",
        ""type"": ""Ranged Wand""
    },
    {
        ""name"": ""Dragonbreath Hand Cannon"",
        ""price"": 10,
        ""id"": 19368,
        ""fortank"": ""Yes"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19368"",
        ""type"": ""Ranged Gun""
    },
    {
        ""name"": ""Dragonfang Blade"",
        ""price"": 40,
        ""id"": 19346,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19346"",
        ""type"": ""One-hand Dagger""
    },
    {
        ""name"": ""Dragonstalker's Belt"",
        ""price"": 15,
        ""id"": 16936,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16936"",
        ""type"": ""Mail Waist""
    },
    {
        ""name"": ""Dragonstalker's Bracers"",
        ""price"": 15,
        ""id"": 16935,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16935"",
        ""type"": ""Mail Wrists""
    },
    {
        ""name"": ""Dragonstalker's Breastplate"",
        ""price"": 25,
        ""id"": 16942,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16942"",
        ""type"": ""Mail Chest""
    },
    {
        ""name"": ""Dragonstalker's Gauntlets"",
        ""price"": 20,
        ""id"": 16940,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16940"",
        ""type"": ""Mail Hands""
    },
    {
        ""name"": ""Dragonstalker's Greaves"",
        ""price"": 20,
        ""id"": 16941,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16941"",
        ""type"": ""Mail Feet""
    },
    {
        ""name"": ""Dragonstalker's Spaulders"",
        ""price"": 40,
        ""id"": 16937,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16937"",
        ""type"": ""Mail Shoulders""
    },
    {
        ""name"": ""Drake Fang Talisman"",
        ""price"": 60,
        ""id"": 19406,
        ""fortank"": ""No"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19406"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Drake Talon Cleaver"",
        ""price"": 30,
        ""id"": 19353,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19353"",
        ""type"": ""Two-hand Axe""
    },
    {
        ""name"": ""Drake Talon Pauldrons"",
        ""price"": 40,
        ""id"": 19394,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19394"",
        ""type"": ""Plate Shoulders""
    },
    {
        ""name"": ""Ebony Flame Gloves"",
        ""price"": 20,
        ""id"": 19407,
        ""fortank"": ""No"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19407"",
        ""type"": ""Cloth Hands""
    },
    {
        ""name"": ""Elementium Reinforced Bulwark"",
        ""price"": 40,
        ""id"": 19349,
        ""fortank"": ""Yes"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19349"",
        ""type"": ""Shield""
    },
    {
        ""name"": ""Elementium Threaded Cloak"",
        ""price"": 20,
        ""id"": 19386,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19386"",
        ""type"": ""Cloth Back""
    },
    {
        ""name"": ""Emberweave Leggings"",
        ""price"": 0,
        ""id"": 19433,
        ""fortank"": ""No"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19433"",
        ""type"": ""Mail Legs""
    },
    {
        ""name"": ""Empowered Leggings"",
        ""price"": 30,
        ""id"": 19385,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19385"",
        ""type"": ""Cloth Legs""
    },
    {
        ""name"": ""Essence Gatherer"",
        ""price"": 10,
        ""id"": 19435,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19435"",
        ""type"": ""Ranged Wand""
    },
    {
        ""name"": ""Firemaw's Clutch"",
        ""price"": 15,
        ""id"": 19400,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19400"",
        ""type"": ""Cloth Waist""
    },
    {
        ""name"": ""Gauntlets of Wrath"",
        ""price"": 20,
        ""id"": 16964,
        ""fortank"": ""Yes"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16964"",
        ""type"": ""Plate Hands""
    },
    {
        ""name"": ""Girdle of the Fallen Crusader"",
        ""price"": 2,
        ""id"": 19392,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19392"",
        ""type"": ""Plate Waist""
    },
    {
        ""name"": ""Gloves of Rapid Evolution"",
        ""price"": 2,
        ""id"": 19369,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19369"",
        ""type"": ""Cloth Hands""
    },
    {
        ""name"": ""Handguards of Transcendence"",
        ""price"": 20,
        ""id"": 16920,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16920"",
        ""type"": ""Cloth Hands""
    },
    {
        ""name"": ""Head of Nefarian"",
        ""price"": 30,
        ""id"": 19002,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19002"",
        ""type"": ""Bloody Head""
    },
    {
        ""name"": ""Heartstriker"",
        ""price"": 2,
        ""id"": 19350,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19350"",
        ""type"": ""Ranged Bow""
    },
    {
        ""name"": ""Helm of Endless Rage"",
        ""price"": 10,
        ""id"": 19372,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19372"",
        ""type"": ""Plate Head""
    },
    {
        ""name"": ""Herald of Woe"",
        ""price"": 20,
        ""id"": 19357,
        ""fortank"": ""No"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19357"",
        ""type"": ""Two-hand Mace""
    },
    {
        ""name"": ""Interlaced Shadow Jerkin"",
        ""price"": 2,
        ""id"": 19439,
        ""fortank"": ""No"",
        ""bosses"": ""Death Talon Wyrmguard"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19439"",
        ""type"": ""Leather Chest""
    },
    {
        ""name"": ""Judgement Belt"",
        ""price"": 5,
        ""id"": 16952,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16952"",
        ""type"": ""Plate Waist""
    },
    {
        ""name"": ""Judgement Bindings"",
        ""price"": 5,
        ""id"": 16951,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16951"",
        ""type"": ""Plate Wrists""
    },
    {
        ""name"": ""Judgement Breastplate"",
        ""price"": 15,
        ""id"": 16958,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16958"",
        ""type"": ""Plate Chest""
    },
    {
        ""name"": ""Judgement Gauntlets"",
        ""price"": 10,
        ""id"": 16956,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16956"",
        ""type"": ""Plate Hands""
    },
    {
        ""name"": ""Judgement Sabatons"",
        ""price"": 10,
        ""id"": 16957,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16957"",
        ""type"": ""Plate Feet""
    },
    {
        ""name"": ""Judgement Spaulders"",
        ""price"": 10,
        ""id"": 16953,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16953"",
        ""type"": ""Plate Shoulders""
    },
    {
        ""name"": ""Legguards of the Fallen Crusader"",
        ""price"": 50,
        ""id"": 19402,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19402"",
        ""type"": ""Plate Legs""
    },
    {
        ""name"": ""Lifegiving Gem"",
        ""price"": 0,
        ""id"": 19341,
        ""fortank"": ""Yes"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19341"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Lok'amir il Romathis"",
        ""price"": 45,
        ""id"": 19360,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19360"",
        ""type"": ""Main Hand Mace""
    },
    {
        ""name"": ""Maladath, Runed Blade of the Black Flight"",
        ""price"": 40,
        ""id"": 19351,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19351"",
        ""type"": ""One-hand Sword""
    },
    {
        ""name"": ""Malfurion's Blessed Bulwark"",
        ""price"": 40,
        ""id"": 19405,
        ""fortank"": ""No"",
        ""bosses"": ""Ebonroc"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19405"",
        ""type"": ""Leather Chest""
    },
    {
        ""name"": ""Mantle of the Blackwing Cabal"",
        ""price"": 30,
        ""id"": 19370,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19370"",
        ""type"": ""Cloth Shoulders""
    },
    {
        ""name"": ""Mind Quickening Gem"",
        ""price"": 10,
        ""id"": 19339,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19339"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Mish'undare, Circlet of the Mind Flayer"",
        ""price"": 40,
        ""id"": 19375,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19375"",
        ""type"": ""Cloth Head""
    },
    {
        ""name"": ""Neltharion's Tear"",
        ""price"": 60,
        ""id"": 19379,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19379"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Nemesis Belt"",
        ""price"": 5,
        ""id"": 16933,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16933"",
        ""type"": ""Cloth Waist""
    },
    {
        ""name"": ""Nemesis Boots"",
        ""price"": 10,
        ""id"": 16927,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16927"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Nemesis Bracers"",
        ""price"": 5,
        ""id"": 16934,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16934"",
        ""type"": ""Cloth Wrists""
    },
    {
        ""name"": ""Nemesis Gloves"",
        ""price"": 10,
        ""id"": 16928,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16928"",
        ""type"": ""Cloth Hands""
    },
    {
        ""name"": ""Nemesis Robes"",
        ""price"": 15,
        ""id"": 16931,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16931"",
        ""type"": ""Cloth Chest""
    },
    {
        ""name"": ""Nemesis Spaulders"",
        ""price"": 10,
        ""id"": 16932,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16932"",
        ""type"": ""Cloth Shoulders""
    },
    {
        ""name"": ""Netherwind Belt"",
        ""price"": 5,
        ""id"": 16818,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16818"",
        ""type"": ""Cloth Waist""
    },
    {
        ""name"": ""Netherwind Bindings"",
        ""price"": 10,
        ""id"": 16918,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16918"",
        ""type"": ""Cloth Wrists""
    },
    {
        ""name"": ""Netherwind Boots"",
        ""price"": 10,
        ""id"": 16912,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16912"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Netherwind Gloves"",
        ""price"": 20,
        ""id"": 16913,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16913"",
        ""type"": ""Cloth Hands""
    },
    {
        ""name"": ""Netherwind Mantle"",
        ""price"": 10,
        ""id"": 16917,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16917"",
        ""type"": ""Cloth Shoulders""
    },
    {
        ""name"": ""Netherwind Robes"",
        ""price"": 15,
        ""id"": 16916,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16916"",
        ""type"": ""Cloth Chest""
    },
    {
        ""name"": ""Pauldrons of Transcendence"",
        ""price"": 40,
        ""id"": 16924,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16924"",
        ""type"": ""Cloth Shoulders""
    },
    {
        ""name"": ""Pauldrons of Wrath"",
        ""price"": 20,
        ""id"": 16961,
        ""fortank"": ""Yes"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16961"",
        ""type"": ""Plate Shoulders""
    },
    {
        ""name"": ""Pendant of the Fallen Dragon"",
        ""price"": 2,
        ""id"": 19371,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19371"",
        ""type"": ""Neck""
    },
    {
        ""name"": ""Prestor's Talisman of Connivery"",
        ""price"": 10,
        ""id"": 19377,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19377"",
        ""type"": ""Neck""
    },
    {
        ""name"": ""Primalist's Linked Legguards"",
        ""price"": 0,
        ""id"": 19401,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19401"",
        ""type"": ""Mail Legs""
    },
    {
        ""name"": ""Primalist's Linked Waistguard"",
        ""price"": 0,
        ""id"": 19393,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19393"",
        ""type"": ""Mail Waist""
    },
    {
        ""name"": ""Pure Elementium Band"",
        ""price"": 40,
        ""id"": 19382,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19382"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Red Dragonscale Protector"",
        ""price"": 15,
        ""id"": 19348,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19348"",
        ""type"": ""Shield""
    },
    {
        ""name"": ""Rejuvenating Gem"",
        ""price"": 60,
        ""id"": 19395,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19395"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Ring of Blackrock"",
        ""price"": 10,
        ""id"": 19397,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19397"",
        ""type"": ""Finger""
    },
    {
        ""name"": ""Ringo's Blizzard Boots"",
        ""price"": 30,
        ""id"": 19438,
        ""fortank"": ""No"",
        ""bosses"": ""Death Talon Wyrmguard"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19438"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Robes of Transcendence"",
        ""price"": 25,
        ""id"": 16923,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16923"",
        ""type"": ""Cloth Chest""
    },
    {
        ""name"": ""Rune of Metamorphosis"",
        ""price"": 0,
        ""id"": 19340,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19340"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Sabatons of Wrath"",
        ""price"": 20,
        ""id"": 16965,
        ""fortank"": ""Yes"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16965"",
        ""type"": ""Plate Feet""
    },
    {
        ""name"": ""Scrolls of Blinding Light"",
        ""price"": 0,
        ""id"": 19343,
        ""fortank"": ""No"",
        ""bosses"": ""Firemaw"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19343"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Shadow Wing Focus Staff"",
        ""price"": 10,
        ""id"": 19355,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19355"",
        ""type"": ""Two-hand Staff""
    },
    {
        ""name"": ""Shimmering Geta"",
        ""price"": 2,
        ""id"": 19391,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19391"",
        ""type"": ""Cloth Feet""
    },
    {
        ""name"": ""Shroud of Pure Thought"",
        ""price"": 10,
        ""id"": 19430,
        ""fortank"": ""No"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19430"",
        ""type"": ""Cloth Back""
    },
    {
        ""name"": ""Spineshatter"",
        ""price"": 50,
        ""id"": 19335,
        ""fortank"": ""Yes"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19335"",
        ""type"": ""Main Hand Mace""
    },
    {
        ""name"": ""Staff of the Shadow Flame"",
        ""price"": 65,
        ""id"": 19356,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19356"",
        ""type"": ""Two-hand Staff""
    },
    {
        ""name"": ""Stormrage Belt"",
        ""price"": 15,
        ""id"": 16903,
        ""fortank"": ""No"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16903"",
        ""type"": ""Leather Waist""
    },
    {
        ""name"": ""Stormrage Boots"",
        ""price"": 20,
        ""id"": 16898,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16898"",
        ""type"": ""Leather Feet""
    },
    {
        ""name"": ""Stormrage Bracers"",
        ""price"": 15,
        ""id"": 16904,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16904"",
        ""type"": ""Leather Wrists""
    },
    {
        ""name"": ""Stormrage Chestguard"",
        ""price"": 25,
        ""id"": 16897,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16897"",
        ""type"": ""Leather Chest""
    },
    {
        ""name"": ""Stormrage Handguards"",
        ""price"": 30,
        ""id"": 16899,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16899"",
        ""type"": ""Leather Hands""
    },
    {
        ""name"": ""Stormrage Pauldrons"",
        ""price"": 20,
        ""id"": 16902,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16902"",
        ""type"": ""Leather Shoulders""
    },
    {
        ""name"": ""Styleen's Impeding Scarab"",
        ""price"": 60,
        ""id"": 19431,
        ""fortank"": ""Yes"",
        ""bosses"": ""Flamegor"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19431"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Taut Dragonhide Belt"",
        ""price"": 2,
        ""id"": 19396,
        ""fortank"": ""No"",
        ""bosses"": ""Zone Drop"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19396"",
        ""type"": ""Leather Waist""
    },
    {
        ""name"": ""Taut Dragonhide Gloves"",
        ""price"": 10,
        ""id"": 19390,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19390"",
        ""type"": ""Leather Hands""
    },
    {
        ""name"": ""Taut Dragonhide Shoulderpads"",
        ""price"": 30,
        ""id"": 19389,
        ""fortank"": ""No"",
        ""bosses"": ""Chromaggus"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19389"",
        ""type"": ""Leather Shoulders""
    },
    {
        ""name"": ""The Black Book"",
        ""price"": 0,
        ""id"": 19337,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19337"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""The Untamed Blade"",
        ""price"": 50,
        ""id"": 19334,
        ""fortank"": ""No"",
        ""bosses"": ""Razorgore the Untamed"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19334"",
        ""type"": ""Two-hand Sword""
    },
    {
        ""name"": ""Therazane's Link"",
        ""price"": 2,
        ""id"": 19380,
        ""fortank"": ""No"",
        ""bosses"": ""Nefarian"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19380"",
        ""type"": ""Mail Waist""
    },
    {
        ""name"": ""Venomous Totem"",
        ""price"": 0,
        ""id"": 19342,
        ""fortank"": ""No"",
        ""bosses"": ""Broodlord Lashlayer"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=19342"",
        ""type"": ""Trinket""
    },
    {
        ""name"": ""Waistband of Wrath"",
        ""price"": 15,
        ""id"": 16960,
        ""fortank"": ""Yes"",
        ""bosses"": ""Vaelastrasz the Corrupt"",
        ""raid"": ""Blackwing Lair"",
        ""url"": ""https://classic.wowhead.com/item=16960"",
        ""type"": ""Plate Waist""
    }
]";
            var data = JsonConvert.DeserializeObject<object[]>(raid_drop_data);

            var lines = new List<string>(128);
            lines.Add("local raid_drop_data = {");


            foreach(dynamic datum in data)
            {
                lines.Add($"[{datum.id}] = {datum.price},");
            }

            lines.Add("}");
            
            var outputDirectory = new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);

            while(!string.Equals(outputDirectory.Name, "json-lua-converter", StringComparison.InvariantCultureIgnoreCase))
            {
                outputDirectory = outputDirectory.Parent;
            }
            
            using(var output = new StreamWriter(Path.Combine(outputDirectory.FullName, "raid_drop_data.lua")))
            {
                foreach(var line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
