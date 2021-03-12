
namespace Transactions
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
            this.Transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Transaction
            // 
            this.Transaction.Location = new System.Drawing.Point(298, 149);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(94, 30);
            this.Transaction.TabIndex = 0;
            this.Transaction.Text = "Transaction";
            this.Transaction.UseVisualStyleBackColor = true;
            this.Transaction.Click += new System.EventHandler(this.Transaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 369);
            this.Controls.Add(this.Transaction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Transaction;
    }
}

