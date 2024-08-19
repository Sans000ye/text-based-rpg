using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        Players CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Players();
            CurrentPlayer.Name = "Scott";
            CurrentPlayer.money = 1000000;
        }
    }
}
