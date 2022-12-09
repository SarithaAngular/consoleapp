

using System.Text;

namespace CSharpBasics
{
     class ArraysInCSharpEx
    {
        static void Main()
        {
            //One/Signle DimensionArray
            // stntax: datatype[] name = new datatype[size];
            //datatype[] name = new datatype[size]{elements};
            //datatype name = new datatype[]{1,2,3,4};


            int[] firstArray = new int[6];
            //firstArray[0] = 5;
            //firstArray[1] = 2;
            //firstArray[2] = 4;
            //firstArray[3] = 1;
            //firstArray[4] = 3;
            //firstArray[5] = 2;
            //Console.WriteLine(   firstArray.Length );
            // Array.Resize( ref firstArray, 7 );
            // Console.WriteLine( firstArray.Length );

            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //   firstArray[i] = i;
            //}
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.WriteLine(firstArray[i]);
            //    Console.ReadLine();
            //}
            //int[] copyArray = new int[6];
            //Array.Copy(firstArray, copyArray, 6);
            //Console.WriteLine("----------------New Copied Array---------------------");
            //for (int i = 0; i < copyArray.Length; i++)
            //{
            //    Console.WriteLine(firstArray[i]);
            //    Console.ReadLine();
            //}
            // Array.Sort(firstArray);
            //    Console.WriteLine("------------------Post Sorting---------------- -");
            //    for ( int i = 0; i < firstArray.Length; i++)
            //    {
            //        Console.WriteLine(firstArray[i]);
            //        Console.ReadLine();
            //    }

            //Array.Reverse(firstArray);
            //Console.WriteLine( Array.IndexOf(firstArray, 2));
            //Console.WriteLine( Array.LastIndexOf(firstArray, 2));
            // Console.WriteLine("------------------Post Revers---------------- -");
            // for (int i = 0; i < firstArray.Length; i++)
            // {
            //     Console.WriteLine(firstArray[i]);
            //     Console.ReadLine();
            // }

            //Multi-Dimensionalarray

            //int[,] arrayName = new int[2, 3];

            //arrayName[0, 0] = 1;
            //arrayName[0, 1] = 2;
            //arrayName[0, 2] = 3;
            //arrayName[1, 0] = 4;
            //arrayName[1, 1] = 5;
            //arrayName[1, 2] = 6;

            //int[,] newarray = new int[2, 3] { { 1, 2, 3 }, { 5, 6,7 } }; 
            //Console.WriteLine(newarray.Rank);

            //for(int i = 0; i < newarray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < newarray.GetLength(1); j++)
            //    {
            //        Console.Write(newarray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //jagged array
            //------------

            //int[][] jArray = new int[2][];
            //int[][,] jArray1 = new int[3][,];

            //jArray[0] = new int[3] { 2,3,4 };
            //jArray[1] = new int[4] {5,6,7,8};


            //int[][] jArray2 = new int[2][]
            //{
            //new int[3] {1,2,3},
            //new int[4] {5,6,7,8}
            //};

            //Console.WriteLine(jArray2[0][1]);
            //Console.WriteLine(jArray2[1][2]);

            //for (int i = 0; i < jArray2.Length; i++) 
            //{
            //    for (int j = 0; j < jArray2[i].Length; j++) 
            //    {
            //        Console.Write(jArray2[i][j] + " " );
            //    }
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}


            //strings

            //string newstr = null;

            //Console.WriteLine("Hello");
            //Console.WriteLine(newstr);
            //Console.WriteLine("hi");

            //string sentence = " I am";
            //Console.WriteLine(sentence);
            //sentence = "saritha";
            //Console.WriteLine(sentence);


            StringBuilder sb = new StringBuilder();
            //sb.Append(" I am learning ");
            //sb.Append(" ");
            //sb.Append(" every day. ");
            //Console.WriteLine(sb.ToString());


            string text = " Hello from c# to everyone ";
            // var newtext = text.Clone();
            //Console.WriteLine(newtext);
            //Console.WriteLine(text.Replace("to", "from"));
            // Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.Length);
            //Console.WriteLine(text.Trim().Length);
            //Console.WriteLine(text.Clone());
            //var splitstr = text.Split();
            //foreach (var str in splitstr)
            //{
            //   Console.WriteLine(str);
            //}
            

        }

     }
}


