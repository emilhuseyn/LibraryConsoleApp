using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Department newDepartment = new Department();
            bool running = true;


            Console.WriteLine("========== Welcome Department App ==========");
            while (running)
            {
                if(newDepartment.Name == null)
                {
                    Console.WriteLine("\tCreate Department Section");
                    Console.WriteLine("1. Give a name for department");
                    Console.WriteLine("0. Exit");
                    string input = Console.ReadLine();
                    if(int.TryParse(input, out int number))
                    {
                        switch (number)
                        {
                            case 0:
                                running = false;
                                break;
                            case 1:
                                CreateDeparment(newDepartment);
                                break;
                            default:
                                Console.WriteLine("\nYou must enter numbers between 0-1!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nYou must enter numbers!");
                    }
                }
            }
            Console.WriteLine("\t Program has been stopped");

        }

        public static void CreateDeparment(Department oldDepartment)
        {
            Console.Write("\nDepartment Name: ");
            string name = Console.ReadLine();

            oldDepartment.Name = name;

            Console.WriteLine("\nDepartment has been created!\n");
        }
    }
}
