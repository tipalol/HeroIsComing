using System;
namespace GameLogic.Entities.Locations
{
    [Serializable]
    public class Village : Location
    {
        public override void OnNewGame()
        {
            base.OnNewGame();
            Console.WriteLine("Деревня создается");
        }
        public Village(string Id, string Name) : base(Id, Name)
        {
        }
    }
}
