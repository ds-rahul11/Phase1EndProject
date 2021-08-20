using System;
using System.Collections.Generic;
using System.Text;

namespace PhaseEndProject
{	
	class TeacherBO { 
		public List<Teacher> Teachers { get; set; }
		public TeacherBO()
		{
			Teachers = new List<Teacher>() {
					new Teacher { Id = 1001, name = "Kiran", subject = "Science", email = "kiran@mail.com" },
					new Teacher { Id = 1002, name = "Kumar", subject = "English", email = "kumar@mail.com"},
					new Teacher { Id = 1003, name = "Shivani", subject = "Maths", email = "shivani@mail.com" },
					new Teacher { Id = 1004, name = "Ankita", subject = "Science", email = "ankita@mail.com" },
					new Teacher { Id = 1005, name = "Netranand", subject = "Social", email = "netra@mail.com" },
			};
		}
		public List<Teacher> GetAllTeachers()
		{
			return Teachers;
		}
		public void EditRecord()
        {
            Console.WriteLine("Enter the Teacher ID");
			int id = Convert.ToInt32(Console.ReadLine());
			int index = Teachers.FindIndex(x => x.Id == id);
            if (index > 0)
            {
				Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Current Details");
                Console.WriteLine($"{Teachers[index].Id} {Teachers[index].name} {Teachers[index].subject}" +
					$"{Teachers[index].email}");
				Console.ResetColor();
                Console.WriteLine("Enter new details");
                Console.Write("ID: ");
				Teachers[index].Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                Teachers[index].name = Console.ReadLine();
				Console.Write("Subject: ");
				Teachers[index].name = Console.ReadLine(); 
				Console.Write("Email: ");
				Teachers[index].name = Console.ReadLine();

			}
            else
            {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Invalid Teacher ID");
				Console.ResetColor();
			}
		}
		public Teacher GetTeacherById(int id) 
		{ 
			return Teachers.Find(x => x.Id == id); 
		}

		public void AddTeacher(Teacher temp) 
		{ 
			Teachers.Add(temp); 
		}
		public int DeleteRecord(int id)
        {
			int index = Teachers.FindIndex(x => x.Id == id);
			if (index >= 0)
			{
				Teachers.RemoveAt(index);
				return 1;
			}
			else return 0;
		}
	} 
}
