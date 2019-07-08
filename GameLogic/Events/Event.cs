using System;
namespace GameLogic.Events
{
    public delegate void Go();

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
