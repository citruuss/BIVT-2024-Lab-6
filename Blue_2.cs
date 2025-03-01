using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_2
    {
        //структура
        public struct Participant
        {
            //приватные поля
            private string _name;
            private string _surname;
            private int[,] _marks;

            //свойства только для чтения
            public string Name => _name;
            public string Surname => _surname;
            public int[,] Marks
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return null;
                    int[,] New = new int[2, 5];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            New[i, j] = _marks[i, j];
                        }
                    }
                    return New;
                }
            }
            public int TotalScore
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return 0;
                    int score = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            score += _marks[i, j];
                        }
                    }
                    return score;
                }
            }

            //конструктор
            public Participant(string Name, string Surname)
            {
                _name = Name;
                _surname = Surname;
                _marks = new int[2, 5];
            }

            //метод
            public void Jump(int[] result)
            {
                if (result.Length != 5 || _marks == null) return;
                for (int i=0; i < 2; i++)
                {
                    if (_marks[i, 0] == 0)
                    {
                        for (int j = 0; j < 5; j++)
                        {

                            _marks[i, j] = result[j];

                        }
                        return;
                    }
                    
                }
                
                
            }

            public static void Sort(Participant[] array)
            {
                if (array == null || array.Length == 0) return;
                for (int i=0; i< array.Length; i++)
                {
                    for (int j=0; j< array.Length-1-i; j++)
                    {
                        if (array[j].TotalScore < array[j + 1].TotalScore) 
                        {
                            Participant a = array[j];
                            array[j] = array[j+1];
                            array[j + 1] = a;
                        }
                    }
                }
            }

            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {TotalScore}" );
                
            }


        }
    }
}
