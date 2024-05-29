
namespace BallApp {
    internal class SoccerBall : Obj {
        public static int Count { get; set; }

        Random random = new Random();

        public SoccerBall(double xp, double yp)
            : base(xp, yp, @"Picture\soccer_ball.png") {

            MoveX = random.Next(-25, 25);
            MoveY = random.Next(-25, 25);

            Count++;
        }

        //戻り値：０…移動OK、１…落下した、２…バーに当たった
        public override int Move(PictureBox pbBar, PictureBox pbBall) {
            int ret = 0;
            Rectangle rBar = new Rectangle
                    (pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle
                    (pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);


            if (PosX > 750 || PosX < 0) {
                MoveX = -MoveX;
            }

            //バーに当たったかの判定
            if (PosY < 0 || rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
            }

            //バーに当たった
            if (rBar.IntersectsWith(rBall)) {
                MoveY = -MoveY;
                ret = 2;
            }

            PosX += MoveX;
            PosY += MoveY;

            //落下した
            if (PosY > 500) 
                ret = 1;

            //移動完了
            return ret;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
