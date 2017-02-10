namespace MultiConvMenu
{
    partial class MultiConvMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiConvMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToInchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBPToEURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURToGBPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celToFarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farToCelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBox = new System.Windows.Forms.TextBox();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.currencyToolStripMenuItem,
            this.temperatureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(236, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1
            // 
            this.menu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchesToFeetToolStripMenuItem,
            this.feetToInchesToolStripMenuItem});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(56, 20);
            this.menu1.Text = "Length";
            // 
            // inchesToFeetToolStripMenuItem
            // 
            this.inchesToFeetToolStripMenuItem.Name = "inchesToFeetToolStripMenuItem";
            this.inchesToFeetToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.inchesToFeetToolStripMenuItem.Text = "Inches to Feet";
            this.inchesToFeetToolStripMenuItem.Click += new System.EventHandler(this.inchesToFeetToolStripMenuItem_Click);
            // 
            // feetToInchesToolStripMenuItem
            // 
            this.feetToInchesToolStripMenuItem.Name = "feetToInchesToolStripMenuItem";
            this.feetToInchesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.feetToInchesToolStripMenuItem.Text = "Feet to Inches";
            this.feetToInchesToolStripMenuItem.Click += new System.EventHandler(this.feetToInchesToolStripMenuItem_Click);
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gBPToEURToolStripMenuItem,
            this.eURToGBPToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // gBPToEURToolStripMenuItem
            // 
            this.gBPToEURToolStripMenuItem.Name = "gBPToEURToolStripMenuItem";
            this.gBPToEURToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.gBPToEURToolStripMenuItem.Text = "GBP to EUR";
            this.gBPToEURToolStripMenuItem.Click += new System.EventHandler(this.gBPToEURToolStripMenuItem_Click);
            // 
            // eURToGBPToolStripMenuItem
            // 
            this.eURToGBPToolStripMenuItem.Name = "eURToGBPToolStripMenuItem";
            this.eURToGBPToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.eURToGBPToolStripMenuItem.Text = "EUR to GBP";
            this.eURToGBPToolStripMenuItem.Click += new System.EventHandler(this.eURToGBPToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celToFarToolStripMenuItem,
            this.farToCelToolStripMenuItem});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // celToFarToolStripMenuItem
            // 
            this.celToFarToolStripMenuItem.Name = "celToFarToolStripMenuItem";
            this.celToFarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.celToFarToolStripMenuItem.Text = "Cel to Far";
            this.celToFarToolStripMenuItem.Click += new System.EventHandler(this.celToFarToolStripMenuItem_Click);
            // 
            // farToCelToolStripMenuItem
            // 
            this.farToCelToolStripMenuItem.Name = "farToCelToolStripMenuItem";
            this.farToCelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.farToCelToolStripMenuItem.Text = "Far to Cel";
            this.farToCelToolStripMenuItem.Click += new System.EventHandler(this.farToCelToolStripMenuItem_Click);
            // 
            // tBox
            // 
            this.tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox.Enabled = false;
            this.tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox.Location = new System.Drawing.Point(12, 27);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(210, 29);
            this.tBox.TabIndex = 19;
            this.tBox.Text = "0";
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(12, 62);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(66, 40);
            this.B7.TabIndex = 20;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.B7_Click);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(84, 62);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(66, 40);
            this.B8.TabIndex = 21;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.B8_Click);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(156, 62);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(66, 40);
            this.B9.TabIndex = 22;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.B9_Click);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(12, 108);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(66, 40);
            this.B4.TabIndex = 23;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(84, 108);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(66, 40);
            this.B5.TabIndex = 24;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.B5_Click);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(156, 108);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(66, 40);
            this.B6.TabIndex = 25;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 154);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(66, 40);
            this.B1.TabIndex = 26;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(84, 154);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(66, 40);
            this.B2.TabIndex = 27;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click_1);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(156, 154);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(66, 40);
            this.B3.TabIndex = 28;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click_1);
            // 
            // clearB
            // 
            this.clearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearB.Location = new System.Drawing.Point(12, 200);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(66, 40);
            this.clearB.TabIndex = 31;
            this.clearB.Text = "C";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // B0
            // 
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(84, 199);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(66, 40);
            this.B0.TabIndex = 32;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.B0_Click_1);
            // 
            // bDot
            // 
            this.bDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDot.Location = new System.Drawing.Point(156, 199);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(66, 40);
            this.bDot.TabIndex = 33;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // MultiConvMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 251);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MultiConvMenu";
            this.Text = "MultiConverter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1;
        private System.Windows.Forms.ToolStripMenuItem inchesToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToInchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBPToEURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToGBPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celToFarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farToCelToolStripMenuItem;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button bDot;
    }
}

