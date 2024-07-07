namespace MathGame
{
    partial class MathQuiz2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnForms = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(300, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to solve?";
            // 
            // btnForms
            // 
            this.btnForms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnForms.Location = new System.Drawing.Point(313, 127);
            this.btnForms.Name = "btnForms";
            this.btnForms.Size = new System.Drawing.Size(181, 50);
            this.btnForms.TabIndex = 1;
            this.btnForms.Text = "Guessing shapes";
            this.btnForms.UseVisualStyleBackColor = false;
            this.btnForms.Click += new System.EventHandler(this.btnForms_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTasks.Location = new System.Drawing.Point(313, 222);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(181, 50);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "Math problems";
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // MathQuiz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MathGame.Properties.Resources._360_F_337137820_IbhNE3TFIa9YblpTBBspBMBPU7vREpQN;
            this.ClientSize = new System.Drawing.Size(541, 361);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnForms);
            this.Controls.Add(this.label1);
            this.Name = "MathQuiz2";
            this.Text = "MathQuiz2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForms;
        private System.Windows.Forms.Button btnTasks;
    }
}