namespace BallApp {
    internal class Bar : Obj {

        public Bar(double xp, double yp)
            : base(xp, yp, @"Picture\bar.png") {

            MoveX = 10;
            MoveY = 0;

        }
        public override bool Move() {
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
