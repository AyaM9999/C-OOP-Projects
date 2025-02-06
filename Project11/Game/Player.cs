using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public int id {  get; set; }
        public string name { get; set; }    
        public Point positionPlayer { get; set; }



        public Player(int _id = 0, string _name="") 
        {
            this.id = _id;
            this.name = _name;
            this.positionPlayer = new Point();
        } 

        public void MovePlayer( Object? ball, DeltaPosition dp)//event handler
        {
            if (ball != null && dp != null && (ball.GetType() == typeof(Ball)))
            { 
                
                Console.WriteLine($"  player {this} has notified {dp.delta_X},{dp.delta_Y} ");

            }

        }

        public override string ToString()
        {
            return $"Player: id {this.id},  name{this.name}, position {this.positionPlayer}";
        }

    }
}
