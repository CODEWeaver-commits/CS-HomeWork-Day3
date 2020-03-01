using ConsoleIO;

namespace CS_HomeWork_Day3_08
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Patronymic { get; private set; }
        public string Group { get; private set; }
        public byte Age { get; private set; }
        public byte[][] Grades = new byte[3][];
        public enum Subject
        {
            Programming = 1, //
            Administration,
            Design
        }

        public Student(string FirstName, string LastName, string Patronymic, string Group, byte Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.Group = Group;
            if (ConsoleInput.IsValidNumber(Age))
            {
                this.Age = Age;
            }
            else ConsoleOutput.WriteMessage();
        }
        public void SetGrades(Subject subject)
        {
            switch(subject)
            {
                case Subject.Programming:
                    break;
                case Subject.Administration:
                    break;
                case Subject.Design:
                    break;
                default:
                    throw new System.Exception("Нету такого предмета!");
            }
        }
        public void AboutStudent()
        {
            ConsoleOutput.WriteInfo(FirstName, LastName, Patronymic, Group, Age);
        }
    }
}
