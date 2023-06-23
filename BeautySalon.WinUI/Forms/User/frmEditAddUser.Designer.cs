namespace BeautySalon.WinUI.Forms.User
{
    partial class frmEditAddUser
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
            panel1 = new Panel();
            lbl_Header = new Label();
            btn_Save = new Button();
            lbl_Gender = new Label();
            cmb_Gender = new ComboBox();
            tb_Address = new TextBox();
            lbl_Address = new Label();
            lbl_DateOfBirth = new Label();
            tb_FirstName = new TextBox();
            lbl_FirstName = new Label();
            tb_LastName = new TextBox();
            lbl_LastName = new Label();
            dtp_DateOfBirth = new DateTimePicker();
            tb_EmailAddress = new TextBox();
            lbl_EmailAddress = new Label();
            tb_Username = new TextBox();
            lbl_Username = new Label();
            tb_PasswordConfirmation = new TextBox();
            lbl_PasswordConfirmation = new Label();
            tb_Password = new TextBox();
            lbl_Password = new Label();
            lbl_IsActive = new Label();
            cb_IsActive = new CheckBox();
            lbl_Roles = new Label();
            clb_Roles = new CheckedListBox();
            errorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(lbl_Header);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 72);
            panel1.TabIndex = 41;
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Header.Location = new Point(12, 28);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(175, 35);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "Add New User";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.Info;
            btn_Save.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Save.Location = new Point(437, 585);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(150, 40);
            btn_Save.TabIndex = 40;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gender.Location = new Point(167, 354);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(80, 25);
            lbl_Gender.TabIndex = 39;
            lbl_Gender.Text = "Gender:";
            // 
            // cmb_Gender
            // 
            cmb_Gender.BackColor = SystemColors.Window;
            cmb_Gender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Gender.FormattingEnabled = true;
            cmb_Gender.Location = new Point(253, 348);
            cmb_Gender.Margin = new Padding(3, 4, 3, 4);
            cmb_Gender.Name = "cmb_Gender";
            cmb_Gender.Size = new Size(334, 31);
            cmb_Gender.TabIndex = 38;
            cmb_Gender.Validating += cmb_Gender_Validating;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(253, 423);
            tb_Address.Margin = new Padding(3, 4, 3, 4);
            tb_Address.Name = "tb_Address";
            tb_Address.Size = new Size(334, 30);
            tb_Address.TabIndex = 35;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Address.Location = new Point(162, 428);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(85, 25);
            lbl_Address.TabIndex = 30;
            lbl_Address.Text = "Address:";
            // 
            // lbl_DateOfBirth
            // 
            lbl_DateOfBirth.AutoSize = true;
            lbl_DateOfBirth.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DateOfBirth.Location = new Point(119, 390);
            lbl_DateOfBirth.Name = "lbl_DateOfBirth";
            lbl_DateOfBirth.Size = new Size(128, 25);
            lbl_DateOfBirth.TabIndex = 31;
            lbl_DateOfBirth.Text = "Date of Birth:";
            // 
            // tb_FirstName
            // 
            tb_FirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_FirstName.Location = new Point(253, 272);
            tb_FirstName.Margin = new Padding(3, 4, 3, 4);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(334, 30);
            tb_FirstName.TabIndex = 33;
            tb_FirstName.Validating += tb_FirstName_Validating;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.Location = new Point(136, 277);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(111, 25);
            lbl_FirstName.TabIndex = 32;
            lbl_FirstName.Text = "First Name:";
            // 
            // tb_LastName
            // 
            tb_LastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_LastName.Location = new Point(253, 310);
            tb_LastName.Margin = new Padding(3, 4, 3, 4);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(334, 30);
            tb_LastName.TabIndex = 43;
            tb_LastName.Validating += tb_LastName_Validating;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LastName.Location = new Point(139, 315);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(108, 25);
            lbl_LastName.TabIndex = 42;
            lbl_LastName.Text = "Last Name:";
            // 
            // dtp_DateOfBirth
            // 
            dtp_DateOfBirth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_DateOfBirth.Location = new Point(253, 386);
            dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            dtp_DateOfBirth.Size = new Size(334, 30);
            dtp_DateOfBirth.TabIndex = 44;
            // 
            // tb_EmailAddress
            // 
            tb_EmailAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_EmailAddress.Location = new Point(253, 158);
            tb_EmailAddress.Margin = new Padding(3, 4, 3, 4);
            tb_EmailAddress.Name = "tb_EmailAddress";
            tb_EmailAddress.Size = new Size(334, 30);
            tb_EmailAddress.TabIndex = 46;
            tb_EmailAddress.Validating += tb_EmailAddress_Validating;
            // 
            // lbl_EmailAddress
            // 
            lbl_EmailAddress.AutoSize = true;
            lbl_EmailAddress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EmailAddress.Location = new Point(110, 163);
            lbl_EmailAddress.Name = "lbl_EmailAddress";
            lbl_EmailAddress.Size = new Size(137, 25);
            lbl_EmailAddress.TabIndex = 45;
            lbl_EmailAddress.Text = "Email Address:";
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Username.Location = new Point(253, 120);
            tb_Username.Margin = new Padding(3, 4, 3, 4);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(334, 30);
            tb_Username.TabIndex = 48;
            tb_Username.Validating += tb_Username_Validating;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Username.Location = new Point(144, 125);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(103, 25);
            lbl_Username.TabIndex = 47;
            lbl_Username.Text = "Username:";
            // 
            // tb_PasswordConfirmation
            // 
            tb_PasswordConfirmation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_PasswordConfirmation.Location = new Point(253, 234);
            tb_PasswordConfirmation.Margin = new Padding(3, 4, 3, 4);
            tb_PasswordConfirmation.Name = "tb_PasswordConfirmation";
            tb_PasswordConfirmation.Size = new Size(334, 30);
            tb_PasswordConfirmation.TabIndex = 50;
            tb_PasswordConfirmation.UseSystemPasswordChar = true;
            tb_PasswordConfirmation.Validating += tb_PasswordConfirmation_Validating;
            // 
            // lbl_PasswordConfirmation
            // 
            lbl_PasswordConfirmation.AutoSize = true;
            lbl_PasswordConfirmation.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_PasswordConfirmation.Location = new Point(32, 239);
            lbl_PasswordConfirmation.Name = "lbl_PasswordConfirmation";
            lbl_PasswordConfirmation.Size = new Size(215, 25);
            lbl_PasswordConfirmation.TabIndex = 49;
            lbl_PasswordConfirmation.Text = "Password Confirmation:";
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.Location = new Point(253, 196);
            tb_Password.Margin = new Padding(3, 4, 3, 4);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(334, 30);
            tb_Password.TabIndex = 52;
            tb_Password.UseSystemPasswordChar = true;
            tb_Password.Validating += tb_Password_Validating;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.Location = new Point(151, 201);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(96, 25);
            lbl_Password.TabIndex = 51;
            lbl_Password.Text = "Password:";
            // 
            // lbl_IsActive
            // 
            lbl_IsActive.AutoSize = true;
            lbl_IsActive.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IsActive.Location = new Point(157, 467);
            lbl_IsActive.Name = "lbl_IsActive";
            lbl_IsActive.Size = new Size(90, 25);
            lbl_IsActive.TabIndex = 53;
            lbl_IsActive.Text = "Is Active:";
            // 
            // cb_IsActive
            // 
            cb_IsActive.AutoSize = true;
            cb_IsActive.Location = new Point(253, 474);
            cb_IsActive.Name = "cb_IsActive";
            cb_IsActive.Size = new Size(18, 17);
            cb_IsActive.TabIndex = 54;
            cb_IsActive.UseVisualStyleBackColor = true;
            // 
            // lbl_Roles
            // 
            lbl_Roles.AutoSize = true;
            lbl_Roles.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Roles.Location = new Point(183, 511);
            lbl_Roles.Name = "lbl_Roles";
            lbl_Roles.Size = new Size(62, 25);
            lbl_Roles.TabIndex = 55;
            lbl_Roles.Text = "Roles:";
            // 
            // clb_Roles
            // 
            clb_Roles.FormattingEnabled = true;
            clb_Roles.Location = new Point(251, 511);
            clb_Roles.Name = "clb_Roles";
            clb_Roles.Size = new Size(150, 114);
            clb_Roles.TabIndex = 56;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // frmEditAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(749, 669);
            Controls.Add(clb_Roles);
            Controls.Add(lbl_Roles);
            Controls.Add(cb_IsActive);
            Controls.Add(lbl_IsActive);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Password);
            Controls.Add(tb_PasswordConfirmation);
            Controls.Add(lbl_PasswordConfirmation);
            Controls.Add(tb_Username);
            Controls.Add(lbl_Username);
            Controls.Add(tb_EmailAddress);
            Controls.Add(lbl_EmailAddress);
            Controls.Add(dtp_DateOfBirth);
            Controls.Add(tb_LastName);
            Controls.Add(lbl_LastName);
            Controls.Add(panel1);
            Controls.Add(btn_Save);
            Controls.Add(lbl_Gender);
            Controls.Add(cmb_Gender);
            Controls.Add(tb_Address);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_DateOfBirth);
            Controls.Add(tb_FirstName);
            Controls.Add(lbl_FirstName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditAddUser";
            Text = "frmEditAddUser";
            Load += frmEditAddUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_Header;
        private Button btn_Save;
        private Label lbl_Gender;
        private ComboBox cmb_Gender;
        private TextBox tb_Address;
        private Label lbl_Address;
        private Label lbl_DateOfBirth;
        private TextBox tb_FirstName;
        private Label lbl_FirstName;
        private TextBox tb_LastName;
        private Label lbl_LastName;
        private DateTimePicker dtp_DateOfBirth;
        private TextBox tb_EmailAddress;
        private Label lbl_EmailAddress;
        private TextBox tb_Username;
        private Label lbl_Username;
        private TextBox tb_PasswordConfirmation;
        private Label lbl_PasswordConfirmation;
        private TextBox tb_Password;
        private Label lbl_Password;
        private Label lbl_IsActive;
        private CheckBox cb_IsActive;
        private Label lbl_Roles;
        private CheckedListBox clb_Roles;
        private ErrorProvider errorProvider;
    }
}