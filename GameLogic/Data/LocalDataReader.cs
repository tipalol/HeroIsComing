using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace GameLogic.Data
{
    public class LocalDataReader : IDataReader
    {
        public GameData ReadData()
        {
            var binaryFormatter = new BinaryFormatter();
            using var file = new FileStream(GameData.DATA_FILE_PATH, FileMode.OpenOrCreate);
            GameData gameData = (GameData) binaryFormatter.Deserialize(file);
            return gameData;
        }
    }
}
