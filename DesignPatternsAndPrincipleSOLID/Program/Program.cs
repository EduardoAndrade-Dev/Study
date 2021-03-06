﻿using Examples._02_DesignPatterns._01_CREACIONAL_Builder;
using Examples._02_DesignPatterns._01_CREACIONAL_Builder.Exercise;
using Examples._02_DesignPatterns._01_CREACIONAL_Builder.Exercise2;
using Examples._02_DesignPatterns._01_CREACIONAL_Builder_FluentBuilder;
using Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example;
using Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example2;
using Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Example;
using Examples.SOLID_Principles._02_OCP_OpenClosed_Principle.Exercise;
using Examples.SOLID_Principles._03_LSP_Principle.Example;
using Examples.SOLID_Principles._03_LSP_Principle.Exercise;
using Examples.SOLID_Principles._04_ISP_Principle.Example;
using Examples.SOLID_Principles._04_ISP_Principle.Exercise;
using Examples.SOLID_Principles._05_DIP_Principle.Example;
using Examples.SOLID_Principles.SRP___Single_Responsability.Example;
using Examples.SOLID_Principles.SRP___Single_Responsability.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using static Examples.SOLID_Principles._05_DIP_Principle.Example.Enumeration;
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
            //ISPExample();
            //DIPExample();
            //Builder();
            // FluentBuilder();
            //FluentBuilderExercise();
            //FluentBuilderExercise2();*************** Real
            //FactoryExample1();
            FactoryExample2();
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
            Examples.SOLID_Principles._04_ISP_Principle.Exercise.Car vehicle = new Examples.SOLID_Principles._04_ISP_Principle.Exercise.Car();
            Bicycle bicycle = new Bicycle();

        }
        #endregion

        #region DIP Principle
        private static void DIPExample()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Rodrigo", Gender = Gender.Male, Role = Role.Developer },
                new Employee { Name = "Robert", Gender = Gender.Male, Role = Role.Executive },
                new Employee { Name = "Martin", Gender = Gender.Male, Role = Role.Executive },
                new Employee { Name = "Vanessa", Gender = Gender.Female, Role = Role.Executive }
            };
            var employeManager = new EmployeeManager();
            foreach (var employee in employees)
                employeManager.Save(employee);

            var search = new EmployeeSearch(employeManager);

            Console.WriteLine($" Cantidad de Empleados Ejecutivos y de genero Masculino:  {search.GetMaleExecutives()}");
            Console.ReadLine();

        }

        #endregion

        #endregion

        #region DesignPatterns
        
        #region Builder
        private static void Builder()
        {
            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assembly();
            WriteLine($"{sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Cheese} {sandwich.GetSandwich.Condiments} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies}");
            ReadLine();
        }

        //FLUENT BUILDER
        private static void FluentBuilder()
        {
            var fluentBuilder = new SandwichFluentBuilder()
                .WithMeat()
                .WithCheeseChedar()
                .WithMayonesa()
                .WithMostaza();

        }

        private static void FluentBuilderExercise()
        {
            var car = CarBuilder
                .CreateNewCar()
                .AddName("Ford")
                .AddModel("Focus")
                .Build();

            WriteLine(car.Message);
            ReadLine();
        }

        private static void FluentBuilderExercise2()
        {
            var header = HeaderBuilder.
                CreateNewHeader();

            header.AddAgent("src", "alt", "name", "email", "phone", "city");
            header.AddLogo("src", "alt", "href", "title");
            header.Build();

            WriteLine(header);
            ReadLine();
        }

        #endregion

        #region Factory

        private static void FactoryExample1()
        {
            var user = User.Factory.CreateWithDefaultCountry("Rodrigo", "rodrigo@gmail.com");

            WriteLine($"Usuario: {user.Name} Email: {user.Email}, Pais: {user.Country}");
            ReadLine();
        }


        private static void FactoryExample2()
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
            WriteLine($"Pizza {pizza.Name} lista para ser entregada a Rodrigo");
            ReadLine();
        }

        #endregion

        #endregion
    }
}
