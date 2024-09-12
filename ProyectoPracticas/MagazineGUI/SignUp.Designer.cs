namespace MagazineGUI
{
    partial class SignUp
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nombreUser = new System.Windows.Forms.TextBox();
            this.apellidosUser = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.pswdUser = new System.Windows.Forms.TextBox();
            this.pswdConfirmation = new System.Windows.Forms.TextBox();
            this.setNotifications = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.areasDeInteres = new System.Windows.Forms.TextBox();
            this.idUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Áreas de interés";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Confirmar contraseña";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Quiero recibir notificaciones";
            // 
            // nombreUser
            // 
            this.nombreUser.Location = new System.Drawing.Point(175, 37);
            this.nombreUser.Name = "nombreUser";
            this.nombreUser.Size = new System.Drawing.Size(157, 20);
            this.nombreUser.TabIndex = 8;
            // 
            // apellidosUser
            // 
            this.apellidosUser.Location = new System.Drawing.Point(175, 63);
            this.apellidosUser.Name = "apellidosUser";
            this.apellidosUser.Size = new System.Drawing.Size(157, 20);
            this.apellidosUser.TabIndex = 9;
            // 
            // loginUser
            // 
            this.loginUser.Location = new System.Drawing.Point(175, 216);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(157, 20);
            this.loginUser.TabIndex = 11;
            // 
            // pswdUser
            // 
            this.pswdUser.Location = new System.Drawing.Point(175, 242);
            this.pswdUser.Name = "pswdUser";
            this.pswdUser.PasswordChar = '*';
            this.pswdUser.Size = new System.Drawing.Size(157, 20);
            this.pswdUser.TabIndex = 12;
            // 
            // pswdConfirmation
            // 
            this.pswdConfirmation.Location = new System.Drawing.Point(175, 268);
            this.pswdConfirmation.Name = "pswdConfirmation";
            this.pswdConfirmation.PasswordChar = '*';
            this.pswdConfirmation.Size = new System.Drawing.Size(157, 20);
            this.pswdConfirmation.TabIndex = 13;
            // 
            // setNotifications
            // 
            this.setNotifications.AutoSize = true;
            this.setNotifications.Location = new System.Drawing.Point(317, 317);
            this.setNotifications.Name = "setNotifications";
            this.setNotifications.Size = new System.Drawing.Size(15, 14);
            this.setNotifications.TabIndex = 14;
            this.setNotifications.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(257, 368);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 15;
            this.registerButton.Text = "Registrarme";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerUser);
            // 
            // areasDeInteres
            // 
            this.areasDeInteres.Location = new System.Drawing.Point(175, 165);
            this.areasDeInteres.Name = "areasDeInteres";
            this.areasDeInteres.Size = new System.Drawing.Size(157, 20);
            this.areasDeInteres.TabIndex = 16;
            // 
            // idUser
            // 
            this.idUser.Location = new System.Drawing.Point(175, 89);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(157, 20);
            this.idUser.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DNI";
            // 
            // emailUser
            // 
            this.emailUser.Location = new System.Drawing.Point(175, 115);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(157, 20);
            this.emailUser.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "E-mail";
            // 
            // SignUp
            // 
            this.ClientSize = new System.Drawing.Size(367, 439);
            this.Controls.Add(this.emailUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areasDeInteres);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.setNotifications);
            this.Controls.Add(this.pswdConfirmation);
            this.Controls.Add(this.pswdUser);
            this.Controls.Add(this.loginUser);
            this.Controls.Add(this.apellidosUser);
            this.Controls.Add(this.nombreUser);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goBackToMenu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nombreUser;
        private System.Windows.Forms.TextBox apellidosUser;
        private System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.TextBox pswdUser;
        private System.Windows.Forms.TextBox pswdConfirmation;
        private System.Windows.Forms.CheckBox setNotifications;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox areasDeInteres;
        private System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailUser;
        private System.Windows.Forms.Label label11;
    }
}