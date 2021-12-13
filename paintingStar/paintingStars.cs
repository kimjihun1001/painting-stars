using System;

namespace paintingStars
{
    class paintingStars
    {
        public static void PaintStar(int inputToInt, string mode)
        {
            if (0 < inputToInt)
            {
                switch (mode)
                {
                    case "1":
                        Console.WriteLine(mode + "번 모드를 선택했습니다.");
                        Console.WriteLine("당신이 입력한 값은 " + inputToInt + "입니다.");

                        for (int i = 0; i < inputToInt; i++)
                        {
                            int starsCount = 1 + 2 * i;
                            int blanksCount = inputToInt - (i + 1);
                            string blanks = new string(' ', blanksCount);
                            string stars = new string('*', starsCount);  // char 문자 하나를 여러 번 반복하고 싶을 때 사용. 여러 문 반복은 Enumerable.Repeat 사용(닷넷 프레임워크 4.0 이상에서)
                            Console.WriteLine(blanks + stars);
                        }
                        break;
                    case "2":
                        Console.WriteLine(mode + "번 모드를 선택했습니다.");
                        Console.WriteLine("당신이 입력한 값은 " + inputToInt + "입니다.");

                        for (int i = inputToInt; i > 0 ; i--)
                        {
                            int starsCount = 1 + 2 * (i - 1);
                            int blanksCount = inputToInt - i;
                            string blanks = new string(' ', blanksCount);
                            string stars = new string('*', starsCount);  
                            Console.WriteLine(blanks + stars);

                        }
                        break;
                    case "3":
                        Console.WriteLine(mode + "번 모드를 선택했습니다.");
                        Console.WriteLine("당신이 입력한 값은 " + inputToInt + "입니다.");

                        double inputHalf = inputToInt / 2;

                        if (inputToInt == (int)Math.Round(inputHalf) * 2)
                        {
                            int starsMax = inputToInt - 1;
                            Console.WriteLine(starsMax);
                            int starsCount;
                            int blanksCount;
                            string blanks;
                            string stars;
                            for (int i = 0; i < inputToInt; i++)
                            {
                                if (i < Math.Round(inputHalf))
                                {
                                    starsCount = starsMax - 2 * i;
                                    blanksCount = i;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                                else if (i == Math.Round(inputHalf))
                                {
                                    starsCount = 1;
                                    blanksCount = (starsMax - 1) / 2;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);

                                }
                                else
                                {
                                    int j = inputToInt - i - 1;
                                    starsCount = starsMax - 2 * j;
                                    blanksCount = j;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                            }
                        }
                        else
                        {
                            int starsMax = inputToInt;
                            Console.WriteLine(starsMax);
                            int starsCount;
                            int blanksCount;
                            string blanks;
                            string stars;
                            for (int i = 0; i < inputToInt; i++)
                            {
                                if (i < Math.Round(inputHalf))
                                {
                                    starsCount = starsMax - 2 * i;
                                    blanksCount = i;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                                else if (i == Math.Round(inputHalf))
                                {
                                    starsCount = 1;
                                    blanksCount = (starsMax - 1) / 2;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);

                                }
                                else
                                {
                                    int j = inputToInt - i - 1;
                                    starsCount = starsMax - 2 * j;
                                    blanksCount = j;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine(mode + "번 모드를 선택했습니다.");
                        Console.WriteLine("당신이 입력한 값은 " + inputToInt + "입니다.");

                        inputHalf = inputToInt / 2;

                        if (inputToInt == (int)Math.Round(inputHalf) * 2)
                        {
                            int starsMax = inputToInt - 1;
                            Console.WriteLine(starsMax);
                            int starsCount;
                            int blanksCount;
                            string blanks;
                            string stars;
                            for (int i = 0; i < inputToInt; i++)
                            {
                                if (i < Math.Round(inputHalf))
                                {
                                    starsCount = 1 + 2 * i;
                                    blanksCount = (starsMax - 1)/2 - i;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                                else if (i == Math.Round(inputHalf))
                                {
                                    starsCount = starsMax;
                                    blanksCount = 0;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);

                                }
                                else
                                {
                                    int j = inputToInt - i - 1;
                                    starsCount = 1 + 2 * j;
                                    blanksCount = (starsMax - 1) / 2 - j;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                            }
                        }
                        else
                        {
                            int starsMax = inputToInt;
                            Console.WriteLine(starsMax);
                            int starsCount;
                            int blanksCount;
                            string blanks;
                            string stars;
                            for (int i = 0; i < inputToInt; i++)
                            {
                                if (i < Math.Round(inputHalf))
                                {
                                    starsCount = 1 + 2 * i;
                                    blanksCount = (starsMax - 1) / 2 - i;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                                else if (i == Math.Round(inputHalf))
                                {
                                    starsCount = starsMax;
                                    blanksCount = 0;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);

                                }
                                else
                                {
                                    int j = inputToInt - i - 1;
                                    starsCount = 1 + 2 * j;
                                    blanksCount = (starsMax - 1) / 2 - j;
                                    blanks = new string(' ', blanksCount);
                                    stars = new string('*', starsCount);
                                    Console.WriteLine(blanks + stars);
                                }
                            }
                        }
                        break;

                        default:
                        Console.WriteLine("모드 선택을 잘못했습니다.");
                        mode = Console.ReadLine();
                        Console.Write("자연수를 입력하세요: ");
                        string input = Console.ReadLine();
                        inputToInt = int.Parse(input);
                        PaintStar(inputToInt, mode);

                        break;

                }
                

            }
            else if (0 > inputToInt)
            {
                Console.WriteLine("양수를 입력하세요");
                // 여기에 다시 입력할 수 있게 만들어야 할 것 같은데
            }
        }

        static void Main(string[] args)
        {
            bool keep = true;
            while (keep)
            {
                Console.WriteLine("1: 피라미드");
                Console.WriteLine("2: 고드름");
                Console.WriteLine("3: 모래시계");
                Console.WriteLine("4: 다이아");

                Console.Write("별찍기 모드를 선택하세요: ");
                string mode = Console.ReadLine();


                Console.Write("자연수를 입력하세요: ");
                string input = Console.ReadLine();
                int inputToInt = int.Parse(input);

                PaintStar(inputToInt, mode);
                Console.WriteLine("계속 하시겠습니까? Y/N");
                string answer = Console.ReadLine();

                if (answer == "n" || answer == "N")
                {
                    Console.WriteLine("별그리기를 종료합니다");
                    keep = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            

            
        }
    }
}
