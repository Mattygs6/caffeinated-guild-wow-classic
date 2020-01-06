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
        ""name"": ""Manastorm Leggings"",
        ""price"": 2,
        ""id"": 18872,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron, Gehennas, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18872""
    },
    {
        ""name"": ""Choker of Enlightenment"",
        ""price"": 5,
        ""id"": 17109,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17109""
    },
    {
        ""name"": ""Heavy Dark Iron Ring"",
        ""price"": 45,
        ""id"": 18879,
        ""fortank"": ""Yes"",
        ""bosses"": ""Lucifron, Gehennas, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18879""
    },
    {
        ""name"": ""Flamewaker Legplates"",
        ""price"": 5,
        ""id"": 18861,
        ""fortank"": ""Yes"",
        ""bosses"": ""Lucifron, Magmadar, Gehennas, Garr, Baron Geddon, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18861""
    },
    {
        ""name"": ""Ring of Spell Power"",
        ""price"": 45,
        ""id"": 19147,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron, Gehennas, Shazzrah, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19147""
    },
    {
        ""name"": ""Robe of Volatile Power"",
        ""price"": 50,
        ""id"": 19145,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron, Gehennas, Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19145""
    },
    {
        ""name"": ""Helm of the Lifegiver"",
        ""price"": 20,
        ""id"": 18870,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18870""
    },
    {
        ""name"": ""Earthshaker"",
        ""price"": 2,
        ""id"": 17073,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17073""
    },
    {
        ""name"": ""Mana Igniting Cord"",
        ""price"": 50,
        ""id"": 19136,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19136""
    },
    {
        ""name"": ""Strikers Mark"",
        ""price"": 50,
        ""id"": 17069,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17069""
    },
    {
        ""name"": ""Medallion of Steadfast Might"",
        ""price"": 40,
        ""id"": 17065,
        ""fortank"": ""Yes"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17065""
    },
    {
        ""name"": ""Eskhandar's Right Claw"",
        ""price"": 40,
        ""id"": 18203,
        ""fortank"": ""Yes"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18203""
    },
    {
        ""name"": ""Fire Runed Grimoire"",
        ""price"": 15,
        ""id"": 19142,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19142""
    },
    {
        ""name"": ""Flameguard Gauntlets"",
        ""price"": 40,
        ""id"": 19143,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19143""
    },
    {
        ""name"": ""Obsidian Edged Blade"",
        ""price"": 55,
        ""id"": 18822,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18822""
    },
    {
        ""name"": ""Quick Strike Ring"",
        ""price"": 50,
        ""id"": 18821,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18821""
    },
    {
        ""name"": ""Talisman of Ephemeral Power"",
        ""price"": 50,
        ""id"": 18820,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18820""
    },
    {
        ""name"": ""Aged Core Leather Gloves"",
        ""price"": 50,
        ""id"": 18823,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon, Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18823""
    },
    {
        ""name"": ""Magma Tempered Boots"",
        ""price"": 2,
        ""id"": 18824,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar, Garr, Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18824""
    },
    {
        ""name"": ""Sabatons of the Flamewalker"",
        ""price"": 2,
        ""id"": 19144,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19144""
    },
    {
        ""name"": ""Crimson Shocker"",
        ""price"": 0,
        ""id"": 17077,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas, Shazzrah, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17077""
    },
    {
        ""name"": ""Sorcerous Dagger"",
        ""price"": 20,
        ""id"": 18878,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas, Shazzrah, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18878""
    },
    {
        ""name"": ""Wristguards of Stability"",
        ""price"": 50,
        ""id"": 19146,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19146""
    },
    {
        ""name"": ""Salamander Scale Pants"",
        ""price"": 40,
        ""id"": 18875,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas, Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18875""
    },
    {
        ""name"": ""Aurastone Hammer"",
        ""price"": 40,
        ""id"": 17105,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17105""
    },
    {
        ""name"": ""Brutality Blade"",
        ""price"": 40,
        ""id"": 18832,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18832""
    },
    {
        ""name"": ""Drillborer Disk"",
        ""price"": 40,
        ""id"": 17066,
        ""fortank"": ""Yes"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17066""
    },
    {
        ""name"": ""Gutgore Ripper"",
        ""price"": 5,
        ""id"": 17071,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17071""
    },
    {
        ""name"": ""Seal of the Archmagus"",
        ""price"": 0,
        ""id"": 17110,
        ""fortank"": ""No"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17110""
    },
    {
        ""name"": ""Bindings of the Windseeker"",
        ""price"": 120,
        ""id"": 18564,
        ""fortank"": ""Yes"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18564""
    },
    {
        ""name"": ""Azuresong Mageblade"",
        ""price"": 60,
        ""id"": 17103,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17103""
    },
    {
        ""name"": ""Staff of Dominance"",
        ""price"": 60,
        ""id"": 18842,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18842""
    },
    {
        ""name"": ""Blastershot Launcher"",
        ""price"": 2,
        ""id"": 17072,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17072""
    },
    {
        ""name"": ""Shadowstrike"",
        ""price"": 2,
        ""id"": 17074,
        ""fortank"": ""No"",
        ""bosses"": ""Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17074""
    },
    {
        ""name"": ""Core Hound Tooth"",
        ""price"": 50,
        ""id"": 18805,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18805""
    },
    {
        ""name"": ""Fireproof Cloak"",
        ""price"": 0,
        ""id"": 18811,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18811""
    },
    {
        ""name"": ""Sash of Whispered Secrets"",
        ""price"": 40,
        ""id"": 18809,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18809""
    },
    {
        ""name"": ""Wild Growth Spaulders"",
        ""price"": 55,
        ""id"": 18810,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18810""
    },
    {
        ""name"": ""Wristguards of True Flight"",
        ""price"": 10,
        ""id"": 18812,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18812""
    },
    {
        ""name"": ""Core Forged Greaves"",
        ""price"": 0,
        ""id"": 18806,
        ""fortank"": ""Yes"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18806""
    },
    {
        ""name"": ""Finkle's Lava Dredger"",
        ""price"": 25,
        ""id"": 18803,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18803""
    },
    {
        ""name"": ""Fireguard Shoulders"",
        ""price"": 0,
        ""id"": 19139,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19139""
    },
    {
        ""name"": ""Gloves of the Hypnotic Flame"",
        ""price"": 15,
        ""id"": 18808,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18808""
    },
    {
        ""name"": ""Cauterizing Band"",
        ""price"": 50,
        ""id"": 19140,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19140""
    },
    {
        ""name"": ""Perditions Blade"",
        ""price"": 50,
        ""id"": 18816,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18816""
    },
    {
        ""name"": ""Band of Sulfuras"",
        ""price"": 20,
        ""id"": 19138,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19138""
    },
    {
        ""name"": ""Crown of Destruction"",
        ""price"": 30,
        ""id"": 18817,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18817""
    },
    {
        ""name"": ""Band of Accuria"",
        ""price"": 50,
        ""id"": 17063,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17063""
    },
    {
        ""name"": ""Dragon's Blood Cape"",
        ""price"": 0,
        ""id"": 17107,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17107""
    },
    {
        ""name"": ""Essence of the Pure Flame"",
        ""price"": 2,
        ""id"": 18815,
        ""fortank"": ""Yes"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18815""
    },
    {
        ""name"": ""Choker of the Fire Lord"",
        ""price"": 55,
        ""id"": 18814,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18814""
    },
    {
        ""name"": ""Cloak of the Shrouded Mists"",
        ""price"": 50,
        ""id"": 17102,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17102""
    },
    {
        ""name"": ""Malistar's Defender"",
        ""price"": 40,
        ""id"": 17106,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17106""
    },
    {
        ""name"": ""Onslaught Girdle"",
        ""price"": 60,
        ""id"": 19137,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=19137""
    },
    {
        ""name"": ""Shard of Flame"",
        ""price"": 0,
        ""id"": 17082,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17082""
    },
    {
        ""name"": ""Spinal Reaper"",
        ""price"": 45,
        ""id"": 17104,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17104""
    },
    {
        ""name"": ""Bonereaver's Edge"",
        ""price"": 80,
        ""id"": 17076,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17076""
    },
    {
        ""name"": ""Eye of Sulfuras"",
        ""price"": 120,
        ""id"": 17204,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=17204""
    },
    {
        ""name"": ""Vis'kag the Bloodletter"",
        ""price"": 40,
        ""id"": 17075,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=17075""
    },
    {
        ""name"": ""Ancient Cornerstone Grimoire"",
        ""price"": 2,
        ""id"": 17067,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=17067""
    },
    {
        ""name"": ""Ring of Binding"",
        ""price"": 0,
        ""id"": 18813,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=18813""
    },
    {
        ""name"": ""Sapphiron Drape"",
        ""price"": 20,
        ""id"": 17078,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=17078""
    },
    {
        ""name"": ""Eskhandar's Collar"",
        ""price"": 20,
        ""id"": 18205,
        ""fortank"": ""Yes"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=18205""
    },
    {
        ""name"": ""Deathbringer"",
        ""price"": 20,
        ""id"": 17068,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=17068""
    },
    {
        ""name"": ""Shard of Scale"",
        ""price"": 55,
        ""id"": 17064,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=17064""
    },
    {
        ""name"": ""Head of Onyxia"",
        ""price"": 50,
        ""id"": 18422,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=18422""
    },
    {
        ""name"": ""Mature Black Dragon Sinew"",
        ""price"": 5,
        ""id"": 18705,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=18705""
    },
    {
        ""name"": ""Nemesis Skullcap"",
        ""price"": 30,
        ""id"": 16929,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16929""
    },
    {
        ""name"": ""Stormrage Cover"",
        ""price"": 30,
        ""id"": 16900,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16900""
    },
    {
        ""name"": ""Dragonstalker's Helm"",
        ""price"": 30,
        ""id"": 16939,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16939""
    },
    {
        ""name"": ""Netherwind Crown"",
        ""price"": 30,
        ""id"": 16914,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16914""
    },
    {
        ""name"": ""Bloodfang Hood"",
        ""price"": 30,
        ""id"": 16908,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16908""
    },
    {
        ""name"": ""Halo of Transcendence"",
        ""price"": 30,
        ""id"": 16921,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16921""
    },
    {
        ""name"": ""Helm of Wrath"",
        ""price"": 30,
        ""id"": 16963,
        ""fortank"": ""Yes"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16963""
    },
    {
        ""name"": ""Judgement Crown"",
        ""price"": 30,
        ""id"": 16955,
        ""fortank"": ""No"",
        ""bosses"": ""Onyxia"",
        ""raid"": ""Onyxia"",
        ""url"": ""https://classic.wowhead.com/item=16955""
    },
    {
        ""name"": ""Gauntlets of Might"",
        ""price"": 20,
        ""id"": 16863,
        ""fortank"": ""Yes"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16863""
    },
    {
        ""name"": ""Felheart Gloves"",
        ""price"": 20,
        ""id"": 16805,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16805""
    },
    {
        ""name"": ""Cenarion Boots"",
        ""price"": 20,
        ""id"": 16829,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16829""
    },
    {
        ""name"": ""Arcanist Boots"",
        ""price"": 20,
        ""id"": 16800,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16800""
    },
    {
        ""name"": ""Lawbringer Boots"",
        ""price"": 20,
        ""id"": 16859,
        ""fortank"": ""No"",
        ""bosses"": ""Lucifron"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16859""
    },
    {
        ""name"": ""Lawbringer Gauntlets"",
        ""price"": 20,
        ""id"": 16860,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16860""
    },
    {
        ""name"": ""Lawbringer Belt"",
        ""price"": 20,
        ""id"": 16858,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16858""
    },
    {
        ""name"": ""Lawbringer Bracers"",
        ""price"": 20,
        ""id"": 16857,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16857""
    },
    {
        ""name"": ""Lawbringer Spaulders"",
        ""price"": 20,
        ""id"": 16856,
        ""fortank"": ""No"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16856""
    },
    {
        ""name"": ""Lawbringer Legplates"",
        ""price"": 2,
        ""id"": 16855,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16855""
    },
    {
        ""name"": ""Lawbringer Helm"",
        ""price"": 2,
        ""id"": 16854,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16854""
    },
    {
        ""name"": ""Lawbringer Chestguard"",
        ""price"": 20,
        ""id"": 16853,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16853""
    },
    {
        ""name"": ""Judgement Legplates"",
        ""price"": 30,
        ""id"": 16954,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16954""
    },
    {
        ""name"": ""Pauldrons of Might"",
        ""price"": 20,
        ""id"": 16868,
        ""fortank"": ""Yes"",
        ""bosses"": ""Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16868""
    },
    {
        ""name"": ""Legplates of Might"",
        ""price"": 2,
        ""id"": 16867,
        ""fortank"": ""Yes"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16867""
    },
    {
        ""name"": ""Helm of Might"",
        ""price"": 2,
        ""id"": 16866,
        ""fortank"": ""Yes"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16866""
    },
    {
        ""name"": ""Breatplate of Might"",
        ""price"": 20,
        ""id"": 16865,
        ""fortank"": ""Yes"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16865""
    },
    {
        ""name"": ""Belt of Might"",
        ""price"": 20,
        ""id"": 16864,
        ""fortank"": ""Yes"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16864""
    },
    {
        ""name"": ""Sabatons of Might"",
        ""price"": 20,
        ""id"": 16862,
        ""fortank"": ""Yes"",
        ""bosses"": ""Gehennas"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16862""
    },
    {
        ""name"": ""Bracers of Might"",
        ""price"": 20,
        ""id"": 16861,
        ""fortank"": ""Yes"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16861""
    },
    {
        ""name"": ""Legplates of Wrath"",
        ""price"": 30,
        ""id"": 16962,
        ""fortank"": ""Yes"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16962""
    },
    {
        ""name"": ""Boots of Prophecy"",
        ""price"": 20,
        ""id"": 16811,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16811""
    },
    {
        ""name"": ""Gloves of Prophecy"",
        ""price"": 20,
        ""id"": 16812,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16812""
    },
    {
        ""name"": ""Circlet of Prophecy"",
        ""price"": 2,
        ""id"": 16813,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16813""
    },
    {
        ""name"": ""Pants of Prophecy"",
        ""price"": 2,
        ""id"": 16814,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16814""
    },
    {
        ""name"": ""Robes of Prophecy"",
        ""price"": 20,
        ""id"": 16815,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16815""
    },
    {
        ""name"": ""Mantle of Prophecy"",
        ""price"": 20,
        ""id"": 16816,
        ""fortank"": ""No"",
        ""bosses"": ""Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16816""
    },
    {
        ""name"": ""Girdle of Prophecy"",
        ""price"": 20,
        ""id"": 16817,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16817""
    },
    {
        ""name"": ""Vambraces of Prophecy"",
        ""price"": 20,
        ""id"": 16819,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16819""
    },
    {
        ""name"": ""Leggings of Transcendence"",
        ""price"": 30,
        ""id"": 16922,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16922""
    },
    {
        ""name"": ""Cenarion Belt"",
        ""price"": 20,
        ""id"": 16828,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16828""
    },
    {
        ""name"": ""Cenarion Bracers"",
        ""price"": 20,
        ""id"": 16830,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16830""
    },
    {
        ""name"": ""Cenarion Gloves"",
        ""price"": 20,
        ""id"": 16831,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16831""
    },
    {
        ""name"": ""Cenarion Vestments"",
        ""price"": 20,
        ""id"": 16833,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16833""
    },
    {
        ""name"": ""Cenarion Helm"",
        ""price"": 2,
        ""id"": 16834,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16834""
    },
    {
        ""name"": ""Cenarion Leggings"",
        ""price"": 2,
        ""id"": 16835,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16835""
    },
    {
        ""name"": ""Cenarion Spaulders"",
        ""price"": 20,
        ""id"": 16836,
        ""fortank"": ""No"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16836""
    },
    {
        ""name"": ""Stormrage Legguards"",
        ""price"": 30,
        ""id"": 16901,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16901""
    },
    {
        ""name"": ""Felheart Slippers"",
        ""price"": 20,
        ""id"": 16803,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16803""
    },
    {
        ""name"": ""Felheart Bracers"",
        ""price"": 20,
        ""id"": 16804,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16804""
    },
    {
        ""name"": ""Felheart Belt"",
        ""price"": 20,
        ""id"": 16806,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16806""
    },
    {
        ""name"": ""Felheart Shoulder Pads"",
        ""price"": 20,
        ""id"": 16807,
        ""fortank"": ""No"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16807""
    },
    {
        ""name"": ""Felheart Horns"",
        ""price"": 2,
        ""id"": 16808,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16808""
    },
    {
        ""name"": ""Felheart Robes"",
        ""price"": 20,
        ""id"": 16809,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16809""
    },
    {
        ""name"": ""Felheart Pants"",
        ""price"": 2,
        ""id"": 16810,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16810""
    },
    {
        ""name"": ""Nemesis Leggings"",
        ""price"": 30,
        ""id"": 16930,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16930""
    },
    {
        ""name"": ""Arcanist Crown"",
        ""price"": 2,
        ""id"": 16795,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16795""
    },
    {
        ""name"": ""Arcanist Leggings"",
        ""price"": 2,
        ""id"": 16796,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16796""
    },
    {
        ""name"": ""Arcanist Mantle"",
        ""price"": 20,
        ""id"": 16797,
        ""fortank"": ""No"",
        ""bosses"": ""Baron Geddon"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16797""
    },
    {
        ""name"": ""Arcanist Robes"",
        ""price"": 20,
        ""id"": 16798,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16798""
    },
    {
        ""name"": ""Arcanist Bindings"",
        ""price"": 20,
        ""id"": 16799,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16799""
    },
    {
        ""name"": ""Arcanist Gloves"",
        ""price"": 20,
        ""id"": 16801,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16801""
    },
    {
        ""name"": ""Arcanist Belt"",
        ""price"": 20,
        ""id"": 16802,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16802""
    },
    {
        ""name"": ""Netherwind Pants"",
        ""price"": 30,
        ""id"": 16915,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16915""
    },
    {
        ""name"": ""Nightslayer Chestpiece"",
        ""price"": 20,
        ""id"": 16820,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16820""
    },
    {
        ""name"": ""Nightslayer Cover"",
        ""price"": 2,
        ""id"": 16821,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16821""
    },
    {
        ""name"": ""Nightslayer Pants"",
        ""price"": 2,
        ""id"": 16822,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16822""
    },
    {
        ""name"": ""Nightslayer Shoulder Pads"",
        ""price"": 20,
        ""id"": 16823,
        ""fortank"": ""No"",
        ""bosses"": ""Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16823""
    },
    {
        ""name"": ""Nightslayer Boots"",
        ""price"": 20,
        ""id"": 16824,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16824""
    },
    {
        ""name"": ""Nightslayer Bracelets"",
        ""price"": 20,
        ""id"": 16825,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16825""
    },
    {
        ""name"": ""Nightslayer Gloves"",
        ""price"": 20,
        ""id"": 16826,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16826""
    },
    {
        ""name"": ""Nightslayer Belt"",
        ""price"": 20,
        ""id"": 16827,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16827""
    },
    {
        ""name"": ""Bloodfang Pants"",
        ""price"": 30,
        ""id"": 16909,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16909""
    },
    {
        ""name"": ""Giantstalker's Breastplate"",
        ""price"": 20,
        ""id"": 16845,
        ""fortank"": ""No"",
        ""bosses"": ""Golemagg"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16845""
    },
    {
        ""name"": ""Giantstalker's Helmet"",
        ""price"": 2,
        ""id"": 16846,
        ""fortank"": ""No"",
        ""bosses"": ""Garr"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16846""
    },
    {
        ""name"": ""Giantstalker's Leggings"",
        ""price"": 2,
        ""id"": 16847,
        ""fortank"": ""No"",
        ""bosses"": ""Magmadar"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16847""
    },
    {
        ""name"": ""Giantstalker's Epaulets"",
        ""price"": 20,
        ""id"": 16848,
        ""fortank"": ""No"",
        ""bosses"": ""Sulfuron Harbinger"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16848""
    },
    {
        ""name"": ""Giantstalker's Boots"",
        ""price"": 20,
        ""id"": 16849,
        ""fortank"": ""No"",
        ""bosses"": ""Gehennas"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16849""
    },
    {
        ""name"": ""Giantstalker's Bracers"",
        ""price"": 20,
        ""id"": 16850,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16850""
    },
    {
        ""name"": ""Giantstalker's Belt"",
        ""price"": 20,
        ""id"": 16851,
        ""fortank"": ""No"",
        ""bosses"": ""Trash"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16851""
    },
    {
        ""name"": ""Giantstalker's Gloves"",
        ""price"": 20,
        ""id"": 16852,
        ""fortank"": ""No"",
        ""bosses"": ""Shazzrah"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16852""
    },
    {
        ""name"": ""Dragonstalker's Legguards"",
        ""price"": 30,
        ""id"": 16938,
        ""fortank"": ""No"",
        ""bosses"": ""Ragnaros"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=16938""
    },
    {
        ""name"": ""The Eye of Divinity"",
        ""price"": 45,
        ""id"": 18646,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18646""
    },
    {
        ""name"": ""Ancient Petrified Leaf"",
        ""price"": 40,
        ""id"": 18703,
        ""fortank"": ""No"",
        ""bosses"": ""Major Domo"",
        ""raid"": ""Molten Core"",
        ""url"": ""https://classic.wowhead.com/item=18703""
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
