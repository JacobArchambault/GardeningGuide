namespace GardeningGuide
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmboFlowers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBxTrees = new System.Windows.Forms.ListBox();
            this.txtBxResultFlowers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxResultTrees = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(266, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark your selection";
            // 
            // cmboFlowers
            // 
            this.cmboFlowers.AutoCompleteCustomSource.AddRange(new string[] {
            "Roses",
            "Orchids",
            "Tulips",
            "Daisies",
            "Asters",
            "Mums"});
            this.cmboFlowers.FormattingEnabled = true;
            this.cmboFlowers.Items.AddRange(new object[] {
            "Roses",
            "Orchids",
            "Tulips",
            "Daisies",
            "Asters",
            "Mums"});
            this.cmboFlowers.Location = new System.Drawing.Point(72, 133);
            this.cmboFlowers.Name = "cmboFlowers";
            this.cmboFlowers.Size = new System.Drawing.Size(182, 33);
            this.cmboFlowers.TabIndex = 1;
            this.cmboFlowers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flowers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trees";
            // 
            // lstBxTrees
            // 
            this.lstBxTrees.FormattingEnabled = true;
            this.lstBxTrees.ItemHeight = 25;
            this.lstBxTrees.Items.AddRange(new object[] {
            "Maple",
            "Oak",
            "Palm",
            "Pine"});
            this.lstBxTrees.Location = new System.Drawing.Point(364, 133);
            this.lstBxTrees.Name = "lstBxTrees";
            this.lstBxTrees.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxTrees.Size = new System.Drawing.Size(180, 129);
            this.lstBxTrees.Sorted = true;
            this.lstBxTrees.TabIndex = 4;
            this.lstBxTrees.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBxResultFlowers
            // 
            this.txtBxResultFlowers.Location = new System.Drawing.Point(72, 315);
            this.txtBxResultFlowers.Name = "txtBxResultFlowers";
            this.txtBxResultFlowers.Size = new System.Drawing.Size(182, 31);
            this.txtBxResultFlowers.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Flower preference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tree preferences";
            // 
            // txtBxResultTrees
            // 
            this.txtBxResultTrees.Location = new System.Drawing.Point(364, 315);
            this.txtBxResultTrees.Name = "txtBxResultTrees";
            this.txtBxResultTrees.Size = new System.Drawing.Size(180, 31);
            this.txtBxResultTrees.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Type Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBxResultTrees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxResultFlowers);
            this.Controls.Add(this.lstBxTrees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboFlowers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Name = "Form1";
            this.Text = "Gardening Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBxTrees;
        private System.Windows.Forms.ComboBox cmboFlowers;
        private System.Windows.Forms.TextBox txtBxResultFlowers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxResultTrees;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

