using System.ComponentModel;
using System.Windows.Forms;

namespace NiWFComponent
{
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner))]
    partial class NiWFDataGrid 
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.Size = new System.Drawing.Size(400, 233);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGrid_ColumnHeaderMouseClick);
            // 
            // NiWFDataGrid
            // 
            this.Controls.Add(this.DataGrid);
            this.Name = "NiWFDataGrid";
            this.Size = new System.Drawing.Size(400, 233);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }
        AutoScaleMode autoScaleMode;
        private DataGridView DataGrid;

        public AutoScaleMode AutoScaleMode   {   get =>  autoScaleMode;   set=>   autoScaleMode = value;   }
        #endregion
    }
}
