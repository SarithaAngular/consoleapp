  
namespace CSharpBasics
{
      class ConditonalStatementsCSharp
    {
       static void Main()
        {
            // int i = 10;
            // double d = 30.2;
            // string str = "Saritha";
            // if (i > 20)
            //{
            // Console.WriteLine($"I is greater 20 {i}");
            //  Console.WriteLine("I is greater than cancat 20" + i);
            //  Console.WriteLine("I am the old way {0}, {1}, {2}", i, d, str);
            // }
            //else
            //{
            //    Console.WriteLine($"I is not greater than 20, value of i is {i}");
            //}
            // Console.WriteLine("Hello " + str);
            //Console.WriteLine("I am the old way {0}, {1}, {2}", i, d, str);


            //Console.Write("please enter your favourite color: 1-Red, 2-Green, 3-Black, 4-Yellow, 5-Blue : ");
            //int colorChoice = Convert.ToInt32(Console.ReadLine());
            //if(colorChoice == 1)
            // {
            // Console.WriteLine("Your fav color is Red");
            // }
            //  else if (colorChoice == 2)
            // {
            //     Console.WriteLine("Your fav color is Green");
            // }
            //else if (colorChoice == 3)
            //{
            //    Console.WriteLine("Your fav color is Black");
            // }
            // else if (colorChoice == 4)
            // {
            //     Console.WriteLine("Your fav color is Yellow");
            //}
            // else if (colorChoice == 5)
            // {
            //     Console.WriteLine("Your fav color is Blue");
            // }
            // else
            // {
            //   Console.WriteLine("sorry your color doesn't exist");
            //}


            //Console.Write("please enter your favourite color: 1-Red, 2-Green, 3-Black, 4-Yellow, 5-Blue : ");
            //int colorChoice = Convert.ToInt32(Console.ReadLine());

            //switch (colorChoice)
            //{
            //    case 1:
            //    Console.WriteLine("Your fav color is Red");
            //        break;
            //    case 2:
            //        Console.WriteLine("Your fav color is Green");
            //        break;
            //    case 3:
            //        Console.WriteLine("Your fav color is Black");
            //        break;
            //    case 4:
            //        Console.WriteLine("Your fav color is Yellow");
            //        break;
            //    case 5:
            //        Console.WriteLine("Your fav color is Blue");
            //        break;

            //    default:
            //         Console.WriteLine("Your color dosn't exist");
            //        break;
            //}

            Console.Write("please enter your favourite color: Red, Green, Black, Yellow, Blue : ");
            string colorChoice = Console.ReadLine().ToLower();
            switch (colorChoice)
            {
                case "red":
                    Console.WriteLine("Your fav color is Red");
                    break;
                case "green":
                    Console.WriteLine("Your fav color is Green");
                    break;
                case "black":
                    Console.WriteLine("Your fav color is Black");
                    break;
                case "yellow":
                    Console.WriteLine("Your fav color is Yellow");
                    break;
                case "blue":
                    Console.WriteLine("Your fav color is Blue");
                    break;

                default:
                    Console.WriteLine("Your color dosn't exist");
                    break;
            }   
            }
        }
}
