namespace GameLogic.Events
{
    public class NewGame : Event
    {
        public NewGame(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
