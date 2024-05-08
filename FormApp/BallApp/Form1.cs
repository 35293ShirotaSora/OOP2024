namespace BallApp {
    public partial class Form1 : Form {
        //List�R���N�V����
        private List<Obj> balls = new List<Obj>();  //�{�[���C���X�^���X�i�[�p
        private List<PictureBox> pbs = new List<PictureBox>();  //�\���p

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
        }

        //�t�H�[�����ŏ��Ƀ��[�h���ꂽ�Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            //ball.Move();
            //pb.Location = new Point((int)ball.PosX, (int)ball.PosY);

            for (int i = 0; i < balls.Count; i++) {
                balls[i].Move();
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            PictureBox pb = new PictureBox(); //�摜�\��
            Obj ball = null;

            if (e.Button == MouseButtons.Left) {
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X - 25, e.Y - 25);
            } else if (e.Button == MouseButtons.Right) {
                pb.Size = new Size(20, 20);
                ball = new TennisBall(e.X - 12, e.Y - 12);
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);
        }
    }
}
