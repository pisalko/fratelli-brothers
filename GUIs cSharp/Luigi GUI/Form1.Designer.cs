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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbPizzaType = new System.Windows.Forms.Label();
            this.lbPizzaSize = new System.Windows.Forms.Label();
            this.lbPreferences = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewReadyOrders = new System.Windows.Forms.ListView();
            this.lbReadyOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "Orders"});
            this.listBox1.Location = new System.Drawing.Point(27, 32);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(719, 232);
            this.listBox1.TabIndex = 1;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 331);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 90);
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
            this.lbPizzaType.Location = new System.Drawing.Point(18, 11);
            this.lbPizzaType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPizzaType.Name = "lbPizzaType";
            this.lbPizzaType.Size = new System.Drawing.Size(59, 13);
            this.lbPizzaType.TabIndex = 15;
            this.lbPizzaType.Text = "Pizza Type";
            // 
            // lbPizzaSize
            // 
            this.lbPizzaSize.AutoSize = true;
            this.lbPizzaSize.Location = new System.Drawing.Point(103, 11);
            this.lbPizzaSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPizzaSize.Name = "lbPizzaSize";
            this.lbPizzaSize.Size = new System.Drawing.Size(55, 13);
            this.lbPizzaSize.TabIndex = 16;
            this.lbPizzaSize.Text = "Pizza Size";
            // 
            // lbPreferences
            // 
            this.lbPreferences.AutoSize = true;
            this.lbPreferences.Location = new System.Drawing.Point(170, 11);
            this.lbPreferences.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPreferences.Name = "lbPreferences";
            this.lbPreferences.Size = new System.Drawing.Size(36, 13);
            this.lbPreferences.TabIndex = 17;
            this.lbPreferences.Text = "Extras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "PizzaNumber";
            // 
            // listViewReadyOrders
            // 
            this.listViewReadyOrders.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.listViewReadyOrders.GridLines = true;
            this.listViewReadyOrders.HideSelection = false;
            this.listViewReadyOrders.Location = new System.Drawing.Point(270, 274);
            this.listViewReadyOrders.Margin = new System.Windows.Forms.Padding(2);
            this.listViewReadyOrders.Name = "listViewReadyOrders";
            this.listViewReadyOrders.Size = new System.Drawing.Size(476, 147);
            this.listViewReadyOrders.TabIndex = 29;
            this.listViewReadyOrders.TileSize = new System.Drawing.Size(200, 36);
            this.listViewReadyOrders.UseCompatibleStateImageBehavior = false;
            this.listViewReadyOrders.View = System.Windows.Forms.View.SmallIcon;
            this.listViewReadyOrders.MouseEnter += new System.EventHandler(this.listViewReadyOrders_MouseEnter);
            // 
            // lbReadyOrders
            // 
            this.lbReadyOrders.AutoSize = true;
            this.lbReadyOrders.Location = new System.Drawing.Point(195, 340);
            this.lbReadyOrders.Name = "lbReadyOrders";
            this.lbReadyOrders.Size = new System.Drawing.Size(35, 13);
            this.lbReadyOrders.TabIndex = 30;
            this.lbReadyOrders.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "label2";
            // 
            // LuigiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(767, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReadyOrders);
            this.Controls.Add(this.listViewReadyOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPreferences);
            this.Controls.Add(this.lbPizzaSize);
            this.Controls.Add(this.lbPizzaType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LuigiGUI";
            this.Text = "Fratelli Pizza Interface Kitchen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbPizzaType;
        private System.Windows.Forms.Label lbPizzaSize;
        private System.Windows.Forms.Label lbPreferences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewReadyOrders;
        private System.Windows.Forms.Label lbReadyOrders;
        private System.Windows.Forms.Label label2;
    }
}

