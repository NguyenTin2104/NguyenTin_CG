using System;
namespace P1
{
    class Program
    {
        static void Write(int row, int col, string content)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(content);
        }
        static void WriteScore(int row, int col, int content)
        {
            Console.SetCursorPosition(col, row);
            Console.Write("Score: " + content);
        }
        static void DrawBorder(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Write(i, j, "═");
                    }
                }
                else
                {
                    Write(i, 0, "║");
                    Write(i, width - 1, "║");
                }
            }
            Write(0, 0, "╔");
            Write(0, width - 1, "╗");
            Write(height - 1, 0, "╚");
            Write(height - 1, width - 1, "╝");
        }
        static void DrawSnake(List<int> snakeX, List<int> snakeY)
        {
            for (int i = 0; i < snakeX.Count; i++)
            {
                Write(snakeX[i], snakeY[i], "0");
            }
        }
        static void DrawFood(int foodX, int foodY)
        {
            Write(foodX, foodY, "*");
        }
        static void MoveSnake(List<int> snakeX, List<int> snakeY, int direction)
        {
            for (int i = snakeX.Count - 1; i > 0; i--)
            {
                snakeX[i] = snakeX[i - 1];
                snakeY[i] = snakeY[i - 1];
            }
            switch (direction)
            {
                case 4: // left
                    snakeY[0]--;
                    break;
                case 6: // right
                    snakeY[0]++;
                    break;
                case 8: // up
                    snakeX[0]--;
                    break;
                case 2: // down
                    snakeX[0]++;
                    break;
                default:
                    break;
            }
        }
        static void Main()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Black; // đặt màu cho rắn
            Console.BackgroundColor = ConsoleColor.DarkGray; // đặt màu cho mồi

            Random r = new Random();
            int score = 0;
            int speed = 100;
            int width = 80;  // x
            int height = 20; // y
            int direction = 2;
            int foodX = r.Next(2, height - 2);
            int foodY = r.Next(2, width - 2);
            List<int> snakeX = new List<int> { 3, 3, 3, 3, 3 };
            List<int> snakeY = new List<int> { 3, 4, 5, 6, 7 };
            bool isOver = false;
            while (!isOver)
            {
                MoveSnake(snakeX, snakeY, direction);
                if (snakeX[0] == 1 || snakeX[0] == height - 2 || snakeY[0] == 1 || snakeY[0] == width - 2)
                {
                    isOver = true;
                }

                for (int i = 1; i < snakeX.Count; i++)
                {
                    if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
                    {
                        isOver = true;
                    }
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey();
                    switch (k.Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (direction != 2) direction = 8;
                                break;
                            }
                        case ConsoleKey.DownArrow:
                            {
                                if (direction != 8) direction = 2;
                                break;
                            }
                        case ConsoleKey.LeftArrow:
                            {
                                if (direction != 6) direction = 4;
                                break;
                            }
                        case ConsoleKey.RightArrow:
                            {
                                if (direction != 4) direction = 6;
                                break;
                            }
                        case ConsoleKey.Escape:
                            isOver = true;
                            break;
                    }
                }
                if (snakeX[0] == foodX && snakeY[0] == foodY)
                { 
                    foodX = r.Next(2, height - 2);
                    foodY = r.Next(2, width - 2);
                    snakeX.Add(snakeX[snakeX.Count - 1]);
                    snakeY.Add(snakeY[snakeY.Count - 1]);
                    score++;
                }
                Console.Clear();
                DrawBorder(width, height);
                DrawSnake(snakeX, snakeY);
                DrawFood(foodX, foodY);
                
                WriteScore(height , 0, score);
                
                System.Threading.Thread.Sleep(speed);
            }
            if (isOver)
            {
                Write(height / 2, width / 2, "End Game!");
            }
            Console.CursorVisible = true;
        }
    }
}

