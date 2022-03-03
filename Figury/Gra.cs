using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

// Klasa gry, przechowująca takie informacje jak poziom, czas rozgrywki, czas dla każdego poziomu, maksymalne czasy na przejście poziomów, błędy gracza, itp.

namespace Figury
{
    internal class Gra
    {
        public int Level { get; private set; }          //zmienna poziomu rozgrywki
        public int MaxLevel { get; private set; }       //zmienna z maksymalnym poziomem gry
        public Stopwatch GameStopwatch { get; private set; }    //stoper dla całej gry
        public Stopwatch LevelStopwatch { get; private set; }   //stoper dla jednego poziomu
        public List<TimeSpan> LevelTimeSpans { get; private set; }  //Lista czasów pomierzonych dla każdego poziomu
        public List<TimeSpan> MaxTimesForLevel { get; private set; }    //maksymalne dopuszczalne czasy, dla każdego poziomu, które pozwalają na przejście na wyższy poziom
        public int NumberOfMistakes { get; private set; }   //liczba błędnie przypisanych liczb przez gracza

        public Gra()
        {
            Level = 1;
            MaxLevel = 10;
            NumberOfMistakes = 0;
            LevelTimeSpans = new List<TimeSpan>();
            MaxTimesForLevel = new List<TimeSpan>() {new TimeSpan(0, 0, 30), new TimeSpan(0, 0, 30), new TimeSpan(0, 1, 0), new TimeSpan(0, 0, 40), 
            new TimeSpan(0, 0, 40), new TimeSpan(0, 0, 30), new TimeSpan(0, 0, 30), new TimeSpan(0, 1, 0), new TimeSpan(0, 2, 0), new TimeSpan(0, 3, 0)};
            GameStopwatch = new Stopwatch();
            LevelStopwatch = new Stopwatch();
        }
        public void StartGame()
        {
            Level = 1;
            NumberOfMistakes = 0;
            LevelTimeSpans.Clear();
            GameStopwatch.Restart();
            LevelStopwatch.Restart();
        }

        public void Pause()
        {
            LevelStopwatch.Stop();
            GameStopwatch.Stop();
        }

        public void Resume()
        {
            LevelStopwatch.Start();
            GameStopwatch.Start();
        }
        public void LevelUp()
        {
            Pause();
            LevelTimeSpans.Add(LevelStopwatch.Elapsed);
            Level++;
            LevelStopwatch.Restart();
            GameStopwatch.Start();
        }

        public void RestartLevel()
        {
            LevelStopwatch.Restart();
            GameStopwatch.Start();
        }

        public void EndGame()
        {
            Pause();
            LevelTimeSpans.Add(LevelStopwatch.Elapsed);
        }

        public void AddMistake(int liczba_bledow) //funkcja, która dodaje określoną liczbę błędów do zmiennej NumberOfMistakes
        {
            NumberOfMistakes += liczba_bledow;
        }
    }
}
