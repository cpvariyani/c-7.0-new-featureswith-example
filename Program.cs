using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpnewfeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // use of Out

            //string strInput = "10";

            //int resultOld = 0;

            //int.TryParse(strInput, out resultOld);

            //Console.WriteLine("old out value " + resultOld);


            ///// new way for out
            ///// 

            //int.TryParse(strInput, out int resultInNewVariable);
            //Console.WriteLine("new out value " + resultInNewVariable);




            // 2. Tuples


            //var personTuple = Tuple.Create(28, "Z");
            //Console.WriteLine("tuple " + personTuple.Item1);
            //Console.WriteLine("tuple " + personTuple.Item2);


            //var peronTupleNew = (Age: 28, Name: "Z");
            //Console.WriteLine("tuple new " + peronTupleNew.Age);
            //Console.WriteLine("tuple new " + peronTupleNew.Name);

            //var res = GetNameAndAge();
            //Console.WriteLine("tuple new " + res.Age);


            // Discard


            //string date = "05/01/2019 14:12:12";

            //if (DateTime.TryParse(date, out _))
            //{
            //    Console.WriteLine("valid");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}



            // 4 Pattern Matching

            //object valueObj = "10";

            //if(valueObj is int newValueObj)
            //{
            //    Console.WriteLine(newValueObj);
            //}

            // switch


            //Employee emp1 = new Employee { Name = "X", Role = "Manager" };
            //Employee emp2 = new Employee { Name = "Y", Role = "Developer" };

            //List<Employee> employees = new List<Employee>() { emp1, emp2 };

            //foreach (var emp in employees)
            //{
            //    switch (emp)
            //    {
            //        case Employee e when (e.Role == "Manager"):
            //            e.Salary = 1000;
            //            break;
            //        case Employee e when (e.Role == "Developer"):
            //            e.Salary = 2000;
            //            break;
            //        default:
            //            Console.WriteLine("nothing found");
            //            break;
            //    }
            //}

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp.Name + " ~ " + emp.Role + " ~ " + emp.Salary);

            //}


            // Throw Excpetion

            int age = 40;
            string resThrow = age > 30 ? "All good" : throw new Exception("Age is not valid");


            Console.WriteLine(resThrow);


            // Null coalescing Operator
            Employee emp1 = new Employee { Name = "X", Role = "Manager" };
            Employee emp2 = new Employee { Name = "Y", Role = "Developer" };
            List <Employee> employees = new List<Employee>() { emp1, emp2 };

            Employee empResult = employees.Where(x => x.Name == "Z").FirstOrDefault();
            //if(empResult != null)
            //{
            //    empResult.Comment = "emp found";
            //    Console.WriteLine(empResult.Name + " ~ " + empResult.Comment);
            //}
            //else
            //{
            //    Console.WriteLine("emp not found");
            //}


            Employee empResultNewWay = employees.Where(x => x.Name == "X").FirstOrDefault() ??
                throw new Exception("Employee does not exists");

            empResultNewWay.Comment = "Employee found";

            Console.WriteLine(empResultNewWay.Name + " ~ " + empResultNewWay.Comment);


            Console.ReadLine();


        }

        public static (string Name, int Age) GetNameAndAge()
        {
            return ("ZName", 28);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Comment { get; set; }
        public int Salary { get; set; }
    }
}
