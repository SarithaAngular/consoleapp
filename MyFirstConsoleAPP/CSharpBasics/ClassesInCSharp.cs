

namespace CSharpBasics
{
     class ClassesInCSharp
    {
        public int i { get; set; } //attributes or field

        public ClassesInCSharp()
        {

        }
        void PrintMessage()  //method or behaviour
        {
            Console.WriteLine("Hello from the class.");
        }

        static void Main()
        {
            var obj = new ClassesInCSharp();
            obj.i = 10;
            Console.WriteLine(obj.i);
        }
    }
        class StudentEx
        {
            public int Id { get; set; }
            public string Name { get; set; }

            void AttendClass()
            {
                Console.WriteLine("Attending class");
            }
        }
    
}
