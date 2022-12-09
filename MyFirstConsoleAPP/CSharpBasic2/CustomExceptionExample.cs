namespace ExceptionHandlingInCSharp
{
    class StudentSample
    {
        public string StudentName { get; set; }
    }
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException(string name) : base(string.Format("Invalid Student Name: {0}", name))
        {

        }
    }
    internal class CustomExceptionExample
    {
        static void Main()
        {
            StudentSample student;
           
            try
            {
                student = new StudentSample();
                student.StudentName = "Ram123";
                ValidateStudent(student);
                Console.WriteLine(student.StudentName);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            static void ValidateStudent(StudentSample std)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]+$");
                if (!regex.IsMatch(std.StudentName))
                    throw new InvalidStudentNameException(std.StudentName);
            }
        }
    }
}
