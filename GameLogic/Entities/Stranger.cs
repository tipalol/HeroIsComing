using System;
namespace GameLogic.Entities
{
    [Serializable]
    public class Stranger : Person
    {
        public override string Talk()
        {
            return $"Привет, меня зовут {Name}. Вот, что я могу тебе предложить..";
        }
        public Stranger(string Id, string Name) : base (Id, Name)
        {
        }
    }
}
