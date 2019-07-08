using System;
namespace GameLogic.Entities
{
    [Serializable]
    public class Player : Person, IPlayer
    {
        /// <summary>
        /// Перемещение в другую локацию, либо же переход в некое место
        /// </summary>
        public void Walk()
        {

        }
        /// <summary>
        /// Сон)
        /// </summary>
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
