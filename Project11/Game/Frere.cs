using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public  class Frere
    {
        int id {  get; set; }
        string name { get; set; }   
        Point positionFrere { get; set; }
        

        public Frere(int _id, String _name)
        {
            this.id = _id;
            this.name = _name;
        }
        public void MoveFrere( object? ball, DeltaPosition dp)
        {   
           if (ball != null && dp != null && ( ball.GetType()== typeof(Ball) ) ) 
            {
                
                    Console.WriteLine($" Frere{this} has notified {dp.delta_X},{dp.delta_Y} ");
            }
            
        }
        public override string ToString()
        {
            return $"  frere: id {this.id}, Name{this.name}";
        }
    }
}
