using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Demo4
{
    internal class Car
    {
        string carModel;
        int manufactureYear;
        string carColor;
        double speed=0;
        double maxSpeed;

        public Car(string _carModel,double _maxSpeed,int _manufactureYear) {
            this.carModel = _carModel;
            this.maxSpeed = _maxSpeed; 
            this.manufactureYear = _manufactureYear;
        }

        public void Accelerate(double speedRate)
        {
           if ((this.speed+speedRate)<=this.maxSpeed) { this.speed += speedRate; }
        }
        public void Deaccelerate(double speedRate)
        {
            if ((this.speed - speedRate )>= 0) { this.speed -= speedRate; }
        }

        public void PrintCar()
        {
            Console.WriteLine($"Car {this.carModel}:{this.manufactureYear},{this.carColor}:{this.maxSpeed}");
        }
    }
}
