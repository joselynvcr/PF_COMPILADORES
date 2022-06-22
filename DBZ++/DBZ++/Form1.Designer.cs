namespace DBZ__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LinesNumbers = new System.Windows.Forms.ListBox();
            this.txtCodFuente = new System.Windows.Forms.RichTextBox();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.listNumberLines = new System.Windows.Forms.ListBox();
            this.txtResult2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLexico = new System.Windows.Forms.Button();
            this.dgvTokens = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // LinesNumbers
            // 
            this.LinesNumbers.FormattingEnabled = true;
            this.LinesNumbers.ItemHeight = 15;
            this.LinesNumbers.Location = new System.Drawing.Point(-168, 70);
            this.LinesNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinesNumbers.Name = "LinesNumbers";
            this.LinesNumbers.Size = new System.Drawing.Size(34, 259);
            this.LinesNumbers.TabIndex = 8;
            // 
            // txtCodFuente
            // 
            this.txtCodFuente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodFuente.Location = new System.Drawing.Point(37, 26);
            this.txtCodFuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodFuente.Name = "txtCodFuente";
            this.txtCodFuente.Size = new System.Drawing.Size(479, 709);
            this.txtCodFuente.TabIndex = 2;
            this.txtCodFuente.Text = "per{x=0.x<<1.x++}[\ncomplit a=10.\n]";
            this.txtCodFuente.TextChanged += new System.EventHandler(this.txtSourceCode_TextChanged);
            // 
            // btnCompilar
            // 
            this.btnCompilar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompilar.Location = new System.Drawing.Point(522, 323);
            this.btnCompilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(96, 37);
            this.btnCompilar.TabIndex = 5;
            this.btnCompilar.Text = "COMPILAR";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnRunRun_Click);
            // 
            // listNumberLines
            // 
            this.listNumberLines.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listNumberLines.FormattingEnabled = true;
            this.listNumberLines.ItemHeight = 15;
            this.listNumberLines.Location = new System.Drawing.Point(0, 26);
            this.listNumberLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listNumberLines.Name = "listNumberLines";
            this.listNumberLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listNumberLines.Size = new System.Drawing.Size(39, 709);
            this.listNumberLines.TabIndex = 10;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(634, 545);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(518, 184);
            this.txtResult2.TabIndex = 16;
            this.txtResult2.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(634, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(518, 205);
            this.dataGridView1.TabIndex = 18;
            // 
            // BtnLexico
            // 
            this.BtnLexico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLexico.Location = new System.Drawing.Point(522, 262);
            this.BtnLexico.Name = "BtnLexico";
            this.BtnLexico.Size = new System.Drawing.Size(96, 39);
            this.BtnLexico.TabIndex = 20;
            this.BtnLexico.Text = "LEXICO";
            this.BtnLexico.UseVisualStyleBackColor = true;
            this.BtnLexico.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTokens
            // 
            this.dgvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTokens.Location = new System.Drawing.Point(634, 26);
            this.dgvTokens.Name = "dgvTokens";
            this.dgvTokens.RowTemplate.Height = 25;
            this.dgvTokens.Size = new System.Drawing.Size(518, 275);
            this.dgvTokens.TabIndex = 19;
            this.dgvTokens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TOKEN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TIPO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LINEA";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "COLUMNA";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 741);
            this.Controls.Add(this.BtnLexico);
            this.Controls.Add(this.dgvTokens);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.listNumberLines);
            this.Controls.Add(this.LinesNumbers);
            this.Controls.Add(this.txtCodFuente);
            this.Controls.Add(this.btnCompilar);
            this.Name = "Form1";
            this.Text = "GOKU 1.41817";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTokens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox LinesNumbers;
        private RichTextBox txtCodFuente;
        private Button btnCompilar;
        private ListBox listNumberLines;
        private RichTextBox txtResult2;
        private DataGridView dataGridView1;
        private Button BtnLexico;
        private DataGridView dgvTokens;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}