namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbAuthor = new ComboBox();
            GroupBox = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            cbCarName = new ComboBox();
            tbReport = new TextBox();
            btReportOpen = new Button();
            btReportSave = new Button();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            ofdPicFileOpen = new OpenFileDialog();
            ssMassageArea = new StatusStrip();
            tslbMassage = new ToolStripStatusLabel();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ssMassageArea.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F);
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Yu Gothic UI", 12F);
            dtpDate.Font = new Font("Yu Gothic UI", 12F);
            dtpDate.Location = new Point(80, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(194, 29);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F);
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 2;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F);
            label3.Location = new Point(21, 116);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F);
            label4.Location = new Point(32, 167);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 4;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 12F);
            label5.Location = new Point(19, 216);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 5;
            label5.Text = "レポート";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 12F);
            label6.Location = new Point(32, 347);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 6;
            label6.Text = "一覧";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 12F);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(80, 60);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(296, 29);
            cbAuthor.TabIndex = 7;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(rbOther);
            GroupBox.Controls.Add(rbImport);
            GroupBox.Controls.Add(rbSubaru);
            GroupBox.Controls.Add(rbHonda);
            GroupBox.Controls.Add(rbNissan);
            GroupBox.Controls.Add(rbToyota);
            GroupBox.Location = new Point(80, 104);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(368, 37);
            GroupBox.TabIndex = 8;
            GroupBox.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(302, 11);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 5;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(235, 12);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 4;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(175, 11);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(116, 12);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 2;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(61, 12);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 1;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(5, 11);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 12F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(80, 164);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(296, 29);
            cbCarName.TabIndex = 9;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(80, 216);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(368, 116);
            tbReport.TabIndex = 10;
            // 
            // btReportOpen
            // 
            btReportOpen.Font = new Font("Yu Gothic UI", 12F);
            btReportOpen.Location = new Point(14, 421);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(60, 30);
            btReportOpen.TabIndex = 11;
            btReportOpen.Text = "開く...";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 12F);
            btReportSave.Location = new Point(14, 457);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(60, 30);
            btReportSave.TabIndex = 12;
            btReportSave.Text = "保存...";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(581, 30);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(61, 24);
            btPicOpen.TabIndex = 13;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(648, 30);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(61, 24);
            btPicDelete.TabIndex = 14;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(192, 255, 255);
            pbPicture.Location = new Point(478, 60);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(231, 228);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 16;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.Font = new Font("Yu Gothic UI", 12F);
            btAddReport.Location = new Point(478, 302);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(65, 30);
            btAddReport.TabIndex = 17;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.Font = new Font("Yu Gothic UI", 12F);
            btModifyReport.Location = new Point(562, 302);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(65, 30);
            btModifyReport.TabIndex = 18;
            btModifyReport.Text = "修正";
            btModifyReport.TextAlign = ContentAlignment.BottomCenter;
            btModifyReport.UseVisualStyleBackColor = true;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Font = new Font("Yu Gothic UI", 12F);
            btDeleteReport.Location = new Point(644, 302);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(65, 30);
            btDeleteReport.TabIndex = 19;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(478, 30);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 20;
            label7.Text = "画像";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(80, 354);
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(629, 133);
            dgvCarReport.TabIndex = 21;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ssMassageArea
            // 
            ssMassageArea.Items.AddRange(new ToolStripItem[] { tslbMassage });
            ssMassageArea.Location = new Point(0, 497);
            ssMassageArea.Name = "ssMassageArea";
            ssMassageArea.Size = new Size(726, 22);
            ssMassageArea.TabIndex = 22;
            ssMassageArea.Text = "statusStrip1";
            // 
            // tslbMassage
            // 
            tslbMassage.Name = "tslbMassage";
            tslbMassage.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 519);
            Controls.Add(ssMassageArea);
            Controls.Add(dgvCarReport);
            Controls.Add(label7);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btPicOpen);
            Controls.Add(btReportSave);
            Controls.Add(btReportOpen);
            Controls.Add(tbReport);
            Controls.Add(cbCarName);
            Controls.Add(GroupBox);
            Controls.Add(cbAuthor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "試乗レポート管理システム";
            Load += Form1_Load;
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ssMassageArea.ResumeLayout(false);
            ssMassageArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbAuthor;
        private GroupBox GroupBox;
        private RadioButton rbToyota;
        private ComboBox cbCarName;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbOther;
        private TextBox tbReport;
        private Button btReportOpen;
        private Button btReportSave;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarReport;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMassageArea;
        private ToolStripStatusLabel tslbMassage;
    }
}
