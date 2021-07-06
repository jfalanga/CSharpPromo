
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadMug = new System.Windows.Forms.RadioButton();
            this.RadUSB = new System.Windows.Forms.RadioButton();
            this.RadPen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOrdNum = new System.Windows.Forms.TextBox();
            this.TxtINum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.TxtSummery = new System.Windows.Forms.TextBox();
            this.ChkLogo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtNumColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadMug);
            this.groupBox1.Controls.Add(this.RadUSB);
            this.groupBox1.Controls.Add(this.RadPen);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Type:";
            // 
            // RadMug
            // 
            this.RadMug.AutoSize = true;
            this.RadMug.Checked = true;
            this.RadMug.Location = new System.Drawing.Point(27, 56);
            this.RadMug.Name = "RadMug";
            this.RadMug.Size = new System.Drawing.Size(66, 24);
            this.RadMug.TabIndex = 2;
            this.RadMug.TabStop = true;
            this.RadMug.Text = "Mugs";
            this.RadMug.UseVisualStyleBackColor = true;
            this.RadMug.CheckedChanged += new System.EventHandler(this.RadMug_CheckedChanged);
            // 
            // RadUSB
            // 
            this.RadUSB.AutoSize = true;
            this.RadUSB.Location = new System.Drawing.Point(45, 86);
            this.RadUSB.Name = "RadUSB";
            this.RadUSB.Size = new System.Drawing.Size(112, 24);
            this.RadUSB.TabIndex = 1;
            this.RadUSB.Text = "USB Devices";
            this.RadUSB.UseVisualStyleBackColor = true;
            this.RadUSB.CheckedChanged += new System.EventHandler(this.RadUSB_CheckedChanged);
            // 
            // RadPen
            // 
            this.RadPen.AutoSize = true;
            this.RadPen.Location = new System.Drawing.Point(6, 26);
            this.RadPen.Name = "RadPen";
            this.RadPen.Size = new System.Drawing.Size(59, 24);
            this.RadPen.TabIndex = 0;
            this.RadPen.Text = "Pens";
            this.RadPen.UseVisualStyleBackColor = true;
            this.RadPen.CheckedChanged += new System.EventHandler(this.RadPen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Number:";
            // 
            // TxtOrdNum
            // 
            this.TxtOrdNum.Location = new System.Drawing.Point(109, 12);
            this.TxtOrdNum.Name = "TxtOrdNum";
            this.TxtOrdNum.Size = new System.Drawing.Size(79, 27);
            this.TxtOrdNum.TabIndex = 2;
            this.TxtOrdNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtINum
            // 
            this.TxtINum.Location = new System.Drawing.Point(109, 54);
            this.TxtINum.Name = "TxtINum";
            this.TxtINum.Size = new System.Drawing.Size(79, 27);
            this.TxtINum.TabIndex = 4;
            this.TxtINum.TextChanged += new System.EventHandler(this.TxtINum_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item amount:";
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(12, 179);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(169, 20);
            this.LblText.TabIndex = 5;
            this.LblText.Text = "Text to put on the mugs:";
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(12, 202);
            this.TxtText.Multiline = true;
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(184, 68);
            this.TxtText.TabIndex = 6;
            // 
            // TxtSummery
            // 
            this.TxtSummery.Location = new System.Drawing.Point(12, 293);
            this.TxtSummery.Multiline = true;
            this.TxtSummery.Name = "TxtSummery";
            this.TxtSummery.ReadOnly = true;
            this.TxtSummery.Size = new System.Drawing.Size(371, 72);
            this.TxtSummery.TabIndex = 8;
            // 
            // ChkLogo
            // 
            this.ChkLogo.AutoSize = true;
            this.ChkLogo.Location = new System.Drawing.Point(7, 96);
            this.ChkLogo.Name = "ChkLogo";
            this.ChkLogo.Size = new System.Drawing.Size(181, 24);
            this.ChkLogo.TabIndex = 9;
            this.ChkLogo.Text = "Shall they have Logos?";
            this.ChkLogo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(245, 241);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 29);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            // 
            // TxtNumColor
            // 
            this.TxtNumColor.Location = new System.Drawing.Point(109, 126);
            this.TxtNumColor.Name = "TxtNumColor";
            this.TxtNumColor.Size = new System.Drawing.Size(79, 27);
            this.TxtNumColor.TabIndex = 13;
            this.TxtNumColor.TextChanged += new System.EventHandler(this.TxtNumColor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 377);
            this.Controls.Add(this.TxtNumColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkLogo);
            this.Controls.Add(this.TxtSummery);
            this.Controls.Add(this.TxtText);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.TxtINum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOrdNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cost of C# Promotional Items";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadMug;
        private System.Windows.Forms.RadioButton RadUSB;
        private System.Windows.Forms.RadioButton RadPen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOrdNum;
        private System.Windows.Forms.TextBox TxtINum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.TextBox TxtSummery;
        private System.Windows.Forms.CheckBox ChkLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtNumColor;
        private System.Windows.Forms.Label label3;
    }
}

