using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Наследуйте, если персонаж (или здание, почему нет ;D) может сражаться с игроком
    /// </summary>
    public interface ICanFight
    {
        int MaxHealth { get; set; }
        int Health { get; set; }
        int Attack(ICanFight sender);
    }
}
