namespace Character_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.convert1 = new System.Windows.Forms.Button();
            this.convert2 = new System.Windows.Forms.Button();
            this.output1 = new System.Windows.Forms.TextBox();
            this.output2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From characters to numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From numbers to characters:";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(15, 25);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(270, 131);
            this.textbox1.TabIndex = 2;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(344, 25);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(270, 131);
            this.textbox2.TabIndex = 3;
            // 
            // convert1
            // 
            this.convert1.Location = new System.Drawing.Point(15, 162);
            this.convert1.Name = "convert1";
            this.convert1.Size = new System.Drawing.Size(75, 23);
            this.convert1.TabIndex = 4;
            this.convert1.Text = "Convert";
            this.convert1.UseVisualStyleBackColor = true;
            this.convert1.Click += new System.EventHandler(this.convert1_Click);
            // 
            // convert2
            // 
            this.convert2.Location = new System.Drawing.Point(344, 162);
            this.convert2.Name = "convert2";
            this.convert2.Size = new System.Drawing.Size(75, 23);
            this.convert2.TabIndex = 5;
            this.convert2.Text = "Convert";
            this.convert2.UseVisualStyleBackColor = true;
            this.convert2.Click += new System.EventHandler(this.convert2_Click);
            // 
            // output1
            // 
            this.output1.Location = new System.Drawing.Point(12, 203);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(270, 20);
            this.output1.TabIndex = 6;
            // 
            // output2
            // 
            this.output2.Location = new System.Drawing.Point(344, 203);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(270, 20);
            this.output2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 267);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.convert2);
            this.Controls.Add(this.convert1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Button convert1;
        private System.Windows.Forms.Button convert2;
        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.TextBox output2;
    }
}

