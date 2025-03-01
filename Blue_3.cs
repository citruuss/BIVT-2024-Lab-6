using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_3
    {
        //структура
        public struct Participant
        {
            //приватные поля
            private string _name;
            private string _surname;
            private int[] _minutes;
            private int _matchesPlayed; //добавим счетчик матчей

            //свойства только для чтения
            public string Name => _name;
            public string Surname => _surname;
            public int[] PenaltyTimes
            { 
                get 
                {
                    if (_minutes == null || _minutes.Length == 0) return null;
                    int[] New = new int[_minutes.Length];
                    for (int i=0; i < New.Length; i++)
                    {
                        New[i] = _minutes[i];
                    }
                    return New;
                } 
                
            }

            public int TotalTime 
            { 
                get
                {
                    if (_minutes == null || _minutes.Length == 0) return 0;
                    int time = 0;
                    for (int i=0; i < _minutes.Length; i++)
                    {
                        time += _minutes[i];
                    }
                    return time;
                } 
            }
            //проверка на то выбыл человек из списка или нет

            public bool IsExpelled
            {
                get
                {
                    if (_minutes == null || _minutes.Length == 0) return false;
                    foreach (int time in _minutes)
                    {
                        if (time == 10) return false;
                    }
                    return true;
                }
            }

            //конструктор
            public Participant(string Name, string Surname)
            {
                _name = Name;
                _surname = Surname;
                _minutes = new int[10];
                _matchesPlayed = 0;
            }


            //метод
            public void PlayMatch(int time)
            {
                if (_minutes == null || _minutes.Length == 0) return;
                if (_matchesPlayed < 10) // Проверяем, что массив не переполнен
                {
                    _minutes[_matchesPlayed] = time;
                    _matchesPlayed++;
                }
            }
            //сортировка по возрастанию времени
            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j].TotalTime > array[j + 1].TotalTime)
                        {
                            Participant a = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = a;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {TotalTime} {IsExpelled}");
            }

        }
    }
}
