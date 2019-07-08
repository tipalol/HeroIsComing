using System;
namespace GameLogic.Entities
{
    /// <summary>
    /// Базовый класс игрового персонажа
    /// </summary>
    [Serializable]
    public  abstract class Person : GameObject
    {
        /// <summary>
        /// Некая(-ие) свойственная(-ые) персонажу фраза(-ы)
        /// не используйте для реализации диалогов -
        /// для этого будет отдеальный интерфейс
        /// </summary>
        /// <returns>Своейственная персонажу фраза</returns>
        public virtual string Talk()
        {
            throw new NotImplementedException();
        }
        public virtual void OnNewGame() { }
        public Person(string Id, string Name) : base (Id, Name)
        {
        }
    }
}
