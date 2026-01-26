namespace shoes
{
    partial class FormSelection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogut = new Button();
            lblUserName = new Label();
            pnMain = new Panel();
            panel1 = new Panel();
            btnProducts = new Button();
            btnOrders = new Button();
            pnMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogut
            // 
            btnLogut.AutoSize = true;
            btnLogut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogut.BackColor = Color.MediumSpringGreen;
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(260, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(62, 38);
            btnLogut.TabIndex = 7;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogout_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(215, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(lblUserName);
            pnMain.Controls.Add(btnLogut);
            pnMain.Dock = DockStyle.Top;
            pnMain.Location = new Point(10, 10);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(322, 38);
            pnMain.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(btnProducts);
            panel1.Controls.Add(btnOrders);
            panel1.Location = new Point(21, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 245);
            panel1.TabIndex = 4;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.MediumSpringGreen;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(70, 130);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(173, 30);
            btnProducts.TabIndex = 5;
            btnProducts.Text = "Товары";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += BtnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.MediumSpringGreen;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Location = new Point(70, 75);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(173, 30);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "Заказы";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += BtnOrders_Click;
            // 
            // FormSelection
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(342, 303);
            Controls.Add(panel1);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MinimumSize = new Size(358, 342);
            Name = "FormSelection";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogut;
        private Label lblUserName;
        private Panel pnMain;
        private Panel panel1;
        private Button btnGuest;
        private Button btnOrders;
        private Button btnProducts;
    }
}
