
namespace AutoResquest
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbEstatus = new System.Windows.Forms.CheckBox();
            this.CmbInterval = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.PbTrabajando = new System.Windows.Forms.PictureBox();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTrabajando)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(342, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AutoResquest";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.BackgroundColor = System.Drawing.Color.White;
            this.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvListado.GridColor = System.Drawing.Color.White;
            this.DgvListado.Location = new System.Drawing.Point(12, 115);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListado.Size = new System.Drawing.Size(776, 291);
            this.DgvListado.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Url";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estatus";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tiempo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Result";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // TxtUrl
            // 
            this.TxtUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUrl.Location = new System.Drawing.Point(12, 84);
            this.TxtUrl.MaxLength = 150;
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(325, 26);
            this.TxtUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "URL";
            // 
            // CbEstatus
            // 
            this.CbEstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbEstatus.AutoSize = true;
            this.CbEstatus.Location = new System.Drawing.Point(530, 89);
            this.CbEstatus.Name = "CbEstatus";
            this.CbEstatus.Size = new System.Drawing.Size(61, 17);
            this.CbEstatus.TabIndex = 7;
            this.CbEstatus.Text = "Estatus";
            this.CbEstatus.UseVisualStyleBackColor = true;
            // 
            // CmbInterval
            // 
            this.CmbInterval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CmbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInterval.FormattingEnabled = true;
            this.CmbInterval.Location = new System.Drawing.Point(343, 87);
            this.CmbInterval.Name = "CmbInterval";
            this.CmbInterval.Size = new System.Drawing.Size(181, 21);
            this.CmbInterval.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intervalos Para Ejecutar";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(12, 412);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(80, 26);
            this.TxtCantidad.TabIndex = 10;
            // 
            // PbTrabajando
            // 
            this.PbTrabajando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbTrabajando.Image = global::AutoResquest.Properties.Resources.trabajando;
            this.PbTrabajando.Location = new System.Drawing.Point(721, 8);
            this.PbTrabajando.Name = "PbTrabajando";
            this.PbTrabajando.Size = new System.Drawing.Size(118, 98);
            this.PbTrabajando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTrabajando.TabIndex = 13;
            this.PbTrabajando.TabStop = false;
            // 
            // BtnPausar
            // 
            this.BtnPausar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPausar.Image = global::AutoResquest.Properties.Resources.Pausar;
            this.BtnPausar.Location = new System.Drawing.Point(657, 67);
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.Size = new System.Drawing.Size(45, 43);
            this.BtnPausar.TabIndex = 12;
            this.BtnPausar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPausar.UseVisualStyleBackColor = true;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.Image = global::AutoResquest.Properties.Resources.Iniciar;
            this.BtnIniciar.Location = new System.Drawing.Point(657, 67);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(45, 43);
            this.BtnIniciar.TabIndex = 11;
            this.BtnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Visible = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::AutoResquest.Properties.Resources.edit;
            this.button3.Location = new System.Drawing.Point(794, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 4;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::AutoResquest.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(794, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::AutoResquest.Properties.Resources.add;
            this.button1.Location = new System.Drawing.Point(597, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.PbTrabajando);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbInterval);
            this.Controls.Add(this.CbEstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoResquest";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTrabajando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CbEstatus;
        private System.Windows.Forms.ComboBox CmbInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnPausar;
        private System.Windows.Forms.PictureBox PbTrabajando;
    }
}

