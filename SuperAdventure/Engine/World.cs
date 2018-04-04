﻿using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();



        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;


        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ItemID.RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5));
            Items.Add(new Item(ItemID.ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails"));
            Items.Add(new Item(ItemID.PIECE_OF_FUR, "Piece of fur", "Pieces of fur"));
            Items.Add(new Item(ItemID.SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(new Item(ItemID.SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(new Weapon(ItemID.CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new HealingPotion(ItemID.HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(new Item(ItemID.SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(new Item(ItemID.SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(new Item(ItemID.ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ItemID.ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ItemID.PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ItemID.SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ItemID.SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ItemID.SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ItemID.SPIDER_SILK), 25, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QuestID.CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.",
                20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ItemID.ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ItemID.HEALING_POTION);

            Quest clearFarmersField = new Quest(QuestID.CLEAR_FARMERS_FIELD, "Clear the farmer's field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.",
                20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ItemID.SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ItemID.ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LocationID.HOME, "Home", "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LocationID.TOWN_SQUARE, "Town square", "You see a fountain.");

            Location alchemistHut = new Location(LocationID.ALCHEMIST_HUT, "Alchemist's hut",
                "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QuestID.CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LocationID.ALCHEMISTS_GARDEN, "Alchemist's garden",
                "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LocationID.FARMHOUSE, "Farmhouse",
                "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QuestID.CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LocationID.FARM_FIELD, "Farmer's field",
                "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LocationID.GUARD_POST, "Guard post",
                "There is a large, tough-looking guard here.", ItemByID(ItemID.ADVENTURER_PASS));
            Location bridge = new Location(LocationID.BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LocationID.SPIDER_FIELD, "Forest",
                "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(ItemID id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(QuestID id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(LocationID id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
