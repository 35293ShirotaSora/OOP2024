using System.Windows.Forms;

namespace BallApp {
    public partial class Form1 : Form {
        SoccerBall soccerBall;
        PictureBox pb;

        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        //フォームが最初にロードされたとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            pb = new PictureBox(); //画像表示
            pb.Size = new Size(50,50);

            soccerBall = new SoccerBall(e.Location.X, e.Location.Y);

            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX,(int)soccerBall.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;

            timer1.Start();

        }
    }
}
