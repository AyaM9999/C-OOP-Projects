using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Game
{
     public class Ball // publisher
    {
        Point position;

        public event  EventHandler <DeltaPosition> OnBallchangedPosition;    // define event
        public Point Get()
        {
            return position;
        }
        public Ball() 
        {
            this.position = position;   
        }
        public void MoveBallPosition(int xIncrease, int yIncrease) 
        {
            DeltaPosition dp = new DeltaPosition() { delta_X = xIncrease, delta_Y= yIncrease };
            position.x_axis += xIncrease;
            position.y_axis += yIncrease;
            OnBallchangedPosition.Invoke(this,dp);  //fire event
                                                               }
    }
}
