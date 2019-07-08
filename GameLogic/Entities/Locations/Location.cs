using System;
using System.Collections.Generic;

namespace GameLogic.Entities.Locations
{
    /// <summary>
    /// Реализует игровую локацию, необходимо наследовать от этого класса
    /// все будущие локации
    /// </summary>
    [Serializable]
    public class Location : GameObject, IGenerated, IRefreshable, ICanBeVisited
    {
        /// <summary>
        /// Список объектов, находящихся в данной локации
        /// </summary>
        public List<GameObject> Objects { get; set; }
        /// <summary>
        /// Вызывается при начале новой игры
        /// </summary>
        public virtual void OnNewGame()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Вызывается при каждом входе в игру
        /// </summary>
        public virtual void OnStartGame()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Вызывается при переходе игрока в другую локацию
        /// </summary>
        public virtual void OnPlayerComes()
        {
            throw new NotImplementedException();
        }
        public Location(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
