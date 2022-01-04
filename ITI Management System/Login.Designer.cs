namespace ITI_Management_System
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_close = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.tbx_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bdcontrol = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.rdio_admin = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rdio_instructor = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rdio_student = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_instructor = new System.Windows.Forms.Label();
            this.lbl_student = new System.Windows.Forms.Label();
            this.tbx_uname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_uname = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_pass = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_user = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bElipse
            // 
            this.bElipse.ElipseRadius = 0;
            this.bElipse.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.btn_close);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 0;
            this.bunifuCards1.Size = new System.Drawing.Size(342, 34);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.AllowFocused = false;
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.AutoSizeHeight = true;
            this.btn_close.BorderRadius = 13;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.IsCircle = false;
            this.btn_close.Location = new System.Drawing.Point(309, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(26, 26);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbx_pass
            // 
            this.tbx_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbx_pass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbx_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbx_pass.ForeColor = System.Drawing.Color.Transparent;
            this.tbx_pass.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_pass.HintText = "Password";
            this.tbx_pass.isPassword = false;
            this.tbx_pass.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.tbx_pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.tbx_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.tbx_pass.LineThickness = 3;
            this.tbx_pass.Location = new System.Drawing.Point(58, 211);
            this.tbx_pass.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_pass.MaxLength = 32767;
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.Size = new System.Drawing.Size(227, 43);
            this.tbx_pass.TabIndex = 10;
            this.tbx_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_pass.OnValueChanged += new System.EventHandler(this.tbx_pass_OnValueChanged);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(135, 50);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 11;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 1;
            this.btn_login.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_login.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 1;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.btn_login.Location = new System.Drawing.Point(58, 342);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(227, 63);
            this.btn_login.TabIndex = 12;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // bdcontrol
            // 
            this.bdcontrol.Fixed = true;
            this.bdcontrol.Horizontal = true;
            this.bdcontrol.TargetControl = this.bunifuCards1;
            this.bdcontrol.Vertical = true;
            // 
            // rdio_admin
            // 
            this.rdio_admin.AllowBindingControlLocation = false;
            this.rdio_admin.BackColor = System.Drawing.Color.Transparent;
            this.rdio_admin.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdio_admin.BorderThickness = 1;
            this.rdio_admin.Checked = true;
            this.rdio_admin.Location = new System.Drawing.Point(58, 291);
            this.rdio_admin.Name = "rdio_admin";
            this.rdio_admin.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rdio_admin.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_admin.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rdio_admin.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rdio_admin.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_admin.Size = new System.Drawing.Size(21, 21);
            this.rdio_admin.TabIndex = 13;
            this.rdio_admin.Text = null;
            // 
            // rdio_instructor
            // 
            this.rdio_instructor.AllowBindingControlLocation = false;
            this.rdio_instructor.BackColor = System.Drawing.Color.Transparent;
            this.rdio_instructor.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdio_instructor.BorderThickness = 1;
            this.rdio_instructor.Checked = false;
            this.rdio_instructor.Location = new System.Drawing.Point(136, 291);
            this.rdio_instructor.Name = "rdio_instructor";
            this.rdio_instructor.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rdio_instructor.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_instructor.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rdio_instructor.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rdio_instructor.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_instructor.Size = new System.Drawing.Size(21, 21);
            this.rdio_instructor.TabIndex = 14;
            this.rdio_instructor.Text = null;
            // 
            // rdio_student
            // 
            this.rdio_student.AllowBindingControlLocation = false;
            this.rdio_student.BackColor = System.Drawing.Color.Transparent;
            this.rdio_student.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rdio_student.BorderThickness = 1;
            this.rdio_student.Checked = false;
            this.rdio_student.Location = new System.Drawing.Point(226, 291);
            this.rdio_student.Name = "rdio_student";
            this.rdio_student.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.rdio_student.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_student.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.rdio_student.RadioColor = System.Drawing.Color.DodgerBlue;
            this.rdio_student.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rdio_student.Size = new System.Drawing.Size(21, 21);
            this.rdio_student.TabIndex = 15;
            this.rdio_student.Text = null;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(82, 294);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(45, 16);
            this.lbl_admin.TabIndex = 16;
            this.lbl_admin.Text = "Admin";
            this.lbl_admin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_instructor
            // 
            this.lbl_instructor.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.lbl_instructor.AutoSize = true;
            this.lbl_instructor.ForeColor = System.Drawing.Color.White;
            this.lbl_instructor.Location = new System.Drawing.Point(160, 294);
            this.lbl_instructor.Name = "lbl_instructor";
            this.lbl_instructor.Size = new System.Drawing.Size(60, 16);
            this.lbl_instructor.TabIndex = 17;
            this.lbl_instructor.Text = "Instructor";
            this.lbl_instructor.Click += new System.EventHandler(this.lbl_instructor_Click);
            // 
            // lbl_student
            // 
            this.lbl_student.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.lbl_student.AutoSize = true;
            this.lbl_student.ForeColor = System.Drawing.Color.White;
            this.lbl_student.Location = new System.Drawing.Point(250, 294);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(52, 16);
            this.lbl_student.TabIndex = 18;
            this.lbl_student.Text = "Student";
            this.lbl_student.Click += new System.EventHandler(this.lbl_student_Click);
            // 
            // tbx_uname
            // 
            this.tbx_uname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_uname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_uname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_uname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbx_uname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbx_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbx_uname.ForeColor = System.Drawing.Color.Transparent;
            this.tbx_uname.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_uname.HintText = "Username";
            this.tbx_uname.isPassword = false;
            this.tbx_uname.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.tbx_uname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.tbx_uname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(80)))), ((int)(((byte)(92)))));
            this.tbx_uname.LineThickness = 3;
            this.tbx_uname.Location = new System.Drawing.Point(58, 140);
            this.tbx_uname.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_uname.MaxLength = 32767;
            this.tbx_uname.Name = "tbx_uname";
            this.tbx_uname.Size = new System.Drawing.Size(227, 43);
            this.tbx_uname.TabIndex = 19;
            this.tbx_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbx_uname.OnValueChanged += new System.EventHandler(this.tbx_uname_OnValueChanged);
            // 
            // lbl_uname
            // 
            this.lbl_uname.AllowParentOverrides = false;
            this.lbl_uname.AutoEllipsis = false;
            this.lbl_uname.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_uname.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_uname.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lbl_uname.ForeColor = System.Drawing.Color.Red;
            this.lbl_uname.Location = new System.Drawing.Point(65, 189);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_uname.Size = new System.Drawing.Size(0, 0);
            this.lbl_uname.TabIndex = 20;
            this.lbl_uname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_uname.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AllowParentOverrides = false;
            this.lbl_pass.AutoEllipsis = false;
            this.lbl_pass.CursorType = null;
            this.lbl_pass.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lbl_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_pass.Location = new System.Drawing.Point(65, 262);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_pass.Size = new System.Drawing.Size(0, 0);
            this.lbl_pass.TabIndex = 21;
            this.lbl_pass.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_pass.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_user
            // 
            this.lbl_user.AllowParentOverrides = false;
            this.lbl_user.AutoEllipsis = false;
            this.lbl_user.CursorType = null;
            this.lbl_user.Font = new System.Drawing.Font("Lucida Sans", 9F);
            this.lbl_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_user.Location = new System.Drawing.Point(65, 318);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_user.Size = new System.Drawing.Size(0, 0);
            this.lbl_user.TabIndex = 22;
            this.lbl_user.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_user.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(342, 469);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.tbx_uname);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.lbl_instructor);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.rdio_student);
            this.Controls.Add(this.rdio_instructor);
            this.Controls.Add(this.rdio_admin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.bunifuCards1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bElipse;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbx_pass;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
        private Bunifu.Framework.UI.BunifuDragControl bdcontrol;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_close;
        private System.Windows.Forms.Label lbl_admin;
        private Bunifu.UI.WinForms.BunifuRadioButton rdio_student;
        private Bunifu.UI.WinForms.BunifuRadioButton rdio_instructor;
        private Bunifu.UI.WinForms.BunifuRadioButton rdio_admin;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_instructor;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbx_uname;
        private Bunifu.UI.WinForms.BunifuLabel lbl_uname;
        private Bunifu.UI.WinForms.BunifuLabel lbl_pass;
        private Bunifu.UI.WinForms.BunifuLabel lbl_user;
    }
}