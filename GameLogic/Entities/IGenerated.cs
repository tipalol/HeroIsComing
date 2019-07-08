using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Наследуйте, если объект нуждается в дополнительной настройке
    /// при начале новой игры
    /// </summary>
    public interface IGenerated
    {
        public void OnNewGame();

    }
}
