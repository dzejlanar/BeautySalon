namespace BeautySalon.WinUI.Forms.Service
{
    partial class frmAddService
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
            components = new System.ComponentModel.Container();
            lbl_Header = new Label();
            lbl_Name = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            txtDuration = new TextBox();
            label2 = new Label();
            rtbDescription = new RichTextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Header.Location = new Point(12, 28);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(209, 35);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "Add New Service";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Name.Location = new Point(93, 95);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(69, 25);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(168, 96);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(334, 27);
            txtName.TabIndex = 20;
            txtName.Validating += txtName_Validating;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(168, 376);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(334, 27);
            txtPrice.TabIndex = 22;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 375);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Price:";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuration.Location = new Point(168, 437);
            txtDuration.Margin = new Padding(3, 4, 3, 4);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(334, 27);
            txtDuration.TabIndex = 23;
            txtDuration.Validating += txtDuration_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(69, 436);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 0;
            label2.Text = "Duration:";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(170, 147);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(332, 137);
            rtbDescription.TabIndex = 24;
            rtbDescription.Text = "";
            rtbDescription.Validating += txtDescription_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 147);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 25;
            label3.Text = "Description:";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Window;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 318);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(334, 28);
            cmbCategory.TabIndex = 26;
            cmbCategory.Validating += cmbCategory_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 318);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 27;
            label4.Text = "Category:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(352, 500);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(lbl_Header);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 72);
            panel1.TabIndex = 29;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmAddService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(749, 575);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(rtbDescription);
            Controls.Add(txtDuration);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lbl_Name);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAddService";
            Text = "frmAddService";
            Load += frmAddService_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Header;
        private Label lbl_Name;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label label1;
        private TextBox txtDuration;
        private Label label2;
        private RichTextBox rtbDescription;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private Button btnSave;
        private Panel panel1;
        private ErrorProvider errorProvider;
    }
}