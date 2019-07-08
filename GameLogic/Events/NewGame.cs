namespace GameLogic.Events
{
    /// <summary>
    /// Событие вызывается при старте новой игры
    /// </summary>
    public class NewGame : Event
    {
        public NewGame(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
