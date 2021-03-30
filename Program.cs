using System;

namespace Variables_Task_BH_103339613
{
    class Program
    {
        static void Main(string[] args)
        {

          
          
          string nameF, nameL, ageI, IDi, birthI, yearI;
          int age, studentID, birthY, yearN;

          Console.WriteLine("What is your first name? ");
          nameF = Console.ReadLine();

          Console.WriteLine("What is your last name?");
          nameL = Console.ReadLine();

          Console.WriteLine("What is your Swinburne ID?");
          IDi = Console.ReadLine();
          studentID = Convert.ToInt32(IDi);

          Console.WriteLine("What year where your born?");
          birthI = Console.ReadLine();
          birthY = Convert.ToInt32(birthI);

          Console.WriteLine("What is the current year");
          yearI = Console.ReadLine();
          yearN = Convert.ToInt32(yearI);

          Console.WriteLine("What is your age");
          ageI = Console.ReadLine();
          age = Convert.ToInt32(ageI);

          Console.WriteLine("Hello " + nameF + " " + nameL + ". your student ID is " + IDi + ". you where born on the year " + birthI + " and the current year is " + yearI + " ");

          
        }
    }
}
