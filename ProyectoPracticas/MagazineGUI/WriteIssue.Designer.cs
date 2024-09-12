namespace MagazineGUI
{
    partial class WriteIssue
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
            this.gridPapers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridPending = new System.Windows.Forms.DataGridView();
            this.id_pend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo_pend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberIssue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedArea = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPapers
            // 
            this.gridPapers.AllowUserToAddRows = false;
            this.gridPapers.AllowUserToDeleteRows = false;
            this.gridPapers.AutoGenerateColumns = false;
            this.gridPapers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPapers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo});
            this.gridPapers.DataSource = this.publicationSource;
            this.gridPapers.Location = new System.Drawing.Point(24, 172);
            this.gridPapers.MultiSelect = false;
            this.gridPapers.Name = "gridPapers";
            this.gridPapers.ReadOnly = true;
            this.gridPapers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPapers.Size = new System.Drawing.Size(456, 306);
            this.gridPapers.TabIndex = 0;
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
            this.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo.DataPropertyName = "ds_titulo";
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            // 
            // gridPending
            // 
            this.gridPending.AllowUserToAddRows = false;
            this.gridPending.AllowUserToDeleteRows = false;
            this.gridPending.AutoGenerateColumns = false;
            this.gridPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pend,
            this.titulo_pend});
            this.gridPending.DataSource = this.pendingSource;
            this.gridPending.Location = new System.Drawing.Point(610, 172);
            this.gridPending.MultiSelect = false;
            this.gridPending.Name = "gridPending";
            this.gridPending.ReadOnly = true;
            this.gridPending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPending.Size = new System.Drawing.Size(456, 306);
            this.gridPending.TabIndex = 1;
            // 
            // id_pend
            // 
            this.id_pend.DataPropertyName = "ds_pendid";
            this.id_pend.HeaderText = "id";
            this.id_pend.Name = "id_pend";
            this.id_pend.ReadOnly = true;
            // 
            // titulo_pend
            // 
            this.titulo_pend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titulo_pend.DataPropertyName = "ds_pendtitulo";
            this.titulo_pend.HeaderText = "titulo";
            this.titulo_pend.Name = "titulo_pend";
            this.titulo_pend.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Establecer fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetDate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de ejemplar a publicar:";
            // 
            // numberIssue
            // 
            this.numberIssue.AutoSize = true;
            this.numberIssue.Location = new System.Drawing.Point(180, 22);
            this.numberIssue.Name = "numberIssue";
            this.numberIssue.Size = new System.Drawing.Size(35, 13);
            this.numberIssue.TabIndex = 4;
            this.numberIssue.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de publicación";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker.Location = new System.Drawing.Point(183, 46);
            this.dateTimePicker.MinDate = new System.DateTime(2022, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(829, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área escogida";
            // 
            // selectedArea
            // 
            this.selectedArea.FormattingEnabled = true;
            this.selectedArea.Location = new System.Drawing.Point(910, 49);
            this.selectedArea.Name = "selectedArea";
            this.selectedArea.Size = new System.Drawing.Size(121, 21);
            this.selectedArea.TabIndex = 8;
            this.selectedArea.SelectedIndexChanged += new System.EventHandler(this.filterBy);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Actualizar listas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.updateDataIssue);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccionados para publicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pendientes de publicación";
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(505, 279);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 12;
            this.buttonRight.Text = "-->";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.AddToPublicationPending);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(505, 337);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 13;
            this.buttonLeft.Text = "<--";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.AddToPapers);
            // 
            // WriteIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 547);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.selectedArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridPending);
            this.Controls.Add(this.gridPapers);
            this.Name = "WriteIssue";
            this.Text = "WriteIssue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.goBackToMenu);
            ((System.ComponentModel.ISupportInitialize)(this.gridPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicationSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPapers;
        private System.Windows.Forms.DataGridView gridPending;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberIssue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectedArea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.BindingSource publicationSource;
        private System.Windows.Forms.BindingSource pendingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pend;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_pend;
    }
}