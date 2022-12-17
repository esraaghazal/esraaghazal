using System;

public  class Person
{
    public string Name;
    public int Age;


    public Person(string name,int age)
    {
         if (name == null || age>128)
         {
             Console.WriteLine(" not allowed , Enter the values again");
         }


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
    private int Year;
    private float Gpa;
    

       public int _Year
    {
        get
        {
            return Year;
        }
        set
        {
           Year=value;
        }
    }
    public float _Gpa
    {
        get
        {
            return Gpa;
        }
        set
        {

           Gpa=value;
        }
    }

    public Student(string name, int age ,int year, float gpa) :base(name,age)
    {
         
        if(year<1 || year>5)
        {
         throw new Exception("invalid exeption");
        }
        if (gpa<0 || gpa>4)
        {
         throw new Exception("invalid exeption");
        }
        

        Year=year;
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
    private int JoinYear;

    public int _joinyear
    {
        get
         {
            return JoinYear;
         }
         set
         {

            JoinYear=value;
         }
    }
    public Staff(string name, int age ,double salary, int joinyear):base(name,age)
    {

            if (salary<0 || salary>120000)
            {
             throw new Exception("invalid exeption");
            }
            if (joinyear<21)
            {
                throw new Exception("invalid exeption");
            }
            

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
        Student st = new Student("esraa",20,4,3);
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

                   Console.Write("the year");
                   year =Convert.ToInt32(Console.ReadLine());

                    Console.Write("the gpa");
                   gpa =float.Parse(Console.ReadLine());
                   database.Addstudent(st);
                
                break;
                
                case 2:
                   Console.Write("the name");
                   name=Console.ReadLine();

                   Console.Write("the age");
                   age =Convert.ToInt32(Console.ReadLine());

                   Console.Write("the joinyear");
                   joinyear =Convert.ToInt32(Console.ReadLine());

                    Console.Write("the salary");
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




