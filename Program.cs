using System;
using System.Collections.Generic;

namespace Practical4._2
{
    class Program
    {
        static void Main(string[] args)
        {
           Program n = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Insert new student");
                Console.WriteLine("2.View list of students ");
                Console.WriteLine("3.Average mark ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        n.InsertStudent();
                        break;

                    case 2:
                        n.ViewListStudent();
                        break;
                    case 3:
                        n.AverageMark();
                        break;
                    case 4:
                        return;

                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, StudentMark> ListStudent = new Dictionary<int, StudentMark>();
        public void InsertStudent()
        {
            StudentMark studentMark = new StudentMark();
            studentMark.Id = count;
            Console.WriteLine("Input full name :");
            studentMark.Fullname = Console.ReadLine();
            Console.WriteLine("Input Class :");
            studentMark.Class = Console.ReadLine();
            Console.WriteLine("Input semeter :");
            studentMark.Semester = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input Marks of subject " + (i + 1) + ":");
                studentMark[i] = int.Parse(Console.ReadLine());

            }

            ListStudent.Add(count, studentMark);
            count++;
        }
        public void ViewListStudent()
        {
            foreach (StudentMark item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void AverageMark()
        {
            foreach (StudentMark item in ListStudent.Values)
            {
                item.Display();
                item.AveCal();
            }
        }

    }
}
