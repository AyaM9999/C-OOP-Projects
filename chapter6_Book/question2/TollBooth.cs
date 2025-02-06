using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    public  class TollBooth
    {
        int id;
        public  int countcars = 0;
        public  double totalCash = 0.0d;
        public double totalCash2 = 0.0d;
        public List<Carcs> cars = new List<Carcs>();

        public event Func<double,double> del= (  totalCash2)=> totalCash2+50.0d;   // define event


        public TollBooth(int id) {
            this.id = id;
        }
        public  void PayingCar()
        {
            countcars++;
            totalCash++;
            del.Invoke(totalCash2);
        }

        public void NOPayingCar()
        {
            
            countcars++;
            
        }

        public override string ToString()
        {
            return $" tollbath id:{this.id},total passed cars:{this.countcars}, total collected fees:{this.totalCash}del cash:{this.totalCash2}";
        }





    }
}
