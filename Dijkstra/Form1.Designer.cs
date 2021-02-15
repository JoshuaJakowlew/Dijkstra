
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
            this.numericStartVertex = new System.Windows.Forms.NumericUpDown();
            this.numericEndVertex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartVertex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndVertex)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(12, 12);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 41);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Ищем путь";
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
            this.dgPath.Location = new System.Drawing.Point(207, 12);
            this.dgPath.Name = "dgPath";
            this.dgPath.ReadOnly = true;
            this.dgPath.RowHeadersVisible = false;
            this.dgPath.RowTemplate.Height = 25;
            this.dgPath.Size = new System.Drawing.Size(581, 30);
            this.dgPath.TabIndex = 5;
            // 
            // numericStartVertex
            // 
            this.numericStartVertex.Location = new System.Drawing.Point(104, 12);
            this.numericStartVertex.Name = "numericStartVertex";
            this.numericStartVertex.Size = new System.Drawing.Size(42, 23);
            this.numericStartVertex.TabIndex = 6;
            // 
            // numericEndVertex
            // 
            this.numericEndVertex.Location = new System.Drawing.Point(152, 12);
            this.numericEndVertex.Name = "numericEndVertex";
            this.numericEndVertex.Size = new System.Drawing.Size(42, 23);
            this.numericEndVertex.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Конец";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericEndVertex);
            this.Controls.Add(this.numericStartVertex);
            this.Controls.Add(this.dgPath);
            this.Controls.Add(this.dgGraph);
            this.Controls.Add(this.btnSolve);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartVertex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEndVertex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.DataGridView dgGraph;
        private System.Windows.Forms.DataGridView dgPath;
        private System.Windows.Forms.NumericUpDown numericStartVertex;
        private System.Windows.Forms.NumericUpDown numericEndVertex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

