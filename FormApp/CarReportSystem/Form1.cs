using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport() {
                Date = dtpDate.Value,
                Auther = cbAuter.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            listCarReports.Add(carReport);

        }

        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked == true) 
                return CarReport.MakerGroup.�g���^;
            if (rbNissan.Checked == true)
                return CarReport.MakerGroup.���Y;
            if (rbHonda.Checked == true)
                return CarReport.MakerGroup.�z���_;
            if (rbSubaru.Checked == true)
                return CarReport.MakerGroup.�X�o��;
            if (rbImport.Checked == true)
                return CarReport.MakerGroup.�A����;
            return CarReport.MakerGroup.���̑�;
        }

        
    }
}
