using System;
namespace GameLogic.Entities
{
    [Serializable]
    public abstract class GameObject
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        public GameObject(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
