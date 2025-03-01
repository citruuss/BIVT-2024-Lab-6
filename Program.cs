using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Lab_6.Blue_1;
using static Lab_6.Blue_2;
using static Lab_6.Blue_4;
using static Lab_6.Blue_5;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check1();

            //Check2();

            //Check3();

            //Check4();

            Check5();


        }
        static void Check1()
        {
            Blue_1.Response[] responses =
            {
                new Blue_1.Response("Татьяна", "Степанова"),
                new Blue_1.Response("Никита", "Жарков"),
                new Blue_1.Response("Мирослав", "Петров"),
                new Blue_1.Response("Артем", "Тихонов"),
                new Blue_1.Response("Алевтина", "Тихонова"),
                new Blue_1.Response("Максим", "Степанов"),
                new Blue_1.Response("Марина", "Батова"),
                new Blue_1.Response("Григорий", "Сидоров"),
                new Blue_1.Response("Екатерина", "Чехова"),
                new Blue_1.Response("Оксана", "Кристиан"),
                new Blue_1.Response("Марина", "Пономарева"),
                new Blue_1.Response("Инесса", "Смирнова"),
                new Blue_1.Response("Алиса", "Распутина"),
                new Blue_1.Response("Влада", "Степанова"),
                new Blue_1.Response("Дарья", "Пономарева"),
                new Blue_1.Response("Сергей", "Тихонов"),
                new Blue_1.Response("Степан", "Иванов"),
                new Blue_1.Response("Ольга", "Зайцева"),
                new Blue_1.Response("Михаил", "Иванов"),
                new Blue_1.Response("Григорий", "Ушаков"),
                new Blue_1.Response("Инесса", "Лисицына"),
                new Blue_1.Response("Юрий", "Иванов"),
                new Blue_1.Response("Григорий", "Козлов"),
                new Blue_1.Response("Игорь", "Петров"),
                new Blue_1.Response("Ольга", "Тихонова"),
                new Blue_1.Response("Юрий", "Иванов"),
                new Blue_1.Response("Татьяна", "Чехова"),
                new Blue_1.Response("Михаил", "Свиридов"),
                new Blue_1.Response("Дарья", "Павлова"),
                new Blue_1.Response("Степан", "Павлов")
            };

            foreach (var candidate in responses)
            {
                candidate.CountVotes(responses);
                candidate.Print();
            }
            
        }

        static void Check2()
        {
            Blue_2.Participant[] participants =
            {
                new Blue_2.Participant("Александр", "Петров"),
                new Blue_2.Participant("Артем", "Луговой"),
                new Blue_2.Participant("Мария", "Свиридова"),
                new Blue_2.Participant("Игорь", "Смирнов"),
                new Blue_2.Participant("Николай", "Зайцев"),
                new Blue_2.Participant("Инесса", "Кристиан"),
                new Blue_2.Participant("Марина", "Свиридова"),
                new Blue_2.Participant("Александр", "Петров"),
                new Blue_2.Participant("Сергей", "Батов"),
                new Blue_2.Participant("Александра", "Сидорова")

            };

            int[][] jumps =
            {
                new[] { 11, 0, 8, 7, 12 },
                new[] { 2, 3, 10, 13, 16 },
                new[] { 18, 17, 20, 7, 11 },
                new[] { 3, 7, 12, 19, 2 },
                new[] { 17, 13, 2, 19, 2 },
                new[] { 10, 0, 0, 6, 5 },
                new[] { 15, 7, 14, 19, 15 },
                new[] { 5, 13, 16, 18, 16 },
                new[] { 20, 5, 4, 3, 0 },
                new[] { 18, 4, 12, 18, 7 },
                new[] { 5, 17, 20, 2, 11 },
                new[] { 10, 18, 9, 7, 12 },
                new[] { 18, 1, 10, 5, 20 },
                new[] { 19, 1, 5, 1, 18 },
                new[] { 2, 17, 5, 11, 3 },
                new[] { 7, 18, 3, 5, 3 },
                new[] { 2, 0, 5, 18, 20 },
                new[] { 3, 12, 4, 2, 10 },
                new[] { 12, 2, 17, 5, 7 },
                new[] { 5, 15, 15, 5, 11 }
             };

            for (int i = 0; i < participants.Length; i++) 
            {
                participants[i].Jump(jumps[i * 2]);
                participants[i].Jump(jumps[i * 2 + 1]);
            }

            Participant.Sort(participants);

            foreach (var participant in participants)
            {
                participant.Print();
            }

        }

        static void Check3()
        {
            Blue_3.Participant[] participants =
            {
                new Blue_3.Participant("Инна", "Пономарева"),
                new Blue_3.Participant("Юрий", "Ушаков"),
                new Blue_3.Participant("Дмитрий", "Иванов"),
                new Blue_3.Participant("Иван", "Кристиан"),
                new Blue_3.Participant("Татьяна", "Ушакова"),
                new Blue_3.Participant("Александра", "Козлова"),
                new Blue_3.Participant("Дарья", "Павлова"),
                new Blue_3.Participant("Мирослав", "Лисицын"),
                new Blue_3.Participant("Юлия", "Чехова"),
                new Blue_3.Participant("Дарья", "Лисицына")
            };

            int[][] PenaltyTimes = new int[][]
            {
                new int[] { 2, 2, 0, 2, 0, 0, 0, 5, 2, 5 },
                new int[] { 0, 10, 10, 0, 5, 5, 2, 10, 10, 10 },
                new int[] { 2, 5, 5, 2, 0, 10, 5, 2, 0, 0 },
                new int[] { 2, 10, 2, 5, 2, 2, 10, 10, 5, 0 },
                new int[] { 5, 2, 0, 10, 10, 2, 10, 5, 0, 2 },
                new int[] { 5, 2, 5, 0, 0, 10, 5, 5, 2, 10 },
                new int[] { 0, 2, 0, 2, 5, 5, 5, 5, 2, 5 },
                new int[] { 0, 2, 2, 10, 10, 2, 5, 2, 5, 0 },
                new int[] { 0, 10, 5, 10, 5, 5, 5, 2, 5, 2 },
                new int[] { 5, 2, 5, 0, 10, 10, 0, 0, 0, 2 }
            };

            //перебираем участников и их штрафные минуты, с помощью ПлейМэч записываем их в массив Нью
            for (int i = 0; i < participants.Length; i++)
            {
                for (int j = 0; j < PenaltyTimes[i].Length; j++)
                {
                    participants[i].PlayMatch(PenaltyTimes[i][j]);
                }
            }

            Blue_3.Participant.Sort(participants);

            foreach (var participant in participants)
            {
                    participant.Print();
                    
            }


        }

        static void Check4()
        {
            Blue_4.Group group1 = new Group("Группа 1");
            Blue_4.Group group2 = new Group("Группа 2");


            Blue_4.Team team1 = new Blue_4.Team("Василек");
            team1.PlayMatch(1);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(1);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(0);
            team1.PlayMatch(1);
            team1.PlayMatch(3);
            team1.PlayMatch(3);
            team1.PlayMatch(0);
            team1.PlayMatch(1);
            team1.PlayMatch(0);
            team1.PlayMatch(0);
            team1.PlayMatch(3);
            team1.PlayMatch(0);
            team1.PlayMatch(3);
            
            group1.Add(team1);

            Blue_4.Team team2 = new Blue_4.Team("Нефтехим");
            team2.PlayMatch(3);
            team2.PlayMatch(1);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(3);
            team2.PlayMatch(1);
            team2.PlayMatch(3);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(1);
            team2.PlayMatch(0);
            team2.PlayMatch(1);
            team2.PlayMatch(3);
            team2.PlayMatch(3);
            team2.PlayMatch(3);
            team2.PlayMatch(0);
            
            group1.Add(team2);

            Blue_4.Team team3 = new Blue_4.Team("Урал");
            team3.PlayMatch(0);
            team3.PlayMatch(1);
            team3.PlayMatch(3);
            team3.PlayMatch(1);
            team3.PlayMatch(1);
            team3.PlayMatch(0);
            team3.PlayMatch(0);
            team3.PlayMatch(0);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(1);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(0);
            team3.PlayMatch(0);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(3);
            team3.PlayMatch(0);
            
            group2.Add(team3);

            Blue_4.Team team4 = new Blue_4.Team("Нефтехим");
            team4.PlayMatch(1);
            team4.PlayMatch(3);
            team4.PlayMatch(3);
            team4.PlayMatch(1);
            team4.PlayMatch(1);
            team4.PlayMatch(3);
            team4.PlayMatch(3);
            team4.PlayMatch(1);
            team4.PlayMatch(3);
            team4.PlayMatch(3);
            team4.PlayMatch(1);
            team4.PlayMatch(1);
            team4.PlayMatch(0);
            team4.PlayMatch(3);
            team4.PlayMatch(0);
            team4.PlayMatch(3);
            team4.PlayMatch(1);
            team4.PlayMatch(3);
            team4.PlayMatch(1);
            team4.PlayMatch(1);
            
            group2.Add(team4);

            group1.Sort();
            group2.Sort();

            Group finalGroup = Group.Merge(group1, group2, 6);

            finalGroup.Print();
        }

        static void Check5()
        {

            Blue_5.Sportsman[] Sportsmen = new Blue_5.Sportsman[]
                  {
                 new Blue_5.Sportsman("Мирослав", "Распутин"),
                 new Blue_5.Sportsman("Игорь", "Павлов"),
                 new Blue_5.Sportsman("Полина", "Свиридова"),
                 new Blue_5.Sportsman("Савелий", "Луговой"),
                 new Blue_5.Sportsman("Николай", "Козлов"),
                 new Blue_5.Sportsman("Юлия", "Сидорова"),
                 new Blue_5.Sportsman("Полина", "Луговая"),
                 new Blue_5.Sportsman("Светлана", "Иванова"),
                 new Blue_5.Sportsman("Александр", "Петров"),
                 new Blue_5.Sportsman("Игорь", "Распутин"),
                 new Blue_5.Sportsman("Савелий", "Свиридов"),
                 new Blue_5.Sportsman("Мария", "Свиридова"),
                 new Blue_5.Sportsman("Дмитрий", "Свиридов"),
                 new Blue_5.Sportsman("Светлана", "Козлова"),
                 new Blue_5.Sportsman("Екатерина", "Луговая"),
                 new Blue_5.Sportsman("Степан", "Жарков"),
                 new Blue_5.Sportsman("Степан", "Распутин"),
                 new Blue_5.Sportsman("Дарья", "Свиридова") };
            int[] places = { 12, 2, 17, 13, 5, 6, 7, 8, 9, 10, 11, 1, 4, 14, 15, 16, 3, 18 };
            for (int i = 0; i < Sportsmen.Length; i++)
            {
                Sportsmen[i].SetPlace(places[i]);
            }

            Blue_5.Team[] teams = new Blue_5.Team[]
            {
                     new Blue_5.Team("Локомотив"),
                     new Blue_5.Team("Динамо"),
                     new Blue_5.Team("Спартак") };

            teams[0].Add(new Blue_5.Sportsman[] { Sportsmen[0], Sportsmen[1], Sportsmen[2], Sportsmen[3], Sportsmen[4], Sportsmen[5] });
            teams[1].Add(new Blue_5.Sportsman[] { Sportsmen[6], Sportsmen[7], Sportsmen[8], Sportsmen[9], Sportsmen[10], Sportsmen[11] });
            teams[2].Add(new Blue_5.Sportsman[] { Sportsmen[12], Sportsmen[13], Sportsmen[14], Sportsmen[15], Sportsmen[16], Sportsmen[17] });

            Blue_5.Team.Sort(teams);

            foreach (var team in teams)
            {
                team.Print();
            }
        }

    }
}

    

