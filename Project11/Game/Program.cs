namespace Game
{
    internal class Program
    {
         public static void StartGame()
        {
            Ball b1 = new Ball();
            Ball b2 = new Ball();    

            Player p1 = new Player( 11, "M.salah");
            Player p2 = new Player(24, "M.trezegea");
            Player p3 = new Player(10, "M.shenawy");
            Player p4 = new Player(6, "Marmoush");

            Frere f1= new Frere( 202, "Wael");

            b1.MoveBallPosition(19, 15);
            b1.OnBallchangedPosition += p1.MovePlayer;
            b1.OnBallchangedPosition += p2.MovePlayer;
            b1.OnBallchangedPosition += p3.MovePlayer;
            b1.OnBallchangedPosition += f1.MoveFrere;

            b1.OnBallchangedPosition -= p1.MovePlayer;
            b1.OnBallchangedPosition -= f1.MoveFrere;

            b1.MoveBallPosition(20, 16);
            b1.OnBallchangedPosition += p4.MovePlayer;
            


        }



         public static void Main(string[] args)
        {
            StartGame();
        }
    }
}
