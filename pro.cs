using System;

public  class Person
{
    public string Name;
    public int Age;


    public Person(string name,int age)
    {
        Name=name;
        Age=age;
    }
    public virtual void print()  //abstract
    {
        
    }
}
/////////////////////////////
public class Student:Person
{
    public int Year;
    public float Gpa;

    public Student(string name, int age ,int year, float gpa):base(name,age)
    {
        Age=age;
        Gpa=gpa;
    }
    public override void print()  //override
    {
        Console.WriteLine($"my name is {Name}, my age is {Age},my gpa is {Gpa}");
    }

}
/////////////////////////////////////////
public class Database
{
    private int _currentindex;
      public Person[] people = new Person[50];

      public void Addstudent (Student student)
      {
           if (_currentindex==49)return;
           people[_currentindex++]= student;
      }

     public void Addstaff (Staff staff)
      {
           if (_currentindex==49)return;
           people[_currentindex++]= staff;
      }

           public void Addperson (Person person)
      {
           if (_currentindex==49)return;
           people[_currentindex++]= person;
      }

      public void printall()
      {
        for(int i=0 ; i<=_currentindex ;i++)
        {
            people[i].print();
        }
      }



}
/////////////////////////////////////
public class Staff:Person
{
    public double Salary;
    public int JoinYear;

    public Staff(string name, int age ,double salary, int joinyear):base(name,age)
    {
        Salary =salary;
        JoinYear=joinyear;
    }
    public override void print()  //override
    {
        Console.WriteLine($"my name is {Name}, my age is {Age},my salary is {Salary}");
    }

}
///////////////////////////////////


namespace Project{
public class project
{
    static void Main()
    {
        Student st = new Student("esraa",20,2022,3);
        Staff sta = new Staff("esraa",30,3000,2000);
         Person pe = new Person("name",000);


        Database database=new Database();
         int age,year,joinyear;
         string name;
         float gpa;
         double salary;

        while(true)
        {
            
            Console.WriteLine("1 for stu---- 2 for staff ---- 3 for all");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                   Console.Write("the name");
                   name=Console.ReadLine();

                   Console.Write("the age");
                   age =Convert.ToInt32(Console.ReadLine());

                   Console.Write("the age");
                   year =Convert.ToInt32(Console.ReadLine());

                    Console.Write("the age");
                   gpa =float.Parse(Console.ReadLine());
                   database.Addstudent(st);
                
                break;
                
                case 2:
                   Console.Write("the name");
                   name=Console.ReadLine();

                   Console.Write("the age");
                   age =Convert.ToInt32(Console.ReadLine());

                   Console.Write("the age");
                   joinyear =Convert.ToInt32(Console.ReadLine());

                    Console.Write("the age");
                   salary =double.Parse(Console.ReadLine());
                   database.Addstaff(sta);
                break;

                  case 3:
                   Console.Write("the name");
                   name=Console.ReadLine();

                   Console.Write("the age");
                   age =Convert.ToInt32(Console.ReadLine());

                   database.Addperson(pe);


                break;

                default:
                 database.printall();
                 break;


            }

        }
    }
}
}
