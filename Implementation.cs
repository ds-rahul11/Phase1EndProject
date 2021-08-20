using System;
using System.Collections.Generic;
using System.Text;

namespace PhaseEndProject
{
    class Implementation
    {
        static void Main(string[] args)
        {
            TeacherBO context = new TeacherBO();
            Console.WriteLine("1. Add Teacher Details\n2. Edit Teacher details\n" +
                "3. Print all Teacher\n4. Print Teacher details by ID\n" +
                "5. Delete Teacher Record\n6.Exit\n");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter ID, Name, Subject, Email");
                        Teacher temp = new Teacher();
                        temp.Id = Convert.ToInt32(Console.ReadLine());
                        temp.name = Console.ReadLine();
                        temp.subject = Console.ReadLine();
                        temp.email = Console.ReadLine();
                        context.AddTeacher(temp);
                        Console.ResetColor();
                        break;
                    case 2: context.EditRecord();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Teacher Details");
                        List<Teacher> tList = context.GetAllTeachers();
                        foreach (var item in tList)
                        {
                            Console.WriteLine($"{item.Id} {item.name} {item.subject} {item.email}");
                        }
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.WriteLine("Enter Teacher ID");
                        Teacher tmp = context.GetTeacherById(Convert.ToInt32(Console.ReadLine()));
                        if (tmp == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Teacher ID");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{tmp.Id} {tmp.name} {tmp.subject} {tmp.email}");
                            Console.ResetColor();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter the Teacher ID");
                        int tp = context.DeleteRecord(Convert.ToInt32(Console.ReadLine()));
                        if (tp == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Record Deleted Successfully");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Teacher ID");
                            Console.ResetColor();
                        }
                        break;
                    default:
                        choice = 6;
                        break;
                }
                Console.WriteLine("\n1. Add Teacher Details\n2. Edit Teacher details\n" +
                "3. Print all Teacher\n4. Print Teacher details by ID\n" +
                "5. Delete Teacher Record\n6.Exit\n");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
