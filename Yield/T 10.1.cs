using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentGroup = new Student();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());

                studentGroup.AddStudent(name, age);
            }

            Console.Write("Введите предмет: ");
            string subjname = Console.ReadLine();
            Console.Write("Введите балл: ");
            int subjgrade = Convert.ToInt32(Console.ReadLine());
            studentGroup.AddSubject(subjname,subjgrade);

            Console.Write("Записать в файл? да/нет");
            string file = Console.ReadLine();
            if (file == "да")
            {
                StreamWriter sw = new StreamWriter(@"D:\\Q.txt");
                sw.Write(studentGroup);
            }
            Console.Write("Считать из файла? да/нет");
            string read = Console.ReadLine();
            if (read == "да")
            {
                StreamReader sr = new StreamReader(@"D:\\Q.txt");
                Console.WriteLine(sr.Read());
            }
            Console.ReadKey();
        }
       
    }
    class Student : Subject
    {
        public String Name { get; set; }
        public int Age { get; set; }

        List<Student> students = new List<Student>();
        public void AddStudent(string name, int age)
        {
            Student std = new Student();
            students.Add(std);
        }
        public void GetSpecial()
        {
            foreach (var item in students)
            {
                if (item.Age >= 3)
                {
                    Console.WriteLine(item.SubjectGrade);
                }
            }
        }

        List<Subject> subjects = new List<Subject>();
        public void AddSubject(string subjecName, int subjectGrade)
        {
            Subject sbj = new Subject();
            subjects.Add(sbj);
        }
        static IEnumerable<int> GetAverage(int count)
        {
            Subject sbj = new Subject();
            for (int i = 0; i < count; i++)
            {
                yield return sbj.SubjectGrade;
            }
        }
    }
    class Subject
    {
        public String SubjectName { get; set; }
        public int SubjectGrade { get; set; }
    }
}
