using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_sharp_3
{
    class Student
    {

        string fname;
        string lname;
        int age;
        double avg;
        static string group;

        static Student() 
        {
            group = "PV221";
        }

        /*public Student()
        {
            fname = " ";
            lname = " ";
            age = 0;
            avg = 0;
            WriteLine($"constructor default");
        }*/

       

        public Student(string fn, string ln, int a)
        {
            fname = fn;
            lname = ln;
            age = a;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        avg = getAvg();
        }

        public void show()
        {
            WriteLine($"{lname} {fname} {age} {group}");
        }

        public void show_with_average()
        {
            WriteLine($"{lname} {fname} {age} {avg} {group}");
        }

        public void setFname()
        {
            WriteLine($"enter the name: ");
            fname = ReadLine();
        }

        public string getFname()
        {
            return fname;
        }

        public override string ToString()
        {
            return $"{lname} {fname} {age} {group}";
        }

      

        public double getAvg()
        {
            return avg;
        }

        public void change_age(ref Student tmp)
        {
            Write("Введите новый возраст: ");
            string newa;
            newa = ReadLine();
            int newage = Convert.ToInt32(newa);
            tmp.age = newage;
            tmp.show();
        }

        public void setAvg(out int num)
        {

              Random r = new Random();
              num = r.Next(12);
              avg = num;
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student ("Alice", "Wiw", 20 );
            Student st2 = new Student("Pedro", "Pascal", 22 );
            Student st3 = new Student("Alex", "Lilp", 19 );
            Student st4 = new Student("Luna", "Tix", 18 );
            Student st5 = new Student("Sergey", "Polp",21);

            Student[] arr = new Student[5] {st1,st2,st3,st4,st5};

            foreach (Student item in arr)
            {
                item.show();
            }

            WriteLine();

            st1.change_age(ref st1);

            WriteLine();

            int num;        

            st1.setAvg(out num);
            st1.show_with_average();
            
        }
    }
}
