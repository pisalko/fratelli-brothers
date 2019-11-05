namespace Java_server_attempt_1
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
            this.btnPOSTrequest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGETrequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPOSTrequest
            // 
            this.btnPOSTrequest.Location = new System.Drawing.Point(12, 237);
            this.btnPOSTrequest.Name = "btnPOSTrequest";
            this.btnPOSTrequest.Size = new System.Drawing.Size(365, 46);
            this.btnPOSTrequest.TabIndex = 0;
            this.btnPOSTrequest.Text = "POST request to server";
            this.btnPOSTrequest.UseVisualStyleBackColor = true;
            this.btnPOSTrequest.Click += new System.EventHandler(this.BtnSendToServer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 22);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(679, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 324);
            this.listBox1.TabIndex = 3;
            // 
            // btnGETrequest
            // 
            this.btnGETrequest.Location = new System.Drawing.Point(679, 422);
            this.btnGETrequest.Name = "btnGETrequest";
            this.btnGETrequest.Size = new System.Drawing.Size(278, 49);
            this.btnGETrequest.TabIndex = 4;
            this.btnGETrequest.Text = "GET request to server";
            this.btnGETrequest.UseVisualStyleBackColor = true;
            this.btnGETrequest.Click += new System.EventHandler(this.btnGETrequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGETrequest);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPOSTrequest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPOSTrequest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGETrequest;
    }
}

