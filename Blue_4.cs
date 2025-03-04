using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_4;

namespace Lab_6
{
    public class Blue_4
    {

        public struct Team
        {
            //приватные поля
            private string _name;
            private int[] _scores;

            //свойства для чтения
            public string Name => _name;
            public int[] Scores
            {
                get
                {
                    if (_scores == null || _scores.Length == 0) return null;
                    int[] New = new int[_scores.Length];
                    for (int i = 0; i < New.Length; i++)
                    {
                        New[i] = _scores[i];
                    }
                    return New;
                }
            }
            public int TotalScore
            {
                get
                {
                    int score = 0;
                    if (_scores == null || _scores.Length == 0) return 0;
                    for (int i = 0; i < _scores.Length; i++)
                    {
                        score += _scores[i];
                    }
                    return score;
                }
            }

            //конструктор
            public Team(string Name)
            {
                _name = Name;
                _scores = new int[0];
            }

            public void PlayMatch(int result)
            {
                if (_scores == null) return;
                var New = new int[_scores.Length + 1];
                for (int i = 0; i < _scores.Length; i++)
                {
                    New[i] = _scores[i];
                }
                New[New.Length - 1] = result;
                _scores = New;
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {TotalScore}");
            }
        }
        public struct Group
        {
            //приватные поля
            private string _name;
            private Team[] _teams;

            //для чтения
            public string Name => _name;

            public Team[] Teams
            {
                get
                {
                    if (_teams == null || _teams.Length == 0) return null;
                    Team[] New = new Team[_teams.Length];
                    for (int i = 0; i < _teams.Length; i++)
                    {
                        New[i] = _teams[i];
                    }
                    return New;
                }
            }

            // конструктор
            public Group(string Name)
            {
                _name = Name;
                _teams = new Team[12];
            }

            public void Add(Team team)
            {
                if (_teams == null) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    if (_teams[i].Name == null)
                    {
                        _teams[i] = team;
                        break;
                    }
                }
            }

            public void Add(Team[] teams)
            {
                if (_teams == null) return;
                foreach (var team in teams)
                {
                    Add(team);
                }
            }

            public void Sort()
            {
                if (_teams == null || _teams.Length == 0) return;
                for (int i = 0; i < _teams.Length; i++)
                {
                    for (int j = 0; j < _teams.Length - i - 1; j++)
                    {
                        if (_teams[j].TotalScore < _teams[j + 1].TotalScore)
                        {
                            var a = _teams[j];
                            _teams[j] = _teams[j + 1];
                            _teams[j + 1] = a;
                        }
                    }
                }
            }

            public static Group Merge(Group group1, Group group2, int size)
            {
                Group New = new Group("Финалисты");
                int i = 0, j = 0;
                while (i < size / 2 && j < size / 2)
                {
                    if (group1.Teams[i].TotalScore >= group2.Teams[j].TotalScore)
                    {
                        New.Add(group1.Teams[i++]);
                    }
                    else
                    {
                        New.Add(group2.Teams[j++]);
                    }
                }
                while (i < size / 2)
                {
                    New.Add(group1.Teams[i++]);
                }

                while (j < size / 2)
                {
                    New.Add(group2.Teams[j++]);
                }
                return New;

            }

            public void Print()
            {
                Console.Write($"{_name} ");
                for (int i = 0; i < _teams.Length; i++)
                {
                    _teams[i].Print();
                }
                Console.WriteLine("");
            }

        }
    }
}
