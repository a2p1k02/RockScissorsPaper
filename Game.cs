namespace RockScissorsPaper
{

    /*
     * 1 - Rock
     * 2 - Scissors
     * 3 - Paper
     */

    public class Game
    {
        private uint PCscore;
        private uint PLscore;
        private Random Random;
        private ushort PlayerChoose;
        private ushort PCChoose;

        public Game()
        {
            PCscore = 0;
            PLscore = 0;
            PlayerChoose = 0;
            PCChoose = 0;
            Random = new Random();
        }

        private string CheckWinner()
        {
            string msg = "";
            switch (PlayerChoose)
            {
                case 1:
                    if (PCChoose == 2) { msg = "Ты выиграл!"; PLscore++; } 
                    else if (PCChoose == 3) { msg = "Ты проиграл!"; PCscore++; } 
                    else msg = "Ничья!";
                    break;
                case 2:
                    if (PCChoose == 3) { msg = "Ты выиграл!"; PLscore++; }
                    else if (PCChoose == 1) { msg = "Ты проиграл!"; PCscore++; }
                    else msg = "Ничья!";
                    break;
                case 3:
                    if (PCChoose == 1) { msg = "Ты выиграл!"; PLscore++; }
                    else if (PCChoose == 2) { msg = "Ты проиграл!"; PCscore++; }
                    else msg = "Ничья!";
                    break; 
                case 4:
                    msg = $"Твой счёт: {PLscore}\nСчёт ИИ: {PCscore}"; 
                    break;
            }
            return msg;
        }

        public void Run()
        {
            while (PlayerChoose != 4)
            {
                Console.Write("Введите число от 1 до 3 или 4, чтобы выйти: ");
                PlayerChoose = Convert.ToUInt16(Console.ReadLine());
                PCChoose = (ushort) Random.Next(1, 4);
                Console.WriteLine(CheckWinner());
            }
        }

    }
}
