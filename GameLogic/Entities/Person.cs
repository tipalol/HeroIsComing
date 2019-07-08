using System;
namespace GameLogic.Entities
{
    [Serializable]
    public  abstract class Person : GameObject
    {
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
