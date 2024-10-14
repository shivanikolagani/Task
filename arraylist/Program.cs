using System.Collections;

namespace arraylist
{
    public class Program
    {
        // Predefined ArrayList with student names
        public static ArrayList Attendance = new ArrayList()
    {
        "John",
        "Peter",
        "Jacob",
        "Archie",
        "Sophie",
        "Veronica",
        "Elizabeth",
        "Charles"
    };


        public bool RemoveStudent(string name)
        {
          
            if (Attendance.Contains(name))
            {
                Attendance.Remove(name); 
                return true; 
            }
            return false; 
        }

        public void SortTheAttendance()
        {
            Attendance.Sort(); 
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("1. Remove student");
            Console.WriteLine("2. Sort attendance");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the student name: ");
                string nameToRemove = Console.ReadLine();

                if (program.RemoveStudent(nameToRemove))
                {
                    Console.WriteLine("Removed successfully");
                }
                else
                {
                    Console.WriteLine("Remove failed"); 
                }
            }
            else if (choice == 2)
            {
               
                program.SortTheAttendance();
               
                foreach (string student in Attendance)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice"); 
            }
        }
    }

}
