using System;
namespace GameLogic.Events
{
    /// <summary>
    /// Стандартный делегат для события
    /// </summary>
    public delegate void Go();

    /// <summary>
    /// Базовый класс для событий
    /// </summary>
    public class Event : Entities.GameObject
    {
        public event Go GoEvent;
        public void OnGoEvent()
        {
            GoEvent?.Invoke();
        }
        public Event(string Id, string Name) : base (Id, Name)
        {
            
        }
    }
}
