
using Jas.Utils.AnalyticalGrid;
namespace csv2sql {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new Jas.Utils.AnalyticalGrid.AnalyticalGrid();
            this.od2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bGenSQL = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTable = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 359);
            this.panel2.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(948, 359);
            this.dgv.TabIndex = 0;
            this.dgv.ValueHistory = null;
            // 
            // od2
            // 
            this.od2.Filter = "Soubory CSV|*.csv|Vsechny soubory|*.*";
            this.od2.RestoreDirectory = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bGenSQL);
            this.panel1.Controls.Add(this.bOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 44);
            this.panel1.TabIndex = 2;
            // 
            // bGenSQL
            // 
            this.bGenSQL.Location = new System.Drawing.Point(311, 12);
            this.bGenSQL.Name = "bGenSQL";
            this.bGenSQL.Size = new System.Drawing.Size(123, 23);
            this.bGenSQL.TabIndex = 1;
            this.bGenSQL.Text = "Generate SQL...";
            this.bGenSQL.UseVisualStyleBackColor = true;
            this.bGenSQL.Click += new System.EventHandler(this.bGenSQL_Click);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 12);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(93, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Open file...";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table";
            // 
            // tbTable
            // 
            this.tbTable.Location = new System.Drawing.Point(205, 15);
            this.tbTable.Name = "tbTable";
            this.tbTable.Size = new System.Drawing.Size(100, 20);
            this.tbTable.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv2sql";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private AnalyticalGrid dgv;
        private System.Windows.Forms.OpenFileDialog od2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bGenSQL;
        private System.Windows.Forms.TextBox tbTable;
        private System.Windows.Forms.Label label1;
    }
}

