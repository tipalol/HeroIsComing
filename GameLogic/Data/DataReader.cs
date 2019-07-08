using System;
using GameLogic.Entities;
using GameLogic.Events;
namespace GameLogic.Data
{
    public interface IDataReader
    {
        public GameData ReadData();
    }
}
