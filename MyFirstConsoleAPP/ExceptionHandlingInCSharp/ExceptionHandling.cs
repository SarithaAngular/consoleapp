

namespace ExceptionHandlingInCSharp
{
    internal class ExceptionHandling
    {
        static void Main()
        {
            int i = 10;
            int result = 0;

            try
                    {
                result = i / 2;
                int[] myNumber = new int[2];
                myNumber[2] = 15;
                Console.WriteLine("I will never execute if exception occured. ");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block will always executed.");
            }
        }
    }
}
