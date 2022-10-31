using System;

namespace myclass
{

    class person
    {
       private string name;
        private int age;

         public void print()
        {
            Console.WriteLine("Name: " + name + "Age: " +age);

        }
        public void setperson(string name , int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            person p2 = new person();
            p1.setperson("Ali ",20);
            p1.print();
            p2.setperson("Ahmad " , 30);
            p2.print();
        }
    }
}
