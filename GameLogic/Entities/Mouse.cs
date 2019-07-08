using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Пример реализации персонажа в игре
    /// </summary>
    public class Mouse : Person, ICanFight, IRefreshable
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Attack(ICanFight sender) => throw new NotImplementedException();
        public void OnStartGame() => Health = MaxHealth;
        public Mouse(string Id, string Name, int maxHealth) : base(Id, Name)
        {
            MaxHealth = maxHealth;
        }
    }
}
