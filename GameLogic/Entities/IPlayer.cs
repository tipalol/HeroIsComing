using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Базовый интерфейс, реализующий некоторые действия игрока
    /// </summary>
    public interface IPlayer
    {
        void Walk();
        void Sleep();

    }
}
