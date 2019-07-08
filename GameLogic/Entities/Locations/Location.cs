using System;
using System.Collections.Generic;

namespace GameLogic.Entities.Locations
{
    [Serializable]
    public class Location : GameObject, IGenerated, IRefreshable, ICanBeVisited
    {
        public List<GameObject> Objects { get; set; }
        public virtual void Generate()
        {

        }
        public virtual void OnNewGame()
        {

        }
        public virtual void OnStartGame()
        {

        }
        public virtual void OnPlayerComes()
        {

        }
        public Location(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
