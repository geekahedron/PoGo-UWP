﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Enums
{
    public class MiscEnums
    {
        public enum FortType 
        {
            GYM = 0,
            CHECKPOINT = 1
        }

        public enum Item
        {
            ITEM_UNKNOWN = 0,
            ITEM_POKE_BALL = 1,
            ITEM_GREAT_BALL = 2,
            ITEM_ULTRA_BALL = 3,
            ITEM_MASTER_BALL = 4,
            ITEM_POTION = 101,
            ITEM_SUPER_POTION = 102,
            ITEM_HYPER_POTION = 103,
            ITEM_MAX_POTION = 104,
            ITEM_REVIVE = 201,
            ITEM_MAX_REVIVE = 202,
            ITEM_LUCKY_EGG = 301,
            ITEM_INCENSE_ORDINARY = 401,
            ITEM_INCENSE_SPICY = 402,
            ITEM_INCENSE_COOL = 403,
            ITEM_INCENSE_FLORAL = 404,
            ITEM_TROY_DISK = 501,
            ITEM_X_ATTACK = 602,
            ITEM_X_DEFENSE = 603,
            ITEM_X_MIRACLE = 604,
            ITEM_RAZZ_BERRY = 701,
            ITEM_BLUK_BERRY = 702,
            ITEM_NANAB_BERRY = 703,
            ITEM_WEPAR_BERRY = 704,
            ITEM_PINAP_BERRY = 705,
            ITEM_SPECIAL_CAMERA = 801,
            ITEM_INCUBATOR_BASIC_UNLIMITED = 901,
            ITEM_INCUBATOR_BASIC = 902,
            ITEM_POKEMON_STORAGE_UPGRADE = 1001,
            ITEM_ITEM_STORAGE_UPGRADE = 1002
        }
    }
}