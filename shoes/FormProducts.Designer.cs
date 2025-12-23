namespace shoes
{
    partial class FormProducts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnMain = new Panel();
            lblUserName = new Label();
            btnLogut = new Button();
            dgvProducts = new DataGridView();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(lblUserName);
            pnMain.Controls.Add(btnLogut);
            pnMain.Dock = DockStyle.Top;
            pnMain.Location = new Point(10, 10);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(635, 34);
            pnMain.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(528, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(45, 19);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogut
            // 
            btnLogut.AutoSize = true;
            btnLogut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogut.BackColor = Color.MediumSpringGreen;
            btnLogut.Dock = DockStyle.Right;
            btnLogut.FlatAppearance.BorderSize = 0;
            btnLogut.FlatStyle = FlatStyle.Flat;
            btnLogut.Location = new Point(573, 0);
            btnLogut.Name = "btnLogut";
            btnLogut.Size = new Size(62, 34);
            btnLogut.TabIndex = 7;
            btnLogut.Text = "Выход";
            btnLogut.UseVisualStyleBackColor = false;
            btnLogut.Click += BtnLogut_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(10, 44);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(635, 315);
            dgvProducts.TabIndex = 1;
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 369);
            Controls.Add(dgvProducts);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(315, 408);
            Name = "FormProducts";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список товаров";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private DataGridView dgvProducts;
        private Label lblUserName;
        private Button btnLogut;
    }
}
