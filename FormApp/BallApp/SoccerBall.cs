namespace BallApp {
    internal class SoccerBall : Obj {
        public static int Count { get; set; }

        Random random = new Random();

        public SoccerBall(double xp, double yp)
            : base(xp, yp, @"Picture\soccer_ball.png"){

            MoveX = random.Next(-25, 25);
            MoveY = random.Next(-25, 25);

            Count++;
        }

        public override bool Move() {
            if (PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }
            if (PosY > 500 || PosY < 0) {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;

            return true;
        }
    }
}
