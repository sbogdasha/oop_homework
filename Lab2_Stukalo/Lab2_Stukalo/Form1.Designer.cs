namespace Lab2_Stukalo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxBrand = new System.Windows.Forms.ComboBox();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.cBoxFabric = new System.Windows.Forms.ComboBox();
            this.cBoxColor = new System.Windows.Forms.ComboBox();
            this.cBoxSeason = new System.Windows.Forms.ComboBox();
            this.radioButtonDom = new System.Windows.Forms.RadioButton();
            this.radioButtonSax = new System.Windows.Forms.RadioButton();
            this.radioButtonLinq = new System.Windows.Forms.RadioButton();
            this.checkBoxBrand = new System.Windows.Forms.CheckBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxFabric = new System.Windows.Forms.CheckBox();
            this.checkBoxColor = new System.Windows.Forms.CheckBox();
            this.checkBoxSeason = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cBoxBrand
            // 
            this.cBoxBrand.FormattingEnabled = true;
            this.cBoxBrand.Location = new System.Drawing.Point(267, 42);
            this.cBoxBrand.Name = "cBoxBrand";
            this.cBoxBrand.Size = new System.Drawing.Size(169, 33);
            this.cBoxBrand.TabIndex = 0;
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Location = new System.Drawing.Point(267, 102);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(169, 33);
            this.cBoxType.TabIndex = 1;
            this.cBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cBoxFabric
            // 
            this.cBoxFabric.FormattingEnabled = true;
            this.cBoxFabric.Location = new System.Drawing.Point(267, 161);
            this.cBoxFabric.Name = "cBoxFabric";
            this.cBoxFabric.Size = new System.Drawing.Size(169, 33);
            this.cBoxFabric.TabIndex = 2;
            // 
            // cBoxColor
            // 
            this.cBoxColor.FormattingEnabled = true;
            this.cBoxColor.Location = new System.Drawing.Point(267, 215);
            this.cBoxColor.Name = "cBoxColor";
            this.cBoxColor.Size = new System.Drawing.Size(169, 33);
            this.cBoxColor.TabIndex = 3;
            // 
            // cBoxSeason
            // 
            this.cBoxSeason.FormattingEnabled = true;
            this.cBoxSeason.Location = new System.Drawing.Point(267, 270);
            this.cBoxSeason.Name = "cBoxSeason";
            this.cBoxSeason.Size = new System.Drawing.Size(169, 33);
            this.cBoxSeason.TabIndex = 4;
            // 
            // radioButtonDom
            // 
            this.radioButtonDom.AutoSize = true;
            this.radioButtonDom.Location = new System.Drawing.Point(133, 353);
            this.radioButtonDom.Name = "radioButtonDom";
            this.radioButtonDom.Size = new System.Drawing.Size(87, 29);
            this.radioButtonDom.TabIndex = 5;
            this.radioButtonDom.TabStop = true;
            this.radioButtonDom.Text = "Dom";
            this.radioButtonDom.UseVisualStyleBackColor = true;
            this.radioButtonDom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSax
            // 
            this.radioButtonSax.AutoSize = true;
            this.radioButtonSax.Location = new System.Drawing.Point(133, 399);
            this.radioButtonSax.Name = "radioButtonSax";
            this.radioButtonSax.Size = new System.Drawing.Size(80, 29);
            this.radioButtonSax.TabIndex = 6;
            this.radioButtonSax.TabStop = true;
            this.radioButtonSax.Text = "Sax";
            this.radioButtonSax.UseVisualStyleBackColor = true;
            this.radioButtonSax.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonLinq
            // 
            this.radioButtonLinq.AutoSize = true;
            this.radioButtonLinq.Location = new System.Drawing.Point(133, 443);
            this.radioButtonLinq.Name = "radioButtonLinq";
            this.radioButtonLinq.Size = new System.Drawing.Size(165, 29);
            this.radioButtonLinq.TabIndex = 7;
            this.radioButtonLinq.TabStop = true;
            this.radioButtonLinq.Text = "LINQ to XML";
            this.radioButtonLinq.UseVisualStyleBackColor = true;
            // 
            // checkBoxBrand
            // 
            this.checkBoxBrand.AutoSize = true;
            this.checkBoxBrand.Location = new System.Drawing.Point(67, 44);
            this.checkBoxBrand.Name = "checkBoxBrand";
            this.checkBoxBrand.Size = new System.Drawing.Size(101, 29);
            this.checkBoxBrand.TabIndex = 8;
            this.checkBoxBrand.Text = "Brand";
            this.checkBoxBrand.UseVisualStyleBackColor = true;
            this.checkBoxBrand.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(67, 104);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(92, 29);
            this.checkBoxType.TabIndex = 9;
            this.checkBoxType.Text = "Type";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // checkBoxFabric
            // 
            this.checkBoxFabric.AutoSize = true;
            this.checkBoxFabric.Location = new System.Drawing.Point(67, 161);
            this.checkBoxFabric.Name = "checkBoxFabric";
            this.checkBoxFabric.Size = new System.Drawing.Size(104, 29);
            this.checkBoxFabric.TabIndex = 10;
            this.checkBoxFabric.Text = "Fabric";
            this.checkBoxFabric.UseVisualStyleBackColor = true;
            // 
            // checkBoxColor
            // 
            this.checkBoxColor.AutoSize = true;
            this.checkBoxColor.Location = new System.Drawing.Point(67, 217);
            this.checkBoxColor.Name = "checkBoxColor";
            this.checkBoxColor.Size = new System.Drawing.Size(95, 29);
            this.checkBoxColor.TabIndex = 11;
            this.checkBoxColor.Text = "Color";
            this.checkBoxColor.UseVisualStyleBackColor = true;
            // 
            // checkBoxSeason
            // 
            this.checkBoxSeason.AutoSize = true;
            this.checkBoxSeason.Location = new System.Drawing.Point(67, 272);
            this.checkBoxSeason.Name = "checkBoxSeason";
            this.checkBoxSeason.Size = new System.Drawing.Size(117, 29);
            this.checkBoxSeason.TabIndex = 12;
            this.checkBoxSeason.Text = "Season";
            this.checkBoxSeason.UseVisualStyleBackColor = true;
            this.checkBoxSeason.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "Trasform";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(479, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(660, 569);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 651);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxSeason);
            this.Controls.Add(this.checkBoxColor);
            this.Controls.Add(this.checkBoxFabric);
            this.Controls.Add(this.checkBoxType);
            this.Controls.Add(this.checkBoxBrand);
            this.Controls.Add(this.radioButtonLinq);
            this.Controls.Add(this.radioButtonSax);
            this.Controls.Add(this.radioButtonDom);
            this.Controls.Add(this.cBoxSeason);
            this.Controls.Add(this.cBoxColor);
            this.Controls.Add(this.cBoxFabric);
            this.Controls.Add(this.cBoxType);
            this.Controls.Add(this.cBoxBrand);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 2 Стукало Богдан";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxBrand;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.ComboBox cBoxFabric;
        private System.Windows.Forms.ComboBox cBoxColor;
        private System.Windows.Forms.ComboBox cBoxSeason;
        private System.Windows.Forms.RadioButton radioButtonDom;
        private System.Windows.Forms.RadioButton radioButtonSax;
        private System.Windows.Forms.RadioButton radioButtonLinq;
        private System.Windows.Forms.CheckBox checkBoxBrand;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxFabric;
        private System.Windows.Forms.CheckBox checkBoxColor;
        private System.Windows.Forms.CheckBox checkBoxSeason;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

