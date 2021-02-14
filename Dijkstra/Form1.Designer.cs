
namespace Dijkstra
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
            this.btnSolve = new System.Windows.Forms.Button();
            this.dgGraph = new System.Windows.Forms.DataGridView();
            this.dgPath = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPath)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 12);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 30);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Тык";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // dgGraph
            // 
            this.dgGraph.AllowUserToAddRows = false;
            this.dgGraph.AllowUserToDeleteRows = false;
            this.dgGraph.AllowUserToResizeColumns = false;
            this.dgGraph.AllowUserToResizeRows = false;
            this.dgGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGraph.EnableHeadersVisualStyles = false;
            this.dgGraph.Location = new System.Drawing.Point(12, 69);
            this.dgGraph.Name = "dgGraph";
            this.dgGraph.ReadOnly = true;
            this.dgGraph.RowHeadersVisible = false;
            this.dgGraph.RowTemplate.Height = 25;
            this.dgGraph.Size = new System.Drawing.Size(776, 369);
            this.dgGraph.TabIndex = 4;
            // 
            // dgPath
            // 
            this.dgPath.AllowUserToAddRows = false;
            this.dgPath.AllowUserToDeleteRows = false;
            this.dgPath.AllowUserToResizeColumns = false;
            this.dgPath.AllowUserToResizeRows = false;
            this.dgPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPath.ColumnHeadersVisible = false;
            this.dgPath.Location = new System.Drawing.Point(109, 12);
            this.dgPath.Name = "dgPath";
            this.dgPath.ReadOnly = true;
            this.dgPath.RowHeadersVisible = false;
            this.dgPath.RowTemplate.Height = 25;
            this.dgPath.Size = new System.Drawing.Size(679, 30);
            this.dgPath.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgPath);
            this.Controls.Add(this.dgGraph);
            this.Controls.Add(this.btnSolve);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DataGridView dgGraph;
        private System.Windows.Forms.DataGridView dgPath;
    }
}

