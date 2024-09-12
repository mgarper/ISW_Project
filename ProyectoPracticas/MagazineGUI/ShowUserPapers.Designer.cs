namespace MagazineGUI
{
    partial class ShowUserPapers
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
            this.paperGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAuthorsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paperGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paperGrid
            // 
            this.paperGrid.AllowUserToAddRows = false;
            this.paperGrid.AllowUserToDeleteRows = false;
            this.paperGrid.AllowUserToResizeRows = false;
            this.paperGrid.AutoGenerateColumns = false;
            this.paperGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo});
            this.paperGrid.DataSource = this.paperBindingSource;
            this.paperGrid.Location = new System.Drawing.Point(22, 44);
            this.paperGrid.MultiSelect = false;
            this.paperGrid.Name = "paperGrid";
            this.paperGrid.ReadOnly = true;
            this.paperGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paperGrid.Size = new System.Drawing.Size(514, 165);
            this.paperGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ds_id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "ds_titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // addAuthorsButton
            // 
            this.addAuthorsButton.Location = new System.Drawing.Point(461, 226);
            this.addAuthorsButton.Name = "addAuthorsButton";
            this.addAuthorsButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorsButton.TabIndex = 1;
            this.addAuthorsButton.Text = "Aceptar";
            this.addAuthorsButton.UseVisualStyleBackColor = true;
            this.addAuthorsButton.Click += new System.EventHandler(this.goToAddCoauthors);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un artículo";
            // 
            // ShowUserPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 272);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAuthorsButton);
            this.Controls.Add(this.paperGrid);
            this.Name = "ShowUserPapers";
            this.Text = "ShowUserPapers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goBackToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.paperGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource paperBindingSource;
        private System.Windows.Forms.DataGridView paperGrid;
        private System.Windows.Forms.Button addAuthorsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
    }
}