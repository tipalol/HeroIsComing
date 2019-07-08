using System;
namespace GameLogic.Entities
{
    public interface ICanFight
    {
        int MaxHealth { get; set; }
        int Health { get; set; }
        int Attack(ICanFight sender);
    }
}
