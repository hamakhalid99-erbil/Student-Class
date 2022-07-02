using System;
using System.Collections.Generic;
using Third_Assignment;


namespace Third_Assignment

{
    class Program
    {
      static void Main(string[] args)
            {
                List<student> StudentList = new List<student>();
                student input = new student();
                StudentList.Add(new student

                {
                    FirstName = "Hama",
                    LastName = "Khalid",
                    Semester = 1});
                StudentList.Add(new student

                {
                    FirstName = "Yado",
                    LastName = "Rasa",
                    Semester = 1
                });
                StudentList.Add(new student

                {
                    FirstName = "sarkawt",
                    LastName = "sherwani",
                    Semester = 2
                }
                );
                StudentList.Add(new student

                {
                    FirstName = "Alaa",
                    LastName = "rzgar",
                    Semester = 2}
                );
                StudentList.Add(new student

                {
                    FirstName = "Ali",
                    LastName = "karo",
                    Semester = 1}
                );

                foreach (var student in StudentList)
                {
                    student.studentinfo();
                }
                Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");


                Console.WriteLine("Choose The Alphabets:");
                Console.WriteLine("A)Input another student.");
                Console.WriteLine("B)Find. ");
                Console.WriteLine("C)Move to next semster. ");
                Console.WriteLine("D) Delete .");
                Console.WriteLine("E)Show the Students. ");
                Console.WriteLine("F)Clear all");

                Console.Write("\r\nSelect an option: ");
                switch (Console.ReadLine())
                {
                    case "a":
                    case "A":

                        input.InputStudent();
                        StudentList.Add(input);

                        foreach (var s in StudentList)
                        {
                            Console.WriteLine("First name  is \"{0}\"", s.FirstName);
                            Console.WriteLine("Last name is \"{0}\"", s.LastName);
                            Console.WriteLine("semester is \"{0}\"", s.Semester);
                        }
                        break;

                    case "B":
                    case "b":
                        Console.WriteLine("Search students Last name: ");
                        string inputsearch = Console.ReadLine();
                        bool StudentFound = false;
                        for (int i = 0; i < StudentList.Count; i++)
                        {

                            if (StudentList[i].LastName == inputsearch)
                            {
                                Console.WriteLine("full name of the student that are required " + StudentList[i].FirstName + " " + StudentList[i].LastName);
                                StudentFound = true;
                            }
                        }
                        if (!StudentFound)
                        {
                            Console.WriteLine("Nothing is found!");
                        }

                        break;
                    case "c":
                    case "C":
                        Console.WriteLine("You wanted al the student in the first semester");

                        foreach (var student in StudentList)
                        {
                            student.GoToNextSemester();
                        }


                        break;
                    case "D":
                    case "d":


                        break;
                    case "E":
                    case "e":
                        foreach (var student in StudentList)
                        {
                            student.studentinfo();
                        }

                        break;
                    case "F":
                    case "f":
                        StudentList.Clear();
                        Console.WriteLine("all are deleted!");

                        break;

                }

                Console.ReadKey();

            }
        }
    }

}
    
