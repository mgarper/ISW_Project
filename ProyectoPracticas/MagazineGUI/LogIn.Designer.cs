namespace MagazineGUI
{
    partial class LogIn
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.pswdUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contraseña";
            // 
            // loginUser
            // 
            this.loginUser.Location = new System.Drawing.Point(122, 88);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(140, 20);
            this.loginUser.TabIndex = 2;
            // 
            // pswdUser
            // 
            this.pswdUser.Location = new System.Drawing.Point(122, 118);
            this.pswdUser.Name = "pswdUser";
            this.pswdUser.PasswordChar = '*';
            this.pswdUser.Size = new System.Drawing.Size(140, 20);
            this.pswdUser.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logIn);
            // 
            // LogIn
            // 
            this.ClientSize = new System.Drawing.Size(316, 263);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pswdUser);
            this.Controls.Add(this.loginUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goBackToMenu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox userPswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.TextBox pswdUser;
        private System.Windows.Forms.Button button1;
    }
}