using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_5;

namespace Lab_6
{
    public class Blue_5
    {
        public struct Sportsman
        {
            //приватные поля
            private string _name;
            private string _surname;
            private int _place;
            private bool _placeSet;

            //свойства для чтения
            public string Name => _name;
            public string Surname => _surname;
            public int Place => _place;

            //конструктор
            public Sportsman(string Name, string Surname)
            {
                _name = Name;
                _surname = Surname;
                _place = 0;
                _placeSet = false;
            }

            public void SetPlace(int place)
            {
                if (!_placeSet)
                {
                    _place = place;
                    _placeSet = true;
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_place}");
            }

        }

        public struct Team
        {
            private string _name;
            private Sportsman[] _sportsmen;
            private int _index;

            public string Name => _name;
            public Sportsman[] Sportsmen => _sportsmen;

            public int SummaryScore
            {
                get
                {
                    if (_sportsmen == null) return 0;
                    int score = 0;
                    for (int i = 0; i <6; i++)
                    {
                        if (_sportsmen[i].Place <= 5 && _sportsmen[i].Place != 0)
                        {
                            score += 6 - _sportsmen[i].Place;
                        }
                    }
                    return score;
                }
            }

            public int TopPlace
            {
                get
                {
                    if (_sportsmen == null) return 0;
                    int Min = 18;
                    for (int i = 0; i <6; i++)
                    {
                        if (Min > _sportsmen[i].Place && _sportsmen[i].Place != 0)
                        {
                            Min = _sportsmen[i].Place;
                        }
                    }
                    return Min;
                }
            }

            public Team(string Name)
            {
                _name = Name;
                _sportsmen = new Sportsman[6];
                _index = 0;
            }

            public void Add(Sportsman sportsman)
            {
                if (_sportsmen == null || _index == 6) return;
                if (_index < _sportsmen.Length)
                {
                    _sportsmen[_index++] = sportsman;
                }
            }

            public void Add(Sportsman[] sportsmen)
            {
                if (_sportsmen == null) return;
                foreach (var sportsman in sportsmen)
                {
                    Add(sportsman);
                }
            }

            public static void Sort(Team[] teams)
            {
                if (teams == null) return;
                for (int i = 0; i < teams.Length; i++)
                {
                    for (int j = 0; j < teams.Length - 1 - i; j++)
                    {
                        if (teams[j].SummaryScore < teams[j + 1].SummaryScore)
                        {
                            var a = teams[j];
                            teams[j] = teams[j + 1];
                            teams[j + 1] = a;
                        }
                        else if (teams[j].SummaryScore == teams[j + 1].SummaryScore && teams[j].TopPlace > teams[j + 1].TopPlace)
                        {
                            var a = teams[j];
                            teams[j] = teams[j + 1];
                            teams[j + 1] = a;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($" {Name} {SummaryScore} {TopPlace} ");
            }



        }
    }
}
