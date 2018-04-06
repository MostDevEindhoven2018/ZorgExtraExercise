using Engine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Engine
{
    public static class World
    {
        public static readonly Dictionary<ItemID, Item> Items = new Dictionary<ItemID, Item>();
        public static readonly Dictionary<MonsterID, Monster> Monsters = new Dictionary<MonsterID, Monster>();
        private static readonly List<Monster> _randomMonsters = new List<Monster>();
        private static Task loadRandMonstersTask;
        public static List<Monster> RandomMonsters { get {
                loadRandMonstersTask?.Wait();
                return _randomMonsters;
            } }
        public static readonly Dictionary<QuestID, Quest> Quests = new Dictionary<QuestID, Quest>();
        public static readonly Dictionary<LocationID, Location> Locations = new Dictionary<LocationID, Location>();

        public static void InitWorld()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
            loadRandMonstersTask = Task.Run(LoadGeneratedMonsters);
            Console.WriteLine(_randomMonsters.Count);
            Console.WriteLine(RandomMonsters.Count);
        }

        private static void PopulateItems()
        {
            Item item = new Weapon(ItemID.RUSTY_SWORD, "Rusty sword", "Rusty swords", 0, 5);
            Items.Add(item.ID, item);

            item = new Item(ItemID.ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails");
            Items.Add(item.ID, item);

            item = new Item(ItemID.PIECE_OF_FUR, "Piece of fur", "Pieces of fur");
            Items.Add(item.ID, item);

            item = (new Item(ItemID.SNAKE_FANG, "Snake fang", "Snake fangs"));
            Items.Add(item.ID, item);

            item = (new Item(ItemID.SNAKESKIN, "Snakeskin", "Snakeskins"));
            Items.Add(item.ID, item);

            item = (new Weapon(ItemID.CLUB, "Club", "Clubs", 3, 10));
            Items.Add(item.ID, item);

            item = (new HealingPotion(ItemID.HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(item.ID, item);

            item = (new Item(ItemID.SPIDER_FANG, "Spider fang", "Spider fangs"));
            Items.Add(item.ID, item);

            item = (new Item(ItemID.SPIDER_SILK, "Spider silk", "Spider silks"));
            Items.Add(item.ID, item);

            item = (new Item(ItemID.ADVENTURER_PASS, "Adventurer pass", "Adventurer passes"));
            Items.Add(item.ID, item);
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MonsterID.RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(Items[(ItemID.ITEM_ID_RAT_TAIL)], 75, false));
            rat.LootTable.Add(new LootItem(Items[(ItemID.PIECE_OF_FUR)], 75, true));

            Monster snake = new Monster(MonsterID.SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(Items[(ItemID.SNAKE_FANG)], 75, false));
            snake.LootTable.Add(new LootItem(Items[(ItemID.SNAKESKIN)], 75, true));

            Monster giantSpider = new Monster(MonsterID.GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(Items[ItemID.SPIDER_FANG], 75, true));
            giantSpider.LootTable.Add(new LootItem(Items[(ItemID.SPIDER_SILK)], 25, false));

            Monsters.Add(rat.ID, rat);
            Monsters.Add(snake.ID, snake);
            Monsters.Add(giantSpider.ID, giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden = new Quest(QuestID.CLEAR_ALCHEMIST_GARDEN, "Clear the alchemist's garden",
                "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.",
                20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(Items[(ItemID.ITEM_ID_RAT_TAIL)], 3));

            clearAlchemistGarden.RewardItem = Items[(ItemID.HEALING_POTION)];

            Quest clearFarmersField = new Quest(QuestID.CLEAR_FARMERS_FIELD, "Clear the farmer's field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.",
                20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(Items[(ItemID.SNAKE_FANG)], 3));

            clearFarmersField.RewardItem = Items[(ItemID.ADVENTURER_PASS)];

            Quests.Add(clearAlchemistGarden.ID, clearAlchemistGarden);
            Quests.Add(clearFarmersField.ID, clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LocationID.HOME, "Home", "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LocationID.TOWN_SQUARE, "Town square", "You see a fountain.");

            Location alchemistHut = new Location(LocationID.ALCHEMIST_HUT, "Alchemist's hut",
                "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = Quests[(QuestID.CLEAR_ALCHEMIST_GARDEN)];

            Location alchemistsGarden = new Location(LocationID.ALCHEMISTS_GARDEN, "Alchemist's garden",
                "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = Monsters[(MonsterID.RAT)];

            Location farmhouse = new Location(LocationID.FARMHOUSE, "Farmhouse",
                "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = Quests[(QuestID.CLEAR_FARMERS_FIELD)];

            Location farmersField = new Location(LocationID.FARM_FIELD, "Farmer's field",
                "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = Monsters[(MonsterID.SNAKE)];

            Location guardPost = new Location(LocationID.GUARD_POST, "Guard post",
                "There is a large, tough-looking guard here.", Items[(ItemID.ADVENTURER_PASS)]);
            Location bridge = new Location(LocationID.BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LocationID.SPIDER_FIELD, "Forest",
                "You see spider webs covering covering the trees in this forest.");
            spiderField.MonsterLivingHere = Monsters[MonsterID.GIANT_SPIDER];

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
            Locations.Add(home.ID, home);
            Locations.Add(townSquare.ID, townSquare);
            Locations.Add(guardPost.ID, guardPost);
            Locations.Add(alchemistHut.ID, alchemistHut);
            Locations.Add(alchemistsGarden.ID, alchemistsGarden);
            Locations.Add(farmhouse.ID, farmhouse);
            Locations.Add(farmersField.ID, farmersField);
            Locations.Add(bridge.ID, bridge);
            Locations.Add(spiderField.ID, spiderField);
        }

        public async static Task LoadGeneratedMonsters()
        {
            //Console.WriteLine("test");
            string url = "https://jsonplaceholder.typicode.com/photos";

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = await (wc.DownloadDataTaskAsync(url));

            string webData = System.Text.Encoding.UTF8.GetString(raw);
            JArray photos = JArray.Parse(webData);
            //Console.WriteLine("test");
            
            foreach (var item in photos)
            {
                var idToken = item.SelectToken("id");
                var titleToken = item.SelectToken("title");
                //Console.WriteLine(e);
                int id = Int32.Parse(idToken.ToString());
                _randomMonsters.Add(new Monster(MonsterID.GENERATED, titleToken.ToString(), 10, 10, 10, 10, 10));
            }

            Console.WriteLine(_randomMonsters.Count);
        }
    }
}
