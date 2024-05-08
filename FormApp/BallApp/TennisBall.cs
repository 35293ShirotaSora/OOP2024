﻿namespace BallApp {
    internal class TennisBall : Obj {

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png"){

            MoveX = 10;
            MoveY = 10;
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
