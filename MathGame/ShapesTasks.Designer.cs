namespace MathGame
{
    partial class ShapesTasks
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.pnlShape = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(544, 433);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(332, 26);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check answer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.Location = new System.Drawing.Point(12, 9);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(78, 25);
            this.lblTries.TabIndex = 2;
            this.lblTries.Text = "Tries: 3";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAnswer.Location = new System.Drawing.Point(540, 38);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(179, 20);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "Enter your guess here:";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(544, 81);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(332, 22);
            this.tbAnswer.TabIndex = 5;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(645, 238);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 25);
            this.lblCorrect.TabIndex = 6;
            // 
            // pnlShape
            // 
            this.pnlShape.Location = new System.Drawing.Point(17, 38);
            this.pnlShape.Name = "pnlShape";
            this.pnlShape.Size = new System.Drawing.Size(505, 421);
            this.pnlShape.TabIndex = 7;
            this.pnlShape.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShape_Paint);
            // 
            // ShapesTasks
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(888, 471);
            this.Controls.Add(this.pnlShape);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.btnCheck);
            this.Name = "ShapesTasks";
            this.Text = "Guess the shape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel pnlShape;
    }
}