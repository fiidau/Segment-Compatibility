namespace Segment_Compatibility
{
    partial class SegmentVerifierFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegmentVerifierFrm));
            this.cb_Chr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Start = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_End = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.cb_Company = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cb_MCompany = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.snps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kit_version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOutput = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Overlap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Chr
            // 
            this.cb_Chr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Chr.FormattingEnabled = true;
            this.cb_Chr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "X"});
            this.cb_Chr.Location = new System.Drawing.Point(209, 148);
            this.cb_Chr.Name = "cb_Chr";
            this.cb_Chr.Size = new System.Drawing.Size(63, 21);
            this.cb_Chr.TabIndex = 0;
            this.cb_Chr.SelectedIndexChanged += new System.EventHandler(this.cb_Chr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(206, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chromosome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(292, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // tb_Start
            // 
            this.tb_Start.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Start.Location = new System.Drawing.Point(292, 148);
            this.tb_Start.Name = "tb_Start";
            this.tb_Start.Size = new System.Drawing.Size(123, 23);
            this.tb_Start.TabIndex = 3;
            this.tb_Start.Text = "0";
            this.tb_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(289, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(432, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "End Position";
            // 
            // tb_End
            // 
            this.tb_End.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_End.Location = new System.Drawing.Point(435, 148);
            this.tb_End.Name = "tb_End";
            this.tb_End.Size = new System.Drawing.Size(123, 23);
            this.tb_End.TabIndex = 4;
            this.tb_End.Text = "0";
            this.tb_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Verify
            // 
            this.btn_Verify.Image = global::Segment_Compatibility.Properties.Resources.check;
            this.btn_Verify.Location = new System.Drawing.Point(420, 236);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(138, 38);
            this.btn_Verify.TabIndex = 5;
            this.btn_Verify.Text = "Check Compatibility";
            this.btn_Verify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // cb_Company
            // 
            this.cb_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Company.FormattingEnabled = true;
            this.cb_Company.Items.AddRange(new object[] {
            "23andMe V2",
            "23andMe V3",
            "23andMe V4",
            "Ancestry",
            "FTDNA Affymetrix",
            "FTDNA Illumina"});
            this.cb_Company.Location = new System.Drawing.Point(15, 148);
            this.cb_Company.Name = "cb_Company";
            this.cb_Company.Size = new System.Drawing.Size(174, 21);
            this.cb_Company.TabIndex = 6;
            this.cb_Company.SelectedIndexChanged += new System.EventHandler(this.cb_Company_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Your Kit Version";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(574, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(38, 17);
            this.statusLbl.Text = "Done.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.Gray;
            this.lbl_min.Location = new System.Drawing.Point(292, 174);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(36, 13);
            this.lbl_min.TabIndex = 8;
            this.lbl_min.Text = "Min: 0";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.ForeColor = System.Drawing.Color.Gray;
            this.lbl_max.Location = new System.Drawing.Point(432, 174);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(88, 13);
            this.lbl_max.TabIndex = 9;
            this.lbl_max.Text = "Max: 300000000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // cb_MCompany
            // 
            this.cb_MCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MCompany.FormattingEnabled = true;
            this.cb_MCompany.Items.AddRange(new object[] {
            "23andMe V2",
            "23andMe V3",
            "23andMe V4",
            "Ancestry",
            "FTDNA Affymetrix",
            "FTDNA Illumina"});
            this.cb_MCompany.Location = new System.Drawing.Point(15, 212);
            this.cb_MCompany.Name = "cb_MCompany";
            this.cb_MCompany.Size = new System.Drawing.Size(174, 21);
            this.cb_MCompany.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Match\'s Kit Version";
            // 
            // snps
            // 
            this.snps.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.snps.HeaderText = "SNP Count in Segment";
            this.snps.Name = "snps";
            this.snps.ReadOnly = true;
            // 
            // kit_version
            // 
            this.kit_version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kit_version.HeaderText = "Testing Company / Kit Version";
            this.kit_version.Name = "kit_version";
            this.kit_version.ReadOnly = true;
            // 
            // dgOutput
            // 
            this.dgOutput.AllowUserToAddRows = false;
            this.dgOutput.AllowUserToDeleteRows = false;
            this.dgOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kit_version,
            this.snps});
            this.dgOutput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgOutput.Location = new System.Drawing.Point(15, 290);
            this.dgOutput.MultiSelect = false;
            this.dgOutput.Name = "dgOutput";
            this.dgOutput.ReadOnly = true;
            this.dgOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOutput.ShowEditingIcon = false;
            this.dgOutput.Size = new System.Drawing.Size(543, 179);
            this.dgOutput.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(15, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "Overlapping SNPs / SNPs available to compare between you and your match";
            // 
            // lbl_Overlap
            // 
            this.lbl_Overlap.AutoSize = true;
            this.lbl_Overlap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Overlap.Location = new System.Drawing.Point(239, 502);
            this.lbl_Overlap.Name = "lbl_Overlap";
            this.lbl_Overlap.Size = new System.Drawing.Size(18, 20);
            this.lbl_Overlap.TabIndex = 15;
            this.lbl_Overlap.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 117);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 98);
            this.label8.TabIndex = 0;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(514, 534);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "y-str.org";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Gray;
            // 
            // btnDownload
            // 
            this.btnDownload.Image = global::Segment_Compatibility.Properties.Resources.download;
            this.btnDownload.Location = new System.Drawing.Point(370, 484);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(188, 38);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download Detailed Information";
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "=";
            // 
            // SegmentVerifierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 583);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_Overlap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_MCompany);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dgOutput);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cb_Company);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.tb_End);
            this.Controls.Add(this.tb_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Chr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SegmentVerifierFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segment Compatibility Checker";
            this.Load += new System.EventHandler(this.SegmentVerifierFrm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Chr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_End;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.ComboBox cb_Company;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cb_MCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn snps;
        private System.Windows.Forms.DataGridViewTextBoxColumn kit_version;
        private System.Windows.Forms.DataGridView dgOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Overlap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

