namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnSearch = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(45, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(251, 21);
            label1.Name = "label1";
            label1.Size = new Size(331, 89);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 441);
            tabControl1.TabIndex = 2;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(839, 408);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search11;
            BtnSearch.Location = new Point(546, 26);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(69, 50);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(689, 320);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(96, 62);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(689, 236);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(96, 67);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(689, 161);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(96, 69);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += button2_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(689, 92);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(96, 63);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(6, 82);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(607, 300);
            DgPayMode.TabIndex = 3;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(525, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(839, 408);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(128, 338);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(97, 46);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(18, 338);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(85, 46);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(18, 129);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(301, 27);
            TxtPayModeName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 204);
            label5.Name = "label5";
            label5.Size = new Size(149, 17);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(18, 235);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(301, 86);
            TxtPayModeObservation.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 109);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(18, 39);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(195, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            label3.Click += label3_Click;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 566);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtPayModeId;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeName;
        private Label label5;
        private TextBox TxtPayModeObservation;
        private Label label4;
    }
}