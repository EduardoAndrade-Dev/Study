using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples._02_DesignPatterns._01_CREACIONAL_Builder.Fluent_Builder;
using System;
using System.Collections.Generic;
using System.Text;
using ExamplesTests._02_DesignPatterns._01_CREACIONAL_Builder.Fluent_Builder;

namespace TestBuilder
{
    [TestClass()]
    public class GreetTests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            //Greet greeting = new Greet();
            //greeting.TimeOfDay = "Noche";
            //greeting.To = "Eduardo";

            Greet greeting = GreetingBuilder
                .CreateNew()
                .TimeOfDay("Noche")
                .To("Eduardo")
                .Build();

            Assert.AreEqual("Buenas Noche Eduardo", greeting.Message);
        }
    }
}