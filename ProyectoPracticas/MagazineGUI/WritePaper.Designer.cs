namespace MagazineGUI
{
    partial class WritePaper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paperTitle = new System.Windows.Forms.TextBox();
            this.selectedArea = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // paperTitle
            // 
            this.paperTitle.Location = new System.Drawing.Point(143, 59);
            this.paperTitle.Name = "paperTitle";
            this.paperTitle.Size = new System.Drawing.Size(152, 20);
            this.paperTitle.TabIndex = 6;
            // 
            // selectedArea
            // 
            this.selectedArea.Location = new System.Drawing.Point(143, 33);
            this.selectedArea.Name = "selectedArea";
            this.selectedArea.Size = new System.Drawing.Size(152, 20);
            this.selectedArea.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enviar artículo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.storePaper);
            // 
            // WritePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 139);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectedArea);
            this.Controls.Add(this.paperTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WritePaper";
            this.Text = "Añadir artículo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.openMenu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paperTitle;
        private System.Windows.Forms.TextBox selectedArea;
        private System.Windows.Forms.Button button2;
    }
}