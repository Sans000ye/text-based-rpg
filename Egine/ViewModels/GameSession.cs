using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
