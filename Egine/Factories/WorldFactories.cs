using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class WorldFactories
    {
        internal World CreateWorld() 
        { 
            World newWorld = new World();
            newWorld.AddPlaces( 0, -1, "Home"               ,"Your home, the safest erea"                                               ,"/Engine;component/Images/Places/home.png");
            newWorld.AddPlaces(-2, -1, "Farmer's Field"     ,"There are rows of corn growing here, with giant rats hiding between them.","/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddPlaces(-1, -1, "Farmer's House"     ,"This is the house of your neighbor, Farmer Ted."                          ,"/Engine;component/Images/Locations/Farmhouse.png");
            newWorld.AddPlaces(-1,  0, "Trading Shop"       ,"The shop of Susan, the trader."                                           ,"/Engine;component/Images/Locations/Trader.png");
            newWorld.AddPlaces( 0,  0, "Town square"        ,"You see a fountain here."                                                 ,"/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddPlaces( 1,  0, "Town Gate"          ,"There is a gate here, protecting the town from giant spiders."            ,"/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddPlaces( 2,  0, "Spider Forest"      ,"The trees in this forest are covered with spider webs."                   ,"/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddPlaces( 0,  1, "Herbalist's hut"    ,"You see a small hut, with plants drying from the roof."                   ,"/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.AddPlaces( 0,  2, "Herbalist's garden" ,"There are many plants here, with snakes hiding behind them."              ,"/Engine;component/Images/Locations/HerbalistsGarden.png");
            return newWorld;

        }
    }
}
