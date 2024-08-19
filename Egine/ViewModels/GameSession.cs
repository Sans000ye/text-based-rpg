using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Players CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Players();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.money = 1000000;
            CurrentPlayer.HP = 10;
            CurrentPlayer.EXP = 0;
            CurrentPlayer.Level= 10;
        }
    }
}
