
namespace NiWFComponent
{
    partial class SortFilter
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
            this.btnA2Z = new System.Windows.Forms.Button();
            this.btnZ2A = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA2Z
            // 
            this.btnA2Z.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnA2Z.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnA2Z.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA2Z.ForeColor = System.Drawing.Color.White;
            this.btnA2Z.Location = new System.Drawing.Point(4, 3);
            this.btnA2Z.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnA2Z.Name = "btnA2Z";
            this.btnA2Z.Size = new System.Drawing.Size(287, 30);
            this.btnA2Z.TabIndex = 0;
            this.btnA2Z.Text = "Sort &A to Z";
            this.btnA2Z.UseVisualStyleBackColor = false;
            this.btnA2Z.Click += new System.EventHandler(this.btnA2Z_Click);
            // 
            // btnZ2A
            // 
            this.btnZ2A.BackColor = System.Drawing.Color.Maroon;
            this.btnZ2A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZ2A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZ2A.ForeColor = System.Drawing.Color.White;
            this.btnZ2A.Location = new System.Drawing.Point(4, 39);
            this.btnZ2A.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnZ2A.Name = "btnZ2A";
            this.btnZ2A.Size = new System.Drawing.Size(287, 30);
            this.btnZ2A.TabIndex = 0;
            this.btnZ2A.Text = "Sort &Z to A";
            this.btnZ2A.UseVisualStyleBackColor = false;
            this.btnZ2A.Click += new System.EventHandler(this.btnZ2A_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(287, 221);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(4, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(4, 338);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(287, 33);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "&Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkRed;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(4, 377);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(287, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnA2Z, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnZ2A, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDone, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("IRAN Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.79397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.79397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.79397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.77387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.547739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.045226F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 414);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SortFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 414);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SortFilter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA2Z;
        private System.Windows.Forms.Button btnZ2A;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}