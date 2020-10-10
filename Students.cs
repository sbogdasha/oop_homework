using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    abstract class Student
    {
        public string Name { get;  set; }
        public string State { get;  set; }

        public Student(string _name) //конструктор
        {
            Name = _name;
            State = "";
        }

        public void Relax()    // методи
        {
            State += " Relax";
        }


        public void Read()
        {
            State += " Read";
        }


        public void Write()
        {
            State += " Write";
        }

        public abstract void Study();

    }



     class GoodStudent : Student
    {

        public override void Study()
        {
            Read(); Write(); Read(); Write(); Relax();

        }

        public GoodStudent(string _name)
            :base(_name)//конструктор
        {
            State +=" good ";
        }
    }



    class BadStudent : Student
    {

        public override void Study()
        {
            Relax(); Relax(); Relax(); Relax(); Relax();
        }

        public BadStudent(string _name)
            : base(_name)//конструктор
        {
            State += " bad ";
        }
    }




    class Group
    {
        private List<Student> Students;

        public string GroupName { get; set; }

        public Group(string _groupname) //конструктор
        {
            GroupName = _groupname;
            Students = new List<Student>();
        }



        public void AddStudent(Student st)
        {
            Students.Add(st);
        }


        public string GetInfo()
        {
            string info = "";
            info += GroupName;
            foreach(Student st in Students)
            {
                info += st.Name;
            }
            return info;
        }


        public string GetFullInfo()
        {
            string f_info = "";
            f_info += GroupName;
            foreach (Student st in Students)
            {
                f_info += st.Name;
                f_info += st.State;
            }
            return f_info;

        }

    }



    class Program
        {
           public static void Main(string[] args)
            {

            string a = " K-24 ";

            Group gr = new Group(a);
            Console.WriteLine(gr.GroupName);

            string b = " Sasha Timofeyeva ";
            string c = " Stukalo Bogdan ";
            string d = " Evgeniy Ivanov ";

            GoodStudent st1 = new GoodStudent(b);
            GoodStudent st2 = new GoodStudent(c);
            BadStudent st3 = new BadStudent(d);

            st1.Study();
            st2.Study(); 

            gr.AddStudent(st1);
            gr.AddStudent(st2);
            gr.AddStudent(st3);
            Console.WriteLine("Here is short info: ");
            Console.WriteLine(gr.GetInfo());
            Console.WriteLine("Here is full info: ");
            Console.WriteLine(gr.GetFullInfo());


                Console.ReadKey();
            }
        }
    }
