using System;
using System.Collections.Generic;
using GameLogic;
using GameLogic.Entities;
using GameLogic.Entities.Locations;
using GameLogic.Events;

namespace TestGame
{
    class Program
    {
        public static void TestStart()
        {
            Game game = new Game("DEBUGLOCAL");

            Village village = new Village("villageLocations", "Деревня");

            Stranger stranger = new Stranger("testStranger", "Странник");

            Player player = new Player("player", "Игрок");

            GameLogic.Data.GameData gameData = new GameLogic.Data.GameData() { Locations = new List<Location>(), People = new List<Person>() };
            gameData.Add(village);
            gameData.Add(stranger);
            gameData.SetPlayer(player);

            game.SetData(gameData);

            game.Save();
        }
        static void Main()
        {
            Game game = new Game("DEBUGLOCAL");
            game.Initialize();

        }
    }
}
