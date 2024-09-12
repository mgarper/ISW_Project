namespace MagazineGUI
{
    partial class AddCoauthors
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
            this.label1 = new System.Windows.Forms.Label();
            this.paperName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre_Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingPerson = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coauthorId = new System.Windows.Forms.TextBox();
            this.coauthorName = new System.Windows.Forms.TextBox();
            this.coauthorSurname = new System.Windows.Forms.TextBox();
            this.addAuthor = new System.Windows.Forms.Button();
            this.paperTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // paperName
            // 
            this.paperName.AutoSize = true;
            this.paperName.Location = new System.Drawing.Point(74, 58);
            this.paperName.Name = "paperName";
            this.paperName.Size = new System.Drawing.Size(0, 13);
            this.paperName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Autor});
            this.dataGridView1.DataSource = this.bindingPerson;
            this.dataGridView1.Location = new System.Drawing.Point(286, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 175);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nombre_Autor
            // 
            this.Nombre_Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre_Autor.DataPropertyName = "ds_author";
            this.Nombre_Autor.HeaderText = "Nombre_Autor";
            this.Nombre_Autor.Name = "Nombre_Autor";
            this.Nombre_Autor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre coautor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos coautor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNI coautor";
            // 
            // coauthorId
            // 
            this.coauthorId.Location = new System.Drawing.Point(116, 64);
            this.coauthorId.Name = "coauthorId";
            this.coauthorId.Size = new System.Drawing.Size(141, 20);
            this.coauthorId.TabIndex = 6;
            this.coauthorId.TextChanged += new System.EventHandler(this.lookForUser);
            // 
            // coauthorName
            // 
            this.coauthorName.Location = new System.Drawing.Point(116, 90);
            this.coauthorName.Name = "coauthorName";
            this.coauthorName.Size = new System.Drawing.Size(141, 20);
            this.coauthorName.TabIndex = 7;
            // 
            // coauthorSurname
            // 
            this.coauthorSurname.Location = new System.Drawing.Point(116, 119);
            this.coauthorSurname.Name = "coauthorSurname";
            this.coauthorSurname.Size = new System.Drawing.Size(141, 20);
            this.coauthorSurname.TabIndex = 8;
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(182, 155);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(75, 23);
            this.addAuthor.TabIndex = 9;
            this.addAuthor.Text = "Insertar";
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addNewCoauthor);
            // 
            // paperTitle
            // 
            this.paperTitle.AutoSize = true;
            this.paperTitle.Location = new System.Drawing.Point(113, 24);
            this.paperTitle.Name = "paperTitle";
            this.paperTitle.Size = new System.Drawing.Size(35, 13);
            this.paperTitle.TabIndex = 10;
            this.paperTitle.Text = "label5";
            // 
            // AddCoauthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 225);
            this.Controls.Add(this.paperTitle);
            this.Controls.Add(this.addAuthor);
            this.Controls.Add(this.coauthorSurname);
            this.Controls.Add(this.coauthorName);
            this.Controls.Add(this.coauthorId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paperName);
            this.Controls.Add(this.label1);
            this.Name = "AddCoauthors";
            this.Text = "AddCoauthors";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label paperName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coauthorId;
        private System.Windows.Forms.TextBox coauthorName;
        private System.Windows.Forms.TextBox coauthorSurname;
        private System.Windows.Forms.Button addAuthor;
        private System.Windows.Forms.BindingSource bindingPerson;
        private System.Windows.Forms.Label paperTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Autor;
    }
}