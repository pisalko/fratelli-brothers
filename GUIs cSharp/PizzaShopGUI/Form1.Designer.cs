﻿namespace SmallestFibonachiNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.chlbExtra = new System.Windows.Forms.CheckedListBox();
            this.btnToServer = new System.Windows.Forms.Button();
            this.comboBoxPizza = new System.Windows.Forms.ComboBox();
            this.textBoxPreferences = new System.Windows.Forms.TextBox();
            this.lbPreferences = new System.Windows.Forms.Label();
            this.listViewReadyOrders = new System.Windows.Forms.ListView();
            this.pbLipton = new System.Windows.Forms.PictureBox();
            this.pbSchweppes = new System.Windows.Forms.PictureBox();
            this.pbJuice = new System.Windows.Forms.PictureBox();
            this.pbPepsi = new System.Windows.Forms.PictureBox();
            this.pbFanta = new System.Windows.Forms.PictureBox();
            this.pbCola = new System.Windows.Forms.PictureBox();
            this.pbLargePizza = new System.Windows.Forms.PictureBox();
            this.pbMediumPizza = new System.Windows.Forms.PictureBox();
            this.pbSmallPizza = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCola = new System.Windows.Forms.Label();
            this.lbPepsi = new System.Windows.Forms.Label();
            this.lbFanta = new System.Windows.Forms.Label();
            this.lbJuice = new System.Windows.Forms.Label();
            this.lbLipton = new System.Windows.Forms.Label();
            this.lbSchweppes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLipton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchweppes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargePizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.FlatAppearance.BorderSize = 5;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.Location = new System.Drawing.Point(393, 508);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(217, 62);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.BackColor = System.Drawing.Color.Beige;
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(703, 172);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(255, 324);
            this.listBoxOrder.TabIndex = 3;
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chlbExtra
            // 
            this.chlbExtra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.chlbExtra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chlbExtra.CheckOnClick = true;
            this.chlbExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlbExtra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chlbExtra.FormattingEnabled = true;
            this.chlbExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chlbExtra.Items.AddRange(new object[] {
            "No Extras",
            "Extra Tomato sauce + $",
            "Extra mushrooms + $",
            "Extra onions + $",
            "Extra olives + $",
            "Extra cheese + $",
            "Extra rucola + $",
            "Philadelphia crust + $",
            "Italian-crafted base + $"});
            this.chlbExtra.Location = new System.Drawing.Point(45, 412);
            this.chlbExtra.Name = "chlbExtra";
            this.chlbExtra.Size = new System.Drawing.Size(261, 190);
            this.chlbExtra.TabIndex = 4;
            this.chlbExtra.UseCompatibleTextRendering = true;
            this.chlbExtra.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // btnToServer
            // 
            this.btnToServer.FlatAppearance.BorderSize = 5;
            this.btnToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToServer.Location = new System.Drawing.Point(703, 512);
            this.btnToServer.Name = "btnToServer";
            this.btnToServer.Size = new System.Drawing.Size(255, 63);
            this.btnToServer.TabIndex = 8;
            this.btnToServer.Text = "Finalize && Pay";
            this.btnToServer.UseVisualStyleBackColor = true;
            this.btnToServer.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboBoxPizza
            // 
            this.comboBoxPizza.BackColor = System.Drawing.Color.Beige;
            this.comboBoxPizza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPizza.FormattingEnabled = true;
            this.comboBoxPizza.Items.AddRange(new object[] {
            "Margherita",
            "Calzone",
            "Hawaii",
            "Pepperoni",
            "Vegan"});
            this.comboBoxPizza.Location = new System.Drawing.Point(45, 265);
            this.comboBoxPizza.Name = "comboBoxPizza";
            this.comboBoxPizza.Size = new System.Drawing.Size(261, 28);
            this.comboBoxPizza.TabIndex = 9;
            this.comboBoxPizza.Text = "Pizza";
            this.comboBoxPizza.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizza_SelectedIndexChanged);
            // 
            // textBoxPreferences
            // 
            this.textBoxPreferences.BackColor = System.Drawing.Color.Beige;
            this.textBoxPreferences.Location = new System.Drawing.Point(393, 201);
            this.textBoxPreferences.Multiline = true;
            this.textBoxPreferences.Name = "textBoxPreferences";
            this.textBoxPreferences.Size = new System.Drawing.Size(217, 81);
            this.textBoxPreferences.TabIndex = 10;
            // 
            // lbPreferences
            // 
            this.lbPreferences.AutoSize = true;
            this.lbPreferences.Location = new System.Drawing.Point(390, 166);
            this.lbPreferences.Name = "lbPreferences";
            this.lbPreferences.Size = new System.Drawing.Size(357, 17);
            this.lbPreferences.TabIndex = 11;
            this.lbPreferences.Text = "Any special preferences/request,\\r\\n please enter here:";
            this.lbPreferences.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listViewReadyOrders
            // 
            this.listViewReadyOrders.HideSelection = false;
            this.listViewReadyOrders.Location = new System.Drawing.Point(243, 26);
            this.listViewReadyOrders.Name = "listViewReadyOrders";
            this.listViewReadyOrders.Size = new System.Drawing.Size(689, 97);
            this.listViewReadyOrders.TabIndex = 28;
            this.listViewReadyOrders.UseCompatibleStateImageBehavior = false;
            // 
            // pbLipton
            // 
            this.pbLipton.Image = global::SmallestFibonachiNumber.Properties.Resources._69665995_482211882624268_5173394039105388544_n;
            this.pbLipton.Location = new System.Drawing.Point(463, 415);
            this.pbLipton.Name = "pbLipton";
            this.pbLipton.Size = new System.Drawing.Size(87, 80);
            this.pbLipton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLipton.TabIndex = 26;
            this.pbLipton.TabStop = false;
            this.pbLipton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLipton_MouseDown);
            // 
            // pbSchweppes
            // 
            this.pbSchweppes.Image = global::SmallestFibonachiNumber.Properties.Resources.schweps;
            this.pbSchweppes.Location = new System.Drawing.Point(565, 415);
            this.pbSchweppes.Name = "pbSchweppes";
            this.pbSchweppes.Size = new System.Drawing.Size(87, 80);
            this.pbSchweppes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSchweppes.TabIndex = 25;
            this.pbSchweppes.TabStop = false;
            this.pbSchweppes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSchweppes_MouseDown);
            // 
            // pbJuice
            // 
            this.pbJuice.Image = global::SmallestFibonachiNumber.Properties.Resources._57154590_828536920833012_710430390107504640_n;
            this.pbJuice.Location = new System.Drawing.Point(357, 415);
            this.pbJuice.Name = "pbJuice";
            this.pbJuice.Size = new System.Drawing.Size(87, 80);
            this.pbJuice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJuice.TabIndex = 24;
            this.pbJuice.TabStop = false;
            this.pbJuice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbJuice_MouseDown);
            // 
            // pbPepsi
            // 
            this.pbPepsi.Image = global::SmallestFibonachiNumber.Properties.Resources._70866405_242230256702466_3159342780040347648_n;
            this.pbPepsi.Location = new System.Drawing.Point(463, 314);
            this.pbPepsi.Name = "pbPepsi";
            this.pbPepsi.Size = new System.Drawing.Size(87, 80);
            this.pbPepsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPepsi.TabIndex = 22;
            this.pbPepsi.TabStop = false;
            this.pbPepsi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPepsi_MouseDown);
            // 
            // pbFanta
            // 
            this.pbFanta.Image = global::SmallestFibonachiNumber.Properties.Resources.fanta;
            this.pbFanta.Location = new System.Drawing.Point(565, 314);
            this.pbFanta.Name = "pbFanta";
            this.pbFanta.Size = new System.Drawing.Size(87, 80);
            this.pbFanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFanta.TabIndex = 21;
            this.pbFanta.TabStop = false;
            this.pbFanta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFanta_MouseDown);
            // 
            // pbCola
            // 
            this.pbCola.Image = global::SmallestFibonachiNumber.Properties.Resources._60317512_2715900981758696_5188495698168905728_n1;
            this.pbCola.Location = new System.Drawing.Point(357, 314);
            this.pbCola.Name = "pbCola";
            this.pbCola.Size = new System.Drawing.Size(87, 80);
            this.pbCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCola.TabIndex = 17;
            this.pbCola.TabStop = false;
            this.pbCola.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCola_MouseDown);
            // 
            // pbLargePizza
            // 
            this.pbLargePizza.Image = ((System.Drawing.Image)(resources.GetObject("pbLargePizza.Image")));
            this.pbLargePizza.Location = new System.Drawing.Point(191, 299);
            this.pbLargePizza.Name = "pbLargePizza";
            this.pbLargePizza.Size = new System.Drawing.Size(115, 107);
            this.pbLargePizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLargePizza.TabIndex = 16;
            this.pbLargePizza.TabStop = false;
            this.pbLargePizza.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbMediumPizza
            // 
            this.pbMediumPizza.Image = ((System.Drawing.Image)(resources.GetObject("pbMediumPizza.Image")));
            this.pbMediumPizza.Location = new System.Drawing.Point(101, 313);
            this.pbMediumPizza.Name = "pbMediumPizza";
            this.pbMediumPizza.Size = new System.Drawing.Size(84, 80);
            this.pbMediumPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMediumPizza.TabIndex = 15;
            this.pbMediumPizza.TabStop = false;
            this.pbMediumPizza.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbSmallPizza
            // 
            this.pbSmallPizza.Image = ((System.Drawing.Image)(resources.GetObject("pbSmallPizza.Image")));
            this.pbSmallPizza.Location = new System.Drawing.Point(45, 333);
            this.pbSmallPizza.Name = "pbSmallPizza";
            this.pbSmallPizza.Size = new System.Drawing.Size(50, 49);
            this.pbSmallPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPizza.TabIndex = 14;
            this.pbSmallPizza.TabStop = false;
            this.pbSmallPizza.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lbCola
            // 
            this.lbCola.AutoSize = true;
            this.lbCola.Location = new System.Drawing.Point(358, 296);
            this.lbCola.Name = "lbCola";
            this.lbCola.Size = new System.Drawing.Size(16, 17);
            this.lbCola.TabIndex = 29;
            this.lbCola.Text = "0";
            // 
            // lbPepsi
            // 
            this.lbPepsi.AutoSize = true;
            this.lbPepsi.Location = new System.Drawing.Point(464, 296);
            this.lbPepsi.Name = "lbPepsi";
            this.lbPepsi.Size = new System.Drawing.Size(16, 17);
            this.lbPepsi.TabIndex = 30;
            this.lbPepsi.Text = "0";
            // 
            // lbFanta
            // 
            this.lbFanta.AutoSize = true;
            this.lbFanta.Location = new System.Drawing.Point(562, 296);
            this.lbFanta.Name = "lbFanta";
            this.lbFanta.Size = new System.Drawing.Size(16, 17);
            this.lbFanta.TabIndex = 31;
            this.lbFanta.Text = "0";
            this.lbFanta.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lbJuice
            // 
            this.lbJuice.AutoSize = true;
            this.lbJuice.Location = new System.Drawing.Point(354, 397);
            this.lbJuice.Name = "lbJuice";
            this.lbJuice.Size = new System.Drawing.Size(16, 17);
            this.lbJuice.TabIndex = 32;
            this.lbJuice.Text = "0";
            // 
            // lbLipton
            // 
            this.lbLipton.AutoSize = true;
            this.lbLipton.Location = new System.Drawing.Point(460, 397);
            this.lbLipton.Name = "lbLipton";
            this.lbLipton.Size = new System.Drawing.Size(16, 17);
            this.lbLipton.TabIndex = 33;
            this.lbLipton.Text = "0";
            // 
            // lbSchweppes
            // 
            this.lbSchweppes.AutoSize = true;
            this.lbSchweppes.Location = new System.Drawing.Point(562, 397);
            this.lbSchweppes.Name = "lbSchweppes";
            this.lbSchweppes.Size = new System.Drawing.Size(16, 17);
            this.lbSchweppes.TabIndex = 34;
            this.lbSchweppes.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ordered Items:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(999, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbSchweppes);
            this.Controls.Add(this.lbLipton);
            this.Controls.Add(this.lbJuice);
            this.Controls.Add(this.lbFanta);
            this.Controls.Add(this.lbPepsi);
            this.Controls.Add(this.lbCola);
            this.Controls.Add(this.listViewReadyOrders);
            this.Controls.Add(this.pbLipton);
            this.Controls.Add(this.pbSchweppes);
            this.Controls.Add(this.pbJuice);
            this.Controls.Add(this.pbPepsi);
            this.Controls.Add(this.pbFanta);
            this.Controls.Add(this.pbCola);
            this.Controls.Add(this.pbLargePizza);
            this.Controls.Add(this.pbMediumPizza);
            this.Controls.Add(this.pbSmallPizza);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPreferences);
            this.Controls.Add(this.textBoxPreferences);
            this.Controls.Add(this.comboBoxPizza);
            this.Controls.Add(this.btnToServer);
            this.Controls.Add(this.chlbExtra);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.btnAddToOrder);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Fratelli Pizza Interface Cashier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLipton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSchweppes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJuice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargePizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediumPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.CheckedListBox chlbExtra;
        private System.Windows.Forms.Button btnToServer;
        private System.Windows.Forms.ComboBox comboBoxPizza;
        private System.Windows.Forms.TextBox textBoxPreferences;
        private System.Windows.Forms.Label lbPreferences;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbSmallPizza;
        private System.Windows.Forms.PictureBox pbMediumPizza;
        private System.Windows.Forms.PictureBox pbLargePizza;
        private System.Windows.Forms.PictureBox pbCola;
        private System.Windows.Forms.PictureBox pbFanta;
        private System.Windows.Forms.PictureBox pbPepsi;
        private System.Windows.Forms.PictureBox pbLipton;
        private System.Windows.Forms.PictureBox pbSchweppes;
        private System.Windows.Forms.PictureBox pbJuice;
        private System.Windows.Forms.ListView listViewReadyOrders;
        private System.Windows.Forms.Label lbCola;
        private System.Windows.Forms.Label lbPepsi;
        private System.Windows.Forms.Label lbFanta;
        private System.Windows.Forms.Label lbJuice;
        private System.Windows.Forms.Label lbLipton;
        private System.Windows.Forms.Label lbSchweppes;
        private System.Windows.Forms.Label label8;
    }
}

