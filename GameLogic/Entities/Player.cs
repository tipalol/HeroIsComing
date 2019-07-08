using System;
namespace GameLogic.Entities
{
    [Serializable]
    public class Player : Person, IPlayer
    {
        public void Walk()
        {

        }
        public void Sleep()
        {

        }
        public override string Talk()
        {
            return "Something";
        }
        public Player(string Id, string Name) : base (Id, Name)
        {
        }
    }
}
