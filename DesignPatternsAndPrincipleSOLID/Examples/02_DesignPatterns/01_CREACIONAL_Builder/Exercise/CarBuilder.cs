using System;
using System.Collections.Generic;
using System.Text;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder.Exercise
{
    public class CarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public static CarBuilder CreateNewCar()
        {
            return new CarBuilder();
        }

        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            return this;
        }

        public CarBuilder AddModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
