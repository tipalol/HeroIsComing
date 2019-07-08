using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace GameLogic.Data
{
    public class LocalDataWriter : IDataWriter
    {
        public void WriteData(GameData gameData)
        {
            var binnaryFormatter = new BinaryFormatter();
            using var file = new FileStream(GameData.DATA_FILE_PATH, FileMode.OpenOrCreate);
            binnaryFormatter.Serialize(file, gameData);
        }
    }
}
