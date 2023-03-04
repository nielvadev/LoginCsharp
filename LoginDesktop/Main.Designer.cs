namespace LoginDesktop
{
    partial class Main
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
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.lblConvert = new System.Windows.Forms.Label();
            this.lblConvertTitle = new System.Windows.Forms.Label();
            this.lblFiboTitle = new System.Windows.Forms.Label();
            this.lblFibo = new System.Windows.Forms.Label();
            this.txtFibo = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnFibo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(85, 141);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(125, 27);
            this.txtConvert.TabIndex = 0;
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(85, 117);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(88, 20);
            this.lblConvert.TabIndex = 1;
            this.lblConvert.Text = "USD to COP";
            // 
            // lblConvertTitle
            // 
            this.lblConvertTitle.AutoSize = true;
            this.lblConvertTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConvertTitle.Location = new System.Drawing.Point(85, 67);
            this.lblConvertTitle.Name = "lblConvertTitle";
            this.lblConvertTitle.Size = new System.Drawing.Size(261, 28);
            this.lblConvertTitle.TabIndex = 2;
            this.lblConvertTitle.Text = "Currency Converter";
            // 
            // lblFiboTitle
            // 
            this.lblFiboTitle.AutoSize = true;
            this.lblFiboTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiboTitle.Location = new System.Drawing.Point(421, 67);
            this.lblFiboTitle.Name = "lblFiboTitle";
            this.lblFiboTitle.Size = new System.Drawing.Size(270, 28);
            this.lblFiboTitle.TabIndex = 3;
            this.lblFiboTitle.Text = "Fibonacci Generator";
            // 
            // lblFibo
            // 
            this.lblFibo.AutoSize = true;
            this.lblFibo.Location = new System.Drawing.Point(421, 117);
            this.lblFibo.Name = "lblFibo";
            this.lblFibo.Size = new System.Drawing.Size(162, 20);
            this.lblFibo.TabIndex = 4;
            this.lblFibo.Text = "Insert limit to fibonacci";
            // 
            // txtFibo
            // 
            this.txtFibo.Location = new System.Drawing.Point(421, 141);
            this.txtFibo.Name = "txtFibo";
            this.txtFibo.Size = new System.Drawing.Size(125, 27);
            this.txtFibo.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(85, 194);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(421, 194);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(94, 29);
            this.btnFibo.TabIndex = 7;
            this.btnFibo.Text = "Generate";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Juan Daniel Valencia y Victor Palma";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtFibo);
            this.Controls.Add(this.lblFibo);
            this.Controls.Add(this.lblFiboTitle);
            this.Controls.Add(this.lblConvertTitle);
            this.Controls.Add(this.lblConvert);
            this.Controls.Add(this.txtConvert);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtConvert;
        private Label lblConvert;
        private Label lblConvertTitle;
        private Label lblFiboTitle;
        private Label lblFibo;
        private TextBox txtFibo;
        private Button btnConvert;
        private Button btnFibo;
        private Label label1;
        private Label label2;
    }
}