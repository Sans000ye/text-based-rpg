using Engine.Models;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Players CurrentPlayer    { get; set; }
        public Places CurrentPlaces     {  get; set; }
        public World CurrentWorld       {  get; set; }

        public GameSession()
        {
            CurrentPlayer = new Players
            {
                Name = "Scott",
                CharacterClass = "Mage",
                Money = 1000000,
                HP = 10,
                EXP = 0,
                Level = 10,

            };
            
            WorldFactories factory = new WorldFactories();
            CurrentWorld = factory.CreateWorld();

            CurrentPlaces = CurrentWorld.PlacesAt(0, -1);
        }
    }
}
