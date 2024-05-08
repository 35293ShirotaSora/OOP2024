namespace BallApp {
    public partial class Form1 : Form {
        private double posX;
        private double posY;
        private double moveX;
        private double moveY;

        //コンストラクタ
        public Form1() {
            InitializeComponent();

            moveX = moveY = 10;
        }

        //フォームが最初にロードされたとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            //this.BackColor = Color.Aquamarine;
            timer1.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e) {
            this.Text = pbBall.Location.ToString();

            if (pbBall.Location.X > 750 || pbBall.Location.X < 0) {
                moveX = -moveX;
            }

            if (pbBall.Location.Y > 500 || pbBall.Location.Y < 0) {
                moveY = -moveY;
            }

            posX += moveX;
            posY += moveY;

            pbBall.Location = new Point((int)posX, (int)posY);
        }

        private void Timer1_Tick(object sender, EventArgs e) {

        }
    }
}
