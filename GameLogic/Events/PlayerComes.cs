namespace GameLogic.Events
{
    /// <summary>
    /// Событие вызывается при переходе игрока в другую локацию
    /// </summary>
    public class PlayerComes : Event
    {
        public PlayerComes(string Id, string Name) : base (Id, Name)
        {
        }
    }
}
