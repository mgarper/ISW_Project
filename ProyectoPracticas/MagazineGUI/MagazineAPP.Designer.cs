namespace MagazineGUI
{
    partial class MagazineAPP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.listPapers = new System.Windows.Forms.Button();
            this.writeIssue = new System.Windows.Forms.Button();
            this.evaluatePapers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.sendPaper = new System.Windows.Forms.Button();
            this.changeAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(12, 14);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(87, 23);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Iniciar sesión";
            this.signInButton.Click += new System.EventHandler(this.openLogIn);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(105, 14);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(87, 23);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Registrarse";
            this.signUpButton.Click += new System.EventHandler(this.openSignUpForm);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(347, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(85, 23);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Cerrar sesión";
            this.logOutButton.Click += new System.EventHandler(this.logOut);
            // 
            // listPapers
            // 
            this.listPapers.Location = new System.Drawing.Point(354, 319);
            this.listPapers.Name = "listPapers";
            this.listPapers.Size = new System.Drawing.Size(78, 35);
            this.listPapers.TabIndex = 5;
            this.listPapers.Text = "Listar artículos";
            this.listPapers.UseVisualStyleBackColor = true;
            this.listPapers.Click += new System.EventHandler(this.goToShowPapers);
            // 
            // writeIssue
            // 
            this.writeIssue.Location = new System.Drawing.Point(257, 319);
            this.writeIssue.Name = "writeIssue";
            this.writeIssue.Size = new System.Drawing.Size(78, 35);
            this.writeIssue.TabIndex = 6;
            this.writeIssue.Text = "Confeccionar ejemplar";
            this.writeIssue.UseVisualStyleBackColor = true;
            this.writeIssue.Click += new System.EventHandler(this.goToWriteIssue);
            // 
            // evaluatePapers
            // 
            this.evaluatePapers.Location = new System.Drawing.Point(12, 319);
            this.evaluatePapers.Name = "evaluatePapers";
            this.evaluatePapers.Size = new System.Drawing.Size(96, 35);
            this.evaluatePapers.TabIndex = 7;
            this.evaluatePapers.Text = "Evaluar artículos";
            this.evaluatePapers.UseVisualStyleBackColor = true;
            this.evaluatePapers.Click += new System.EventHandler(this.showAreaPapers);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\G712\\source\\repos\\proyectoISW\\ProyectoPracticas\\MagazineGUI\\Resources\\14" +
    "54816.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(257, 219);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 63);
            this.button7.TabIndex = 0;
            this.button7.Text = "Consultar ejemplares";
            // 
            // sendPaper
            // 
            this.sendPaper.Location = new System.Drawing.Point(257, 81);
            this.sendPaper.Name = "sendPaper";
            this.sendPaper.Size = new System.Drawing.Size(175, 63);
            this.sendPaper.TabIndex = 9;
            this.sendPaper.Text = "Enviar artículo";
            this.sendPaper.Click += new System.EventHandler(this.goToWritePaper);
            // 
            // changeAuthors
            // 
            this.changeAuthors.Location = new System.Drawing.Point(257, 150);
            this.changeAuthors.Name = "changeAuthors";
            this.changeAuthors.Size = new System.Drawing.Size(175, 63);
            this.changeAuthors.TabIndex = 10;
            this.changeAuthors.Text = "Añadir  coautores";
            this.changeAuthors.Click += new System.EventHandler(this.goToChangeAuthors);
            // 
            // MagazineAPP
            // 
            this.ClientSize = new System.Drawing.Size(448, 370);
            this.Controls.Add(this.changeAuthors);
            this.Controls.Add(this.sendPaper);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.evaluatePapers);
            this.Controls.Add(this.writeIssue);
            this.Controls.Add(this.listPapers);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.Name = "MagazineAPP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button listPapers;
        private System.Windows.Forms.Button writeIssue;
        private System.Windows.Forms.Button evaluatePapers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button sendPaper;
        private System.Windows.Forms.Button changeAuthors;
    }
}

