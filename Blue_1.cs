using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Blue_1
    {
        public struct Response
        {
            //приватные поля
            private string _name;
            private string _surname;
            private int _votes;

            //свойства для чтения
            public string Name => _name;
            public string Surname => _surname;
            public int Votes => _votes;

            //конструктор
            public Response (string Name, string Surname)
            {
                _name = Name;
                _surname = Surname;
                _votes = 0;
            }

            //метод
            public int CountVotes(Response[] responses)
            {
                if (responses == null || responses.Length == 0) return 0;

                foreach (var response in responses)
                {
                    if (response.Name == _name && response.Surname == _surname)
                    {
                        _votes++;
                    }
                }
                return _votes;
            }

            //вывод
            public void Print()
            {
                Console.WriteLine($"{_name} {_surname} {_votes}");
            }
        }
    }
}
