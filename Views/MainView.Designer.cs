namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnProviders = new Button();
            BtnCategories = new Button();
            BtnProducts = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 569);
            panel1.TabIndex = 0;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = Properties.Resources.providers;
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(3, 381);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(244, 94);
            BtnProviders.TabIndex = 4;
            BtnProviders.UseVisualStyleBackColor = true;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.categories1;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(3, 297);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(244, 78);
            BtnCategories.TabIndex = 3;
            BtnCategories.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(3, 197);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(244, 94);
            BtnProducts.TabIndex = 2;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy1;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(3, 81);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(244, 110);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.exit;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Location = new Point(3, 481);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(244, 84);
            BtnExit.TabIndex = 5;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 569);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnProviders;
        private Button BtnCategories;
        private Button BtnProducts;
        private Button BtnExit;
    }
}