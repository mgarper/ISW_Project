namespace MagazineGUI
{
    partial class ShowPapers
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
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paperGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paperGrid
            // 
            this.paperGrid.AllowUserToAddRows = false;
            this.paperGrid.AllowUserToDeleteRows = false;
            this.paperGrid.AutoGenerateColumns = false;
            this.paperGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paperGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.area,
            this.titulo,
            this.autores,
            this.estado});
            this.paperGrid.DataSource = this.paperBindingSource;
            this.paperGrid.Location = new System.Drawing.Point(12, 88);
            this.paperGrid.Name = "paperGrid";
            this.paperGrid.ReadOnly = true;
            this.paperGrid.Size = new System.Drawing.Size(776, 322);
            this.paperGrid.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "ds_numero";
            this.numero.HeaderText = "número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "ds_area";
            this.area.HeaderText = "area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "ds_titulo";
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // autores
            // 
            this.autores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autores.DataPropertyName = "ds_autores";
            this.autores.HeaderText = "autores";
            this.autores.Name = "autores";
            this.autores.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "ds_estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(146, 38);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(146, 21);
            this.areaComboBox.TabIndex = 1;
            this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.filterBy);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº de ejemplar";
            // 
            // ShowPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.paperGrid);
            this.Name = "ShowPapers";
            this.Text = "ShowPapers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.paperGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView paperGrid;
        private System.Windows.Forms.BindingSource paperBindingSource;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}