namespace MagazineGUI
{
    partial class ShowPapersArea
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
            this.currentArea = new System.Windows.Forms.Label();
            this.papersGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingEvaluation = new System.Windows.Forms.BindingSource(this.components);
            this.evaluateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.papersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEvaluation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // currentArea
            // 
            this.currentArea.AutoSize = true;
            this.currentArea.Location = new System.Drawing.Point(86, 35);
            this.currentArea.Name = "currentArea";
            this.currentArea.Size = new System.Drawing.Size(35, 13);
            this.currentArea.TabIndex = 1;
            this.currentArea.Text = "label2";
            // 
            // papersGrid
            // 
            this.papersGrid.AllowUserToAddRows = false;
            this.papersGrid.AllowUserToDeleteRows = false;
            this.papersGrid.AutoGenerateColumns = false;
            this.papersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.papersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.autores,
            this.fechaEnvio});
            this.papersGrid.DataSource = this.bindingEvaluation;
            this.papersGrid.Location = new System.Drawing.Point(51, 61);
            this.papersGrid.Name = "papersGrid";
            this.papersGrid.ReadOnly = true;
            this.papersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.papersGrid.Size = new System.Drawing.Size(513, 190);
            this.papersGrid.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "ds_id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // titulo
            // 
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
            // fechaEnvio
            // 
            this.fechaEnvio.DataPropertyName = "ds_fechaEnvio";
            this.fechaEnvio.HeaderText = "fechaEnvio";
            this.fechaEnvio.Name = "fechaEnvio";
            this.fechaEnvio.ReadOnly = true;
            // 
            // evaluateButton
            // 
            this.evaluateButton.Location = new System.Drawing.Point(489, 272);
            this.evaluateButton.Name = "evaluateButton";
            this.evaluateButton.Size = new System.Drawing.Size(75, 23);
            this.evaluateButton.TabIndex = 3;
            this.evaluateButton.Text = "Evaluar";
            this.evaluateButton.UseVisualStyleBackColor = true;
            this.evaluateButton.Click += new System.EventHandler(this.EvaluatePaper);
            // 
            // ShowPapersArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 325);
            this.Controls.Add(this.evaluateButton);
            this.Controls.Add(this.papersGrid);
            this.Controls.Add(this.currentArea);
            this.Controls.Add(this.label1);
            this.Name = "ShowPapersArea";
            this.Text = "ShowPapersArea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.goBackToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.papersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingEvaluation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentArea;
        private System.Windows.Forms.DataGridView papersGrid;
        private System.Windows.Forms.Button evaluateButton;
        private System.Windows.Forms.BindingSource bindingEvaluation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn autores;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvio;
    }
}