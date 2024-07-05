using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing.Text;

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
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tslbMassage.Text = "�L�^�ҁA�܂��͎Ԗ������͂���Ă��܂���";
                return;
            }

            CarReport carReport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            listCarReports.Add(carReport);

            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            ClearMethod();

            dgvCarReport.ClearSelection();

        }

        private void ClearMethod() {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = string.Empty;
            setRadioButtonMaker(CarReport.MakerGroup.�Ȃ�);
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;
        }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.���Y;
            if (rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;
            if (rbImport.Checked)
                return CarReport.MakerGroup.�A����;
            return CarReport.MakerGroup.���̑�;
        }

        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�Ȃ�:
                    rbAllClear();
                    break;
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void rbAllClear() {
            rbToyota.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbImport.Checked = false;
            rbNissan.Checked = false;
            rbOther.Checked = false;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false;
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {
            if ((dgvCarReport.Rows.Count == 0)||(!dgvCarReport.CurrentRow.Selected))
                return;

            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["Picture"].Value;
        }

        //�폜�{�^��
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) {
                tslbMassage.Text = "�f�[�^�����͂���Ă��܂���";
                return;
            }
            if (!dgvCarReport.CurrentRow.Selected) {
                return;
            }

            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
            ClearMethod();
        }

        //�C���{�^��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) {
                tslbMassage.Text = "�f�[�^�����͂���Ă��܂���";
                return;
            }
            if (!dgvCarReport.CurrentRow.Selected) {
                return;
            }
            
            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tslbMassage.Text = "�L�^�ҁA�Ԗ�����͂��Ă�������";
                return;
            }

            dgvCarReport.Refresh();

        }

        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tslbMassage.Text = "";
        }

        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMassage.Text = "";
        }
    }
}
