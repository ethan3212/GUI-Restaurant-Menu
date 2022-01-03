
namespace Manis_FinalExam_Q1_Restaurant
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
            this.dishListBox = new System.Windows.Forms.ListBox();
            this.sideListBox = new System.Windows.Forms.ListBox();
            this.dessertListBox = new System.Windows.Forms.ListBox();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dishListBox
            // 
            this.dishListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dishListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishListBox.FormattingEnabled = true;
            this.dishListBox.ItemHeight = 27;
            this.dishListBox.Items.AddRange(new object[] {
            "Biryani",
            "Mansaf",
            "Falafel",
            "Shawerma"});
            this.dishListBox.Location = new System.Drawing.Point(76, 153);
            this.dishListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dishListBox.Name = "dishListBox";
            this.dishListBox.Size = new System.Drawing.Size(203, 166);
            this.dishListBox.TabIndex = 0;
            this.dishListBox.SelectedIndexChanged += new System.EventHandler(this.dishListBox_SelectedIndexChanged);
            // 
            // sideListBox
            // 
            this.sideListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sideListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideListBox.FormattingEnabled = true;
            this.sideListBox.ItemHeight = 27;
            this.sideListBox.Items.AddRange(new object[] {
            "Fries",
            "Broccoli",
            "Ceasar Salad",
            "Greek Salad",
            "Yogurt"});
            this.sideListBox.Location = new System.Drawing.Point(451, 153);
            this.sideListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sideListBox.Name = "sideListBox";
            this.sideListBox.Size = new System.Drawing.Size(203, 166);
            this.sideListBox.TabIndex = 1;
            this.sideListBox.Visible = false;
            this.sideListBox.SelectedIndexChanged += new System.EventHandler(this.sideListBox_SelectedIndexChanged);
            // 
            // dessertListBox
            // 
            this.dessertListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dessertListBox.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dessertListBox.FormattingEnabled = true;
            this.dessertListBox.ItemHeight = 27;
            this.dessertListBox.Items.AddRange(new object[] {
            "Kanafeh",
            "Baklava",
            "Banana Pudding",
            "Apple Pie"});
            this.dessertListBox.Location = new System.Drawing.Point(831, 153);
            this.dessertListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dessertListBox.Name = "dessertListBox";
            this.dessertListBox.Size = new System.Drawing.Size(203, 166);
            this.dessertListBox.TabIndex = 2;
            this.dessertListBox.Visible = false;
            this.dessertListBox.SelectedIndexChanged += new System.EventHandler(this.dessertListBox_SelectedIndexChanged);
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutLabel.Location = new System.Drawing.Point(90, 464);
            this.outPutLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(0, 27);
            this.outPutLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Your Meal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.dessertListBox);
            this.Controls.Add(this.sideListBox);
            this.Controls.Add(this.dishListBox);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Manis_Restaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dishListBox;
        private System.Windows.Forms.ListBox sideListBox;
        private System.Windows.Forms.ListBox dessertListBox;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.Label label1;
    }
}

