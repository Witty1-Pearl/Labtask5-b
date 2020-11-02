using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details: ");
            Console.WriteLine("Enter Student Name");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Registration Number: ");
            string StudentRegNumber = Console.ReadLine();
            Console.WriteLine("Enter Department-- SCI or COM: ");
            string StudentDepartment = Console.ReadLine();
            
            ScienceStudent sciencestudent = new ScienceStudent(StudentName,  StudentRegNumber,  50, 65, 70);

            CommercialStudent commercialstudent = new CommercialStudent(StudentName, StudentRegNumber,  56, 70, 80);

            if(StudentDepartment == "SCI")
            {
                Console.WriteLine(sciencestudent.ToString());
            }
            else if(StudentDepartment == "COM")
            {
                Console.WriteLine(commercialstudent.ToString());
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
