using System;
using System.Collections.Generic;
using GameLogic.Entities;
using GameLogic.Entities.Locations;
using GameLogic.Events;

namespace GameLogic.Data
{
    [Serializable]
    public struct GameData
    {
        public List<Location> Locations { get; set; }
        public List<Person> People { get; set; }
        public IPlayer Player { get; set; }
        [NonSerialized]
        public const string DATA_FILE_PATH = "Game.bin";
        public void Add(Location location) => Locations.Add(location);
        public void Add(Person person) => People.Add(person);
        public void SetPlayer(Player player) => Player = player;
    }
}
