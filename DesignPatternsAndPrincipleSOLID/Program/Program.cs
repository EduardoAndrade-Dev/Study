using Examples.SOLID_Principles.SRP___Single_Responsability.Example;
using Examples.SOLID_Principles.SRP___Single_Responsability.Exercise;
using System;
using static System.Console;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRPExample();
            SRPExercise();
        }

        private static void SRPExample()
        {
            var appt = new Appointment
            {
                Patient = new Patient
                {
                    Name = "Juan Ortiz",
                    Email = "juanortiz@gmail.com"

                },
                Time = new DateTime(2019, 03, 08, 15, 20, 19)
            };
            WriteLine(new AppointmentService().Create(appt));
            ReadLine();
        }

        private static void SRPExercise()
        {
            var report = new CourseReport();
            report.AddEntry(new CourseReportEntry { Name = "Patrones de diseño", Students = 1000, Rating = 5 });
            report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

            Console.WriteLine(report.ToString());
            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
        }
    }
}
