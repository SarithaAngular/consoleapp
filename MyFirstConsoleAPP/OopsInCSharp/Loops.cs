
namespace LoopsInCSharp
{
     class Loops
    {
        public int AddNumbers(int a , int b)
        {
            return a + b;
        }
        static void Main()
        {
            //while
            //int i = 1;
            //  while (i < 3)
            //  {
            //          Console.WriteLine("I value is : " + i);
            //          i++;
            //          int j = 1;
            //          while (j < 3)
            //          {
            //              Console.WriteLine("J value is : {0}", j);
            //              j++;
            //          }
            //  }

            // 2-do while
            //int i = 1;
            //do 
            //{
            //    Console.WriteLine("I value is: " + i);
            //    i++;
            //  int  j = 1;
            //    do
            //    {
            //        Console.WriteLine("J value is: " + j);
            //        j++;
            //    } while (j < 3);
            //} while (i < 3);

            //3- for loop

            //int i = 1;
            //for(; ; )
            //{
            //    if (i < 10)
            //    {
            //        Console.WriteLine("i Value is : " + i);
            //    }
            //    else
            //        break;
            //    i++;
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I value is : " + i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"value of j : {j}");
                }
            }


            //foreach

            //List<string> numList = new List<string>() {"Saritha", "Prasanthi","Nani","Vinod"};
            //for(int i =  0; i < numList.Count; i++)
            //{
            //    Console.WriteLine(numList[i]);
            //}

            //foreach ( var item in numList)

            //{
            //   Console.WriteLine(item);
            //}


            //var obj = new Loops();
            //int res = obj.AddNumbers(10, 20);
            //Console.WriteLine(res);

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine("I Value is:" + i);
            //    i++;
            //}


        }
     }
}
