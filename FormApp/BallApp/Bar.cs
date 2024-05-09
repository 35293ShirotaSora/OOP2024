namespace BallApp {
    internal class Bar : Obj {

        public Bar(double xp, double yp)
            : base(xp, yp, @"Picture\bar.png") {

            MoveX = 10;
            MoveY = 0;

        }
        public override bool Move(PictureBox pbBar, PictureBox pbBall) {
            Rectangle rBar = new Rectangle
                (pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle
                (pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            return true;
        }

        public override bool Move(Keys direction) {
            if (direction == Keys.Right) {
                if (PosX < 635) {
                    PosX += MoveX;
                }
            } else if (direction == Keys.Left) {
                if (PosX > 0) {
                    PosX -= MoveX;
                }
            }
            return true;
        }
    }
}
