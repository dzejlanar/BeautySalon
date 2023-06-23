namespace BeautySalon.WinUI.Forms
{
    partial class frmParent
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
            leftPanel = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnUsers = new Button();
            btnTransactions = new Button();
            btnReservations = new Button();
            btnServices = new Button();
            label1 = new Label();
            rightPanel = new Panel();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftPanel.BackColor = SystemColors.Info;
            leftPanel.Controls.Add(btnLogout);
            leftPanel.Controls.Add(btnReports);
            leftPanel.Controls.Add(btnUsers);
            leftPanel.Controls.Add(btnTransactions);
            leftPanel.Controls.Add(btnReservations);
            leftPanel.Controls.Add(btnServices);
            leftPanel.Controls.Add(label1);
            leftPanel.Location = new Point(1, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(253, 595);
            leftPanel.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ControlText;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 555);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(248, 35);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReports.ForeColor = SystemColors.ControlText;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 298);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(248, 52);
            btnReports.TabIndex = 5;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUsers.ForeColor = SystemColors.ControlText;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 240);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(250, 52);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTransactions.ForeColor = SystemColors.ControlText;
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(0, 182);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(250, 52);
            btnTransactions.TabIndex = 3;
            btnTransactions.Text = "Transactions";
            btnTransactions.TextAlign = ContentAlignment.MiddleLeft;
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnReservations
            // 
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnReservations.ForeColor = SystemColors.ControlText;
            btnReservations.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservations.Location = new Point(0, 124);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(250, 52);
            btnReservations.TabIndex = 2;
            btnReservations.Text = "Reservations";
            btnReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnReservations.UseVisualStyleBackColor = false;
            btnReservations.Click += btnReservations_Click;
            // 
            // btnServices
            // 
            btnServices.FlatAppearance.BorderSize = 0;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnServices.ForeColor = SystemColors.ControlText;
            btnServices.ImageAlign = ContentAlignment.MiddleLeft;
            btnServices.Location = new Point(0, 66);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(250, 52);
            btnServices.TabIndex = 1;
            btnServices.Text = "Services";
            btnServices.TextAlign = ContentAlignment.MiddleLeft;
            btnServices.UseVisualStyleBackColor = false;
            btnServices.Click += btnServices_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 54);
            label1.TabIndex = 0;
            label1.Text = "Beauty Bar";
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.AutoScroll = true;
            rightPanel.BackColor = SystemColors.ControlLightLight;
            rightPanel.Location = new Point(248, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(776, 595);
            rightPanel.TabIndex = 1;
            // 
            // frmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 595);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            IsMdiContainer = true;
            Name = "frmParent";
            Text = "frmParent";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel rightPanel;
        private Label label1;
        private Button btnServices;
        private Button btnTransactions;
        private Button btnReservations;
        private Button btnReports;
        private Button btnUsers;
        private Button btnLogout;
    }
}