using System;
using System.Collections.Generic;

namespace FolhaSalarial
{
    class Program
    {
        static void Main(string[] args)
        {


            // ***** Start ***** //


            //Variáveis temporárias//
            int id;
            string name;
            double salary;
            //Variáveis temporárias//

            //Variáveis//
            int numOfEmployees;
            int searchId;
            Employee emp;
            double percentage;
            //Variáveis//

            //Listas//
            List<Employee> listOfEmployees = new List<Employee>();
            //Listas//

            //Entrada//
            Console.Write("How many employees will be registered?: ");
            numOfEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numOfEmployees; i++)
            {

                Console.WriteLine($"***Employee number {i}***");
                Console.WriteLine();
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());

                listOfEmployees.Add(new Employee(id, name, salary));

                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            searchId = int.Parse(Console.ReadLine());

            emp = listOfEmployees.Find(x => x.Id == searchId);

            if (emp != null)
            {

                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);

            }

            else
            {

                Console.WriteLine("This Id does not exist!");

            }
            //Entrada//

            //Saída//
            Console.WriteLine();
            Console.WriteLine("List of employees: ");

            foreach(Employee names in listOfEmployees)
            {

                Console.WriteLine(names);

            }
            //Saída//


            // ***** The End ***** //


        }
    }
}
