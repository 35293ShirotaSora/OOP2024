
namespace BallApp {
    internal class TennisBall : Obj {
        public static int Count { get; set; }

        Random random = new Random();

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png"){

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

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
