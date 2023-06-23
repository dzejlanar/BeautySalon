namespace BeautySalon.WinUI.Forms.Service
{
    partial class frmServiceList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvServices = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ActionBtn = new DataGridViewButtonColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            tb_Search = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 0;
            label1.Text = "SERVICES";
            // 
            // dgvServices
            // 
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;
            dgvServices.AllowUserToResizeColumns = false;
            dgvServices.AllowUserToResizeRows = false;
            dgvServices.BackgroundColor = SystemColors.ControlLightLight;
            dgvServices.ColumnHeadersHeight = 40;
            dgvServices.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, ActionBtn });
            dgvServices.Location = new Point(25, 161);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(683, 316);
            dgvServices.TabIndex = 1;
            dgvServices.CellContentClick += dgvServices_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewTextBoxColumn3.HeaderText = "Price";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn3.Width = 130;
            // 
            // ActionBtn
            // 
            ActionBtn.DataPropertyName = "(none)";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ActionBtn.DefaultCellStyle = dataGridViewCellStyle1;
            ActionBtn.FlatStyle = FlatStyle.Flat;
            ActionBtn.HeaderText = "Edit";
            ActionBtn.MinimumWidth = 6;
            ActionBtn.Name = "ActionBtn";
            ActionBtn.ReadOnly = true;
            ActionBtn.Text = "Edit";
            ActionBtn.UseColumnTextForButtonValue = true;
            ActionBtn.Width = 125;
            // 
            // ServiceName
            // 
            ServiceName.HeaderText = "Name";
            ServiceName.MinimumWidth = 6;
            ServiceName.Name = "ServiceName";
            ServiceName.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(567, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Service";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tb_Search
            // 
            tb_Search.Location = new Point(25, 117);
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Search";
            tb_Search.Size = new Size(190, 27);
            tb_Search.TabIndex = 3;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 91);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 4;
            label2.Text = "Search by name:";
            // 
            // frmServiceList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(736, 504);
            Controls.Add(label2);
            Controls.Add(tb_Search);
            Controls.Add(btnAdd);
            Controls.Add(dgvServices);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmServiceList";
            Text = "frmServiceList";
            Load += frmServiceList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvServices;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn Price;
        private Button btnAdd;
        private TextBox tb_Search;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn ActionBtn;
    }
}