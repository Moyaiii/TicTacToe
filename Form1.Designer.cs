
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BR = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.CR = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.Button();
            this.CL = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Button();
            this.TC = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Controls.Add(this.BR, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CR, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TC, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TR, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.27624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.72376F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // BR
            // 
            this.BR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BR.Location = new System.Drawing.Point(277, 254);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(122, 118);
            this.BR.TabIndex = 8;
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.Mark);
            // 
            // BC
            // 
            this.BC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BC.Location = new System.Drawing.Point(140, 254);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(131, 118);
            this.BC.TabIndex = 7;
            this.BC.UseVisualStyleBackColor = true;
            this.BC.Click += new System.EventHandler(this.Mark);
            // 
            // BL
            // 
            this.BL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BL.Location = new System.Drawing.Point(3, 254);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(131, 118);
            this.BL.TabIndex = 6;
            this.BL.UseVisualStyleBackColor = true;
            this.BL.Click += new System.EventHandler(this.Mark);
            // 
            // CR
            // 
            this.CR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CR.Location = new System.Drawing.Point(277, 129);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(122, 119);
            this.CR.TabIndex = 5;
            this.CR.UseVisualStyleBackColor = true;
            this.CR.Click += new System.EventHandler(this.Mark);
            // 
            // CC
            // 
            this.CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CC.Location = new System.Drawing.Point(140, 129);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(131, 119);
            this.CC.TabIndex = 4;
            this.CC.UseVisualStyleBackColor = true;
            this.CC.Click += new System.EventHandler(this.Mark);
            // 
            // CL
            // 
            this.CL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CL.Location = new System.Drawing.Point(3, 129);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(131, 119);
            this.CL.TabIndex = 3;
            this.CL.UseVisualStyleBackColor = true;
            this.CL.Click += new System.EventHandler(this.Mark);
            // 
            // TL
            // 
            this.TL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TL.Location = new System.Drawing.Point(3, 3);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(131, 120);
            this.TL.TabIndex = 0;
            this.TL.UseVisualStyleBackColor = true;
            this.TL.Click += new System.EventHandler(this.Mark);
            // 
            // TC
            // 
            this.TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TC.Location = new System.Drawing.Point(140, 3);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(131, 120);
            this.TC.TabIndex = 1;
            this.TC.UseVisualStyleBackColor = true;
            this.TC.Click += new System.EventHandler(this.Mark);
            // 
            // TR
            // 
            this.TR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TR.Location = new System.Drawing.Point(277, 3);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(122, 120);
            this.TR.TabIndex = 2;
            this.TR.UseVisualStyleBackColor = true;
            this.TR.Click += new System.EventHandler(this.Mark);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(105, 426);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(75, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Aktualny ruch:";
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.Location = new System.Drawing.Point(187, 426);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(0, 13);
            this.currentPlayerLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentPlayerLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "-";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BR;
        private System.Windows.Forms.Button BC;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button CR;
        private System.Windows.Forms.Button CC;
        private System.Windows.Forms.Button CL;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.Button TC;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label currentPlayerLabel;
    }
}

