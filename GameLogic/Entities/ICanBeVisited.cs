using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Наследуйте, если локация может быть посещена игроком
    /// </summary>
    public interface ICanBeVisited
    {
        void OnPlayerComes();
    }
}
