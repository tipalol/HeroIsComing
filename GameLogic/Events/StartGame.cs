namespace GameLogic.Events
{
    /// <summary>
    /// Событие вызывается при каждом входе в игру
    /// </summary>
    public class StartGame : Event
    {
        public StartGame(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
