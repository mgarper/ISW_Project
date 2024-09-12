namespace MagazineGUI
{
    partial class EvaluatePaper
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
            this.paperTitle = new System.Windows.Forms.Label();
            this.approvedCheckbox = new System.Windows.Forms.CheckBox();
            this.comments = new System.Windows.Forms.TextBox();
            this.sendEval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aprobado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // paperTitle
            // 
            this.paperTitle.AutoSize = true;
            this.paperTitle.Location = new System.Drawing.Point(87, 27);
            this.paperTitle.Name = "paperTitle";
            this.paperTitle.Size = new System.Drawing.Size(53, 13);
            this.paperTitle.TabIndex = 2;
            this.paperTitle.Text = "Aprobado";
            // 
            // approvedCheckbox
            // 
            this.approvedCheckbox.AutoSize = true;
            this.approvedCheckbox.Location = new System.Drawing.Point(90, 54);
            this.approvedCheckbox.Name = "approvedCheckbox";
            this.approvedCheckbox.Size = new System.Drawing.Size(15, 14);
            this.approvedCheckbox.TabIndex = 3;
            this.approvedCheckbox.UseVisualStyleBackColor = true;
            // 
            // comments
            // 
            this.comments.Location = new System.Drawing.Point(90, 85);
            this.comments.Multiline = true;
            this.comments.Name = "comments";
            this.comments.ShortcutsEnabled = false;
            this.comments.Size = new System.Drawing.Size(329, 156);
            this.comments.TabIndex = 4;
            this.comments.Tag = "";
            // 
            // sendEval
            // 
            this.sendEval.Location = new System.Drawing.Point(344, 257);
            this.sendEval.Name = "sendEval";
            this.sendEval.Size = new System.Drawing.Size(75, 23);
            this.sendEval.TabIndex = 5;
            this.sendEval.Text = "Enviar";
            this.sendEval.UseVisualStyleBackColor = true;
            this.sendEval.Click += new System.EventHandler(this.sendReview);
            // 
            // EvaluatePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 299);
            this.Controls.Add(this.sendEval);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.approvedCheckbox);
            this.Controls.Add(this.paperTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EvaluatePaper";
            this.Text = "EvaluatePaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paperTitle;
        private System.Windows.Forms.CheckBox approvedCheckbox;
        private System.Windows.Forms.TextBox comments;
        private System.Windows.Forms.Button sendEval;
    }
}