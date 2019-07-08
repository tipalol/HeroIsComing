using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Пример реализации персонажа
    /// </summary>
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
