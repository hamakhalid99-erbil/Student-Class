using System;
using System.Collections.Generic;
using System.Text;

namespace Third_Assignment
{
    class Students
    {
        class student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Semester { get; set; }

            public void studentinfo()
            {
                Console.WriteLine(LastName + " , " + FirstName + " - " + Semester);
            }
            public void GoToNextSemester()
            {
                if (Semester < 12)
                {
                    Semester += 1;
                    Console.WriteLine(FirstName + " It will Participate " + Semester + " next!");
                }
                else
                {
                    Console.WriteLine(FirstName + "It is in the final semster!");
                }
            }
            public void InputStudent()
            {
                Console.WriteLine("What is the FirstName? ");
                FirstName = Console.ReadLine();
                Console.WriteLine("you entered {0}", FirstName);
                Console.WriteLine("What is the LastName?");
                LastName = Console.ReadLine();
                Console.WriteLine("you entered {0}", LastName);
                Console.WriteLine("Input the Semester: ");
                Semester = int.Parse(Console.ReadLine());
                Console.WriteLine("you entered {0}", Semester);

            }


        }
    }


}

