namespace Chinookwin
{
    partial class Form1
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
            this.lbloperator = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbloperator
            // 
            this.lbloperator.AutoSize = true;
            this.lbloperator.Location = new System.Drawing.Point(146, 33);
            this.lbloperator.Name = "lbloperator";
            this.lbloperator.Size = new System.Drawing.Size(15, 15);
            this.lbloperator.TabIndex = 0;
            this.lbloperator.Text = "+";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(302, 33);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(26, 30);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 25);
            this.txtLeft.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(398, 34);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 25);
            this.txtResult.TabIndex = 2;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(181, 33);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 25);
            this.txtRight.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbloperator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloperator;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtRight;
    }
}

