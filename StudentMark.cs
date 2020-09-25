using System;

namespace Practical4._2
{
    internal class StudentMark
    {
    
            public string Fullname {
             set;
         get; 
         }
        public int Id {
             set; get;
              }
        public string Class {
             set; get;
              }
        public int Semester { 
            set; get;
             }
        public float Averagemark {
             set; get;
              }

 public StudentMark(string Fullname, int Id, string Class, int Semester, float Averagemark)
        {
            this.Fullname = Fullname;
            this.Id = Id;
            this.Class = Class;
            this.Semester = Semester;
            this.Averagemark = Averagemark;
        }

        public StudentMark()
        {
        }

        public void Display()
        {
            Console.WriteLine("Fullname:" + Fullname);
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Class:" + Class);
            Console.WriteLine("Semester:" + Semester);
            Console.WriteLine("Averagemark:" + Averagemark);
        }
        int[] SubjectMarkList = new int[5];
        public int this[int index]
        {
            get
            {
                return SubjectMarkList[index];
            }
            set
            {
                SubjectMarkList[index] = value;
            }
        }
        public void AveCal()
        {
            Averagemark = (float)(SubjectMarkList[0] + SubjectMarkList[1] + SubjectMarkList[2] + SubjectMarkList[3] + SubjectMarkList[4]) / 5;
            Console.WriteLine("Average Mark = " + Averagemark);
        }
    }
}
        
