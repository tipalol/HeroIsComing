using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Наследуйте, если объект выполняет какую-то логику
    /// при каждом входе в игру
    /// </summary>
    public interface IRefreshable
    {
        public void OnStartGame();
    }
}
