using Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Example;
using Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Exercise;
using Examples.SOLID_Principles._03_LSP_Principle.Example;
using Examples.SOLID_Principles._03_LSP_Principle.Exercise;
using Examples.SOLID_Principles._04_ISP_Principle.Example;
using Examples.SOLID_Principles._04_ISP_Principle.Exercise;
using Examples.SOLID_Principles.SRP___Single_Responsability.Example;
using Examples.SOLID_Principles.SRP___Single_Responsability.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SRPExample();
            //SRPExercise();
            //OCPExample();
            //OCPExercise();
            //LCPExample();
            //LCPExercise();
            ISPExample();
        }
        #region SOLID PRINCIPLE
        
        #region SRP Principle
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
        #endregion
        
        #region OCP Principle
        private static void OCPExample()
        {
            List<IApplicant> persons = new List<IApplicant>()
            {
                new Person{FirstName = "Eduardo", LastName="Andrade"},
                new Doctor{FirstName = "Jacqueline", LastName="Silva"},
                new Nurse{FirstName = "Manuela", LastName="Silva"}
            };

            List<Staff> staffs = new List<Staff>();
            foreach (var person in persons)
            {
                staffs.Add(person.Processor.Create(person));
            }

            WriteLine(string.Join(Environment.NewLine, staffs.Select(x => $"Bienvenido: {x.FirstName}, {x.LastName}, Email: {x.Email}")));
        }

        private static void OCPExercise()
        {
            List <IShape> shapes = new List<IShape>()
            {
                new Rectangle(){Height=10, Width=20},
                new Circle(){Radius=50}


            };
            AreaCalculator areaCalculator = new AreaCalculator();
            WriteLine(areaCalculator.Area(shapes));
        }


        #endregion

        #region LSP Principle
        public static void LCPExample()
        {
            //IPlayerTeam player = new FootballPlayer();
            Player player = new TennisPlayer();
            player.FirstName = "Walter";
            player.LastName = "Montillo";
            //player.AssignTeam(new Team { Name = "U de Chile" });
            player.SetCategory(PlayerCategory.Professional);

            WriteLine($"{player.FirstName} {player.LastName} Categoria {player.Category}");
            ReadLine();
        }

        public static void LCPExercise()
        {
            Bird animal = new Bird();
            animal.noise = "awww";
            animal.MakeNoise();
            animal.Fly();
            Console.ReadLine();
        }

        #endregion

        #region ISP Principle
        private static void ISPExample()
        {
            HPLaserJetPrinter hpPrint = new HPLaserJetPrinter();
            hpPrint.Fax("Pasando fax");
            hpPrint.Scan("Escaneando");
            hpPrint.Print("Imprimiendo");

            ReadKey();
        }

        private static void ISPExercise()
        {
            Car vehicle = new Car();
            Bicycle bicycle = new Bicycle();

        }
        #endregion

        #endregion




    }
}
