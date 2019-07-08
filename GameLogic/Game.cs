using System;
using System.Collections.Generic;
using GameLogic.Entities;
using GameLogic.Entities.Locations;
using GameLogic.Events;

namespace GameLogic
{
    public class Game
    {
        private readonly string Mode;
        private static string GetMode(string mode) =>
            mode switch
            {
                "DEBUGLOCAL" => "DEBUGLOCAL",
                "DEBUGSERVER" => "DEBUGSERVER",
                "TESTLOCAL" => "TESTLOCAL",
                "TESTSERVER" => "TESTSERVER",
                "RELEASELOCAL" => "RELEASELOCAL",
                "RELEASESERVER" => "RELEASESERVER",
                _ => "RELEASELOCAL",
            };

        private readonly Data.IDataReader dataReader;
        private readonly Data.IDataWriter dataWriter;

        public Game(string mode) {
            Mode = GetMode(mode);
            if (Mode.Contains("LOCAL"))
            {
                dataReader = new Data.LocalDataReader();
                dataWriter = new Data.LocalDataWriter();
            } else
            {
                dataReader = new Data.ServerDataReader();
                dataWriter = new Data.ServerDataWriter();
            }
        }

        //Все локации в игре
        private List<Location> Locations { get; set; }
        //Все персонажи в игре
        private List<Person> People { get; set; }
        //Игрок
        private IPlayer Player { get; set; }

        //События
        List<Event> Events = new List<Event>();

        private Data.GameData GetData()
        {
            var gameData = new Data.GameData();
            gameData.Locations = Locations;
            gameData.People = People;
            gameData.Player = Player;

            return gameData;
        }

        public void SetData(Data.GameData gameData)
        {
            Locations = gameData.Locations;
            People = gameData.People;
            Player = gameData.Player;
        }

        public void Save() => dataWriter.WriteData(GetData());

        public Data.GameData Load() => dataReader.ReadData();

        public void NewGame()
        {
            //Сигнал всем объектам в игре, что началась новая игра
            NewGame newGame = new NewGame("newGameEvent", "Новая игра");
            foreach (Location location in Locations)
                newGame.GoEvent += location.OnNewGame;
            foreach (Person person in People)
                newGame.GoEvent += person.OnNewGame;
            newGame.OnGoEvent();
        }

        public void Initialize()
        {
            #region Загрузка данных
            Data.GameData gameData = dataReader.ReadData();
            SetData(gameData);
            #endregion

            #region Настройка событий
            //Добавление всех событий в пулл событий
            NewGame newGame = new NewGame("newGameEvent", "Новая игра");
            Events.Add(newGame);
            StartGame startGame = new StartGame("startGameEvent", "Старт игры");
            Events.Add(startGame);
            PlayerComes playerComes = new PlayerComes("playerComesEvent", "Игрок пришел");

            //Подключаем все нужные события к локациям
            foreach (Location location in Locations)
            {
                //Первоначальная генерация и настройка
                newGame.GoEvent += location.OnNewGame;
                //Действия, проводящиеся каждый раз при входе в игру
                startGame.GoEvent += location.OnStartGame;
                //Событие вызывается переходом игрока в другую локацию
                playerComes.GoEvent += location.OnPlayerComes;
            }

            //Подключаем все нужные события к персонажам
            foreach (Person person in People)
            {
                if (person is IRefreshable)
                    playerComes.GoEvent += ((IRefreshable)person).OnStartGame;
            }


            #endregion
        }


    }
}