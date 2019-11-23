namespace Luigi_GUI
{
    partial class LuigiGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuigiGUI));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbPizzaType = new System.Windows.Forms.Label();
            this.lbPizzaSize = new System.Windows.Forms.Label();
            this.lbPreferences = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(766, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "order goes in oven";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Orders"});
            this.listBox1.Location = new System.Drawing.Point(36, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(957, 289);
            this.listBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbPizzaType
            // 
            this.lbPizzaType.AutoSize = true;
            this.lbPizzaType.Location = new System.Drawing.Point(24, 13);
            this.lbPizzaType.Name = "lbPizzaType";
            this.lbPizzaType.Size = new System.Drawing.Size(78, 17);
            this.lbPizzaType.TabIndex = 15;
            this.lbPizzaType.Text = "Pizza Type";
            // 
            // lbPizzaSize
            // 
            this.lbPizzaSize.AutoSize = true;
            this.lbPizzaSize.Location = new System.Drawing.Point(137, 13);
            this.lbPizzaSize.Name = "lbPizzaSize";
            this.lbPizzaSize.Size = new System.Drawing.Size(73, 17);
            this.lbPizzaSize.TabIndex = 16;
            this.lbPizzaSize.Text = "Pizza Size";
            // 
            // lbPreferences
            // 
            this.lbPreferences.AutoSize = true;
            this.lbPreferences.Location = new System.Drawing.Point(226, 13);
            this.lbPreferences.Name = "lbPreferences";
            this.lbPreferences.Size = new System.Drawing.Size(47, 17);
            this.lbPreferences.TabIndex = 17;
            this.lbPreferences.Text = "Extras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(912, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "PizzaNumber";
            // 
            // LuigiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPreferences);
            this.Controls.Add(this.lbPizzaSize);
            this.Controls.Add(this.lbPizzaType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "LuigiGUI";
            this.Text = "Fratelli Pizza Interface Kitchen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPizzaType;
        private System.Windows.Forms.Label lbPizzaSize;
        private System.Windows.Forms.Label lbPreferences;
        private System.Windows.Forms.Label label1;
    }
}

