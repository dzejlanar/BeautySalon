namespace BeautySalon.WinUI.Forms.User
{
    partial class frmUserList
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
            tb_Search = new TextBox();
            btnAdd = new Button();
            dgvUsers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            rb_Name = new RadioButton();
            rb_Email = new RadioButton();
            gb_Search = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gb_Search.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Search
            // 
            tb_Search.Location = new Point(52, 137);
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Search";
            tb_Search.Size = new Size(226, 27);
            tb_Search.TabIndex = 8;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Info;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(594, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 44);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = SystemColors.ControlLightLight;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, IsActive });
            dgvUsers.Location = new Point(52, 175);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(683, 299);
            dgvUsers.TabIndex = 6;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            dataGridViewTextBoxColumn1.HeaderText = "Email Address";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 210;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            dataGridViewTextBoxColumn2.HeaderText = "Username";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FirstAndLastName";
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn3.Width = 195;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "Active";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(52, 17);
            label1.Name = "label1";
            label1.Size = new Size(96, 38);
            label1.TabIndex = 5;
            label1.Text = "USERS";
            // 
            // rb_Name
            // 
            rb_Name.AutoSize = true;
            rb_Name.Checked = true;
            rb_Name.Location = new Point(6, 28);
            rb_Name.Name = "rb_Name";
            rb_Name.Size = new Size(70, 24);
            rb_Name.TabIndex = 10;
            rb_Name.TabStop = true;
            rb_Name.Text = "Name";
            rb_Name.UseVisualStyleBackColor = true;
            rb_Name.CheckedChanged += rb_Name_CheckedChanged;
            // 
            // rb_Email
            // 
            rb_Email.AutoSize = true;
            rb_Email.Location = new Point(93, 28);
            rb_Email.Name = "rb_Email";
            rb_Email.Size = new Size(124, 24);
            rb_Email.TabIndex = 11;
            rb_Email.Text = "Email Address";
            rb_Email.UseVisualStyleBackColor = true;
            rb_Email.CheckedChanged += rb_Email_CheckedChanged;
            // 
            // gb_Search
            // 
            gb_Search.Controls.Add(rb_Email);
            gb_Search.Controls.Add(rb_Name);
            gb_Search.Location = new Point(52, 74);
            gb_Search.Name = "gb_Search";
            gb_Search.Size = new Size(226, 58);
            gb_Search.TabIndex = 12;
            gb_Search.TabStop = false;
            gb_Search.Text = "Search by:";
            // 
            // frmUserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(gb_Search);
            Controls.Add(tb_Search);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUserList";
            Text = "frmUserList";
            Load += frmUserList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gb_Search.ResumeLayout(false);
            gb_Search.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Search;
        private Button btnAdd;
        private DataGridView dgvUsers;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn IsActive;
        private RadioButton rb_Name;
        private RadioButton rb_Email;
        private GroupBox gb_Search;
    }
}