using System;

namespace MatchesPlay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matchesCount = 15;
            bool resultA = false;
            bool resultB = false;

            var matchesRow1 = new MatchesRow()
            {
                RowNo = 1,
                RowNumber = 3
            };
            var matchesRow2 = new MatchesRow()
            {
                RowNo = 2,
                RowNumber = 5
            };
            var matchesRow3 = new MatchesRow()
            {
                RowNo = 3,
                RowNumber = 7
            };

            AbstractPlayer playerA = new PalyGameByPlayerA();
            playerA.PickUpCount = 0;
            AbstractPlayer playerB = new PalyGameByPlayerA();
            playerB.PickUpCount = 0;

            MediatorPater mediatorPater = new MediatorPater(playerA, playerB);

            while (matchesCount > 0)
            {
                int randomA = 0;
                int randomB = 0;
                var row = new int[3] { 1, 2, 3 };

                randomA = row[new Random().Next(0, 2)];
                randomB = row[new Random().Next(0, 2)];
                while (randomB == randomA)
                {
                    randomA = row[new Random().Next(0, 2)];
                    randomB = row[new Random().Next(0, 2)];
                }

                switch (randomA)
                {
                    case 1:
                        resultA=playerA.ChangeCount(1, mediatorPater, matchesRow1);
                        matchesCount--;
                        break;
                    case 2:
                        resultA=playerA.ChangeCount(1, mediatorPater, matchesRow2);
                        matchesCount--;
                        break;
                    case 3:
                        resultA=playerA.ChangeCount(1, mediatorPater, matchesRow3);
                        matchesCount--;
                        break;
                    default:
                        throw new Exception("程序运行参数错误，请检查后重试!");
                }

                switch (randomB)
                {
                    case 1:
                        resultB=playerB.ChangeCount(1, mediatorPater, matchesRow1);
                        matchesCount--; 
                        break;
                    case 2:
                        resultB=playerB.ChangeCount(1, mediatorPater, matchesRow2);
                        matchesCount--;
                        break;
                    case 3:
                        resultB=playerB.ChangeCount(1, mediatorPater, matchesRow3);
                        matchesCount--;
                        break;
                    default:
                        throw new Exception("程序运行参数错误，请检查后重试!");
                }
            }

            Console.WriteLine("游戏开始..........................................");

            if (resultA)
            {
                Console.WriteLine($"玩家A取得胜利：{playerA.PickUpCount}");
            }
            else if (resultB)
            {
                Console.WriteLine($"玩家B取得胜利：{playerB.PickUpCount}");
            }
            else
            {
                Console.WriteLine("程序运行错误，请检查！");
            }

            Console.WriteLine("游戏结束..........................................");

            Console.ReadKey();
        }
    }
}
