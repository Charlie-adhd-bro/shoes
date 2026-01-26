namespace shoes
{
    partial class FormOrders
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
            dgvOrders = new DataGridView();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
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
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(10, 44);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(635, 315);
            dgvOrders.TabIndex = 2;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 369);
            Controls.Add(dgvOrders);
            Controls.Add(pnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MinimumSize = new Size(671, 408);
            Name = "FormOrders";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private DataGridView dgvOrders;
        private Label lblUserName;
        private Button btnLogut;
    }
}
