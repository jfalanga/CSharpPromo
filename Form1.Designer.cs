
namespace CSharpPromo
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
            this.ChkPens = new System.Windows.Forms.CheckBox();
            this.TxtPens = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUSB = new System.Windows.Forms.TextBox();
            this.ChkUSB = new System.Windows.Forms.CheckBox();
            this.TxtCoffee = new System.Windows.Forms.TextBox();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ChkPens
            // 
            this.ChkPens.AutoSize = true;
            this.ChkPens.Location = new System.Drawing.Point(34, 49);
            this.ChkPens.Name = "ChkPens";
            this.ChkPens.Size = new System.Drawing.Size(60, 24);
            this.ChkPens.TabIndex = 0;
            this.ChkPens.Text = "Pens";
            this.ChkPens.UseVisualStyleBackColor = true;
            this.ChkPens.CheckedChanged += new System.EventHandler(this.ChkChanged);
            // 
            // TxtPens
            // 
            this.TxtPens.Enabled = false;
            this.TxtPens.Location = new System.Drawing.Point(156, 47);
            this.TxtPens.Name = "TxtPens";
            this.TxtPens.Size = new System.Drawing.Size(66, 27);
            this.TxtPens.TabIndex = 1;
            this.TxtPens.Text = "0";
            this.TxtPens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPens.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Items:";
            // 
            // TxtUSB
            // 
            this.TxtUSB.Enabled = false;
            this.TxtUSB.Location = new System.Drawing.Point(156, 80);
            this.TxtUSB.Name = "TxtUSB";
            this.TxtUSB.Size = new System.Drawing.Size(66, 27);
            this.TxtUSB.TabIndex = 4;
            this.TxtUSB.Text = "0";
            this.TxtUSB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtUSB.TextChanged += new System.EventHandler(this.TxtUSB_TextChanged);
            // 
            // ChkUSB
            // 
            this.ChkUSB.AutoSize = true;
            this.ChkUSB.Location = new System.Drawing.Point(34, 82);
            this.ChkUSB.Name = "ChkUSB";
            this.ChkUSB.Size = new System.Drawing.Size(113, 24);
            this.ChkUSB.TabIndex = 3;
            this.ChkUSB.Text = "USB Devices";
            this.ChkUSB.UseVisualStyleBackColor = true;
            this.ChkUSB.CheckedChanged += new System.EventHandler(this.ChkChanged);
            // 
            // TxtCoffee
            // 
            this.TxtCoffee.Enabled = false;
            this.TxtCoffee.Location = new System.Drawing.Point(156, 113);
            this.TxtCoffee.Name = "TxtCoffee";
            this.TxtCoffee.Size = new System.Drawing.Size(66, 27);
            this.TxtCoffee.TabIndex = 6;
            this.TxtCoffee.Text = "0";
            this.TxtCoffee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCoffee.UseWaitCursor = true;
            this.TxtCoffee.TextChanged += new System.EventHandler(this.TxtCoffee_TextChanged);
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(34, 115);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(115, 24);
            this.ChkCoffee.TabIndex = 5;
            this.ChkCoffee.Text = "Coffee Mugs";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            this.ChkCoffee.CheckedChanged += new System.EventHandler(this.ChkCanged);
            this.ChkCoffee.CheckStateChanged += new System.EventHandler(this.ChkCanged);
            this.ChkCoffee.TextChanged += new System.EventHandler(this.ChkChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 315);
            this.Controls.Add(this.TxtCoffee);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.TxtUSB);
            this.Controls.Add(this.ChkUSB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPens);
            this.Controls.Add(this.ChkPens);
            this.Name = "Form1";
            this.Text = "Cost of C# Promotional Items";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkPens;
        private System.Windows.Forms.TextBox TxtPens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUSB;
        private System.Windows.Forms.CheckBox ChkUSB;
        private System.Windows.Forms.TextBox TxtCoffee;
        private System.Windows.Forms.CheckBox ChkCoffee;
    }
}

