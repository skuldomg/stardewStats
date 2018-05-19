using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace stardewStats
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            InputEvents.ButtonPressed += this.InputEvents_ButtonPressed;
        }

        private void InputEvents_ButtonPressed(object sender, EventArgsInput e)
        {
            if (Context.IsWorldReady) // save is loaded
            {
                this.Monitor.Log($"{Game1.player.Name} pressed {e.Button}.");

                // TODO: Make button configurable
                if(e.Button.Equals("F5"))
                {                    
                    String avgBedtime = Game1.stats.AverageBedtime.ToString();
                    String barsSmelted = Game1.stats.BarsSmelted.ToString();
                    String beveragesMade = Game1.stats.BeveragesMade.ToString();
                    String bouldersCracked = Game1.stats.BouldersCracked.ToString();
                    String caveCarrots = Game1.stats.CaveCarrotsFound.ToString();
                    String cheeseMade = Game1.stats.CheeseMade.ToString();
                    String eggsLayed = Game1.stats.ChickenEggsLayed.ToString();
                    String coalFound = Game1.stats.CoalFound.ToString();
                    String copperFound = Game1.stats.CopperFound.ToString();
                    String milk = Game1.stats.CowMilkProduced.ToString();
                    String crops = Game1.stats.CropsShipped.ToString();
                    String days = Game1.stats.DaysPlayed.ToString();
                    String diamonds = Game1.stats.DiamondsFound.ToString();
                    String dirtHoed = Game1.stats.DirtHoed.ToString();
                    String duckEggs = Game1.stats.DuckEggsLayed.ToString();
                    String fish = Game1.stats.FishCaught.ToString();
                    String geodes = Game1.stats.GeodesCracked.ToString();
                    String slimes = Game1.stats.getMonstersKilled("Slime").ToString(); // TODO: All of them
                    String gifts = Game1.stats.GiftsGiven.ToString();
                    String goatCheese = Game1.stats.GoatCheeseMade.ToString();
                    String goatMilk = Game1.stats.GoatMilkProduced.ToString();
                    String gold = Game1.stats.GoldFound.ToString();
                    String goodFriends = Game1.stats.GoodFriends.ToString();
                    String iridium = Game1.stats.IridiumFound.ToString();
                    String iron = Game1.stats.IronFound.ToString();
                    String cooked = Game1.stats.ItemsCooked.ToString();
                    String crafted = Game1.stats.ItemsCrafted.ToString();
                    String foraged = Game1.stats.ItemsForaged.ToString();
                    String shipped = Game1.stats.ItemsShipped.ToString();
                    String allMonsters = Game1.stats.MonstersKilled.ToString();
                    String mysticStones = Game1.stats.MysticStonesCrushed.ToString();
                    String notes = Game1.stats.NotesFound.ToString();
                    String otherGems = Game1.stats.OtherPreciousGemsFound.ToString();
                    String trash = Game1.stats.PiecesOfTrashRecycled.ToString();
                    String preserves = Game1.stats.PreservesMade.ToString();
                    String prismatic = Game1.stats.PrismaticShardsFound.ToString();
                    String quests = Game1.stats.QuestsCompleted.ToString();
                    String rabbitWool = Game1.stats.RabbitWoolProduced.ToString();
                    String rocks = Game1.stats.RocksCrushed.ToString();
                    String seeds = Game1.stats.SeedsSown.ToString();
                    String sheepWool = Game1.stats.SheepWoolProduced.ToString();
                    String slimesKilled = Game1.stats.SlimesKilled.ToString();
                    String specificMonsters = Game1.stats.specificMonstersKilled.ToString();
                    String starLevelCrops = Game1.stats.StarLevelCropsShipped.ToString();
                    String steps = Game1.stats.StepsTaken.ToString();
                    String sticksChopped = Game1.stats.SticksChopped.ToString();
                    String stoneGathered = Game1.stats.StoneGathered.ToString();
                    String stumpsChopped = Game1.stats.StumpsChopped.ToString();
                    String fished = Game1.stats.TimesFished.ToString();
                    String unconscious = Game1.stats.TimesUnconscious.ToString();
                    String truffles = Game1.stats.TrufflesFound.ToString();
                    String weed = Game1.stats.WeedsEliminated.ToString();                    

                    this.Monitor.Log("Average bedtime: " + avgBedtime);
                    this.Monitor.Log("Bars smelted: " + barsSmelted);
                    this.Monitor.Log("Beverages made: " + beveragesMade);
                    this.Monitor.Log("Boulders cracked: " + bouldersCracked);
                    this.Monitor.Log("Cave carrots found: " + caveCarrots);
                    this.Monitor.Log("Cheese made: " + cheeseMade);
                    this.Monitor.Log("Eggs layed: " + eggsLayed);
                    this.Monitor.Log("Coal found: " + coalFound);
                    this.Monitor.Log("Copper found: " + copperFound);
                    this.Monitor.Log("Average bedtime: " + avgBedtime);
                    this.Monitor.Log("Milk produced: " + milk);
                    this.Monitor.Log("Crops shipped: " + crops);
                    this.Monitor.Log("Days played: " + days);
                    this.Monitor.Log("Diamonds found: " + diamonds);
                    this.Monitor.Log("Dirt hoed: " + dirtHoed);
                    this.Monitor.Log("Duck eggs layed: " + duckEggs);
                    this.Monitor.Log("Fish caught: " + fish);
                    this.Monitor.Log("Geodes cracked: " + geodes);
                    this.Monitor.Log("Slimes killed: " + slimes);
                    this.Monitor.Log("Gifts given: " + gifts);
                    this.Monitor.Log("Goat cheese made: " + goatCheese);
                    this.Monitor.Log("Goat milk made: " + goatMilk);
                    this.Monitor.Log("Gold found: " + gold);
                    this.Monitor.Log("Good friends: " + goodFriends);
                    this.Monitor.Log("Iridium found: " + iridium);
                    this.Monitor.Log("Iron found: " + iron);
                    this.Monitor.Log("Items cooked: " + cooked);
                    this.Monitor.Log("Items crafted: " + crafted);
                    this.Monitor.Log("Items foraged: " + foraged);
                    this.Monitor.Log("Items shipped: " + shipped);
                    this.Monitor.Log("All monsters killed: " + allMonsters);
                    this.Monitor.Log("Mystic stones crushed: " + mysticStones);
                    this.Monitor.Log("Notes found: " + notes);
                    this.Monitor.Log("Other gems found: " + otherGems);
                    this.Monitor.Log("Trash recycled: " + trash);
                    this.Monitor.Log("Preserves made: " + preserves);
                    this.Monitor.Log("Prismatic shards found: " + prismatic);
                    this.Monitor.Log("Quests completed: " + quests);
                    this.Monitor.Log("Rabbit wool produced: " + rabbitWool);
                    this.Monitor.Log("Rocks crushed: " + rocks);
                    this.Monitor.Log("Seeds sown: " + seeds);
                    this.Monitor.Log("Sheep wool produced: " + sheepWool);
                    this.Monitor.Log("Slimes killed: " + slimesKilled);
                    this.Monitor.Log("Specific monsters killed: " + specificMonsters);
                    this.Monitor.Log("Star level crops shipped: " + starLevelCrops);
                    this.Monitor.Log("Steps taken: " + steps);
                    this.Monitor.Log("Sticks chopped: " + sticksChopped);
                    this.Monitor.Log("Stones gathered: " + stoneGathered);
                    this.Monitor.Log("Stumps chopped: " + stumpsChopped);
                    this.Monitor.Log("Times fished: " + fished);
                    this.Monitor.Log("Times unconscious: " + unconscious);
                    this.Monitor.Log("Truffles found: " + truffles);
                    this.Monitor.Log("Weed eliminated: " + weed);
                }
            }
        }
    }
}
