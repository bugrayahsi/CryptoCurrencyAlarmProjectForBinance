namespace CryptoCurrencyAlarmProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPairs = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addAlarmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showActiveAlarmsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.strtConnectionButton = new System.Windows.Forms.Button();
            this.RemoveAlarmTextBox = new System.Windows.Forms.TextBox();
            this.RemoveAlarmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPairs
            // 
            this.comboBoxPairs.FormattingEnabled = true;
            this.comboBoxPairs.Location = new System.Drawing.Point(13, 13);
            this.comboBoxPairs.Name = "comboBoxPairs";
            this.comboBoxPairs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPairs.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // addAlarmButton
            // 
            this.addAlarmButton.Location = new System.Drawing.Point(13, 104);
            this.addAlarmButton.Name = "addAlarmButton";
            this.addAlarmButton.Size = new System.Drawing.Size(100, 23);
            this.addAlarmButton.TabIndex = 3;
            this.addAlarmButton.Text = "ADD ALARM";
            this.addAlarmButton.UseVisualStyleBackColor = true;
            this.addAlarmButton.Click += new System.EventHandler(this.addAlarmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "When price rises above";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "When price drops below";
            // 
            // showActiveAlarmsRichTextBox
            // 
            this.showActiveAlarmsRichTextBox.Enabled = false;
            this.showActiveAlarmsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showActiveAlarmsRichTextBox.Location = new System.Drawing.Point(572, 13);
            this.showActiveAlarmsRichTextBox.Name = "showActiveAlarmsRichTextBox";
            this.showActiveAlarmsRichTextBox.Size = new System.Drawing.Size(216, 277);
            this.showActiveAlarmsRichTextBox.TabIndex = 6;
            this.showActiveAlarmsRichTextBox.Text = "";
            // 
            // strtConnectionButton
            // 
            this.strtConnectionButton.Location = new System.Drawing.Point(327, 10);
            this.strtConnectionButton.Name = "strtConnectionButton";
            this.strtConnectionButton.Size = new System.Drawing.Size(141, 23);
            this.strtConnectionButton.TabIndex = 7;
            this.strtConnectionButton.Text = "START CONNECTION";
            this.strtConnectionButton.UseVisualStyleBackColor = true;
            this.strtConnectionButton.Click += new System.EventHandler(this.strtConnectionButton_Click);
            // 
            // RemoveAlarmTextBox
            // 
            this.RemoveAlarmTextBox.Location = new System.Drawing.Point(572, 297);
            this.RemoveAlarmTextBox.Name = "RemoveAlarmTextBox";
            this.RemoveAlarmTextBox.Size = new System.Drawing.Size(100, 20);
            this.RemoveAlarmTextBox.TabIndex = 8;
            // 
            // RemoveAlarmButton
            // 
            this.RemoveAlarmButton.Location = new System.Drawing.Point(572, 359);
            this.RemoveAlarmButton.Name = "RemoveAlarmButton";
            this.RemoveAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAlarmButton.TabIndex = 9;
            this.RemoveAlarmButton.Text = "REMOVE";
            this.RemoveAlarmButton.UseVisualStyleBackColor = true;
            this.RemoveAlarmButton.Click += new System.EventHandler(this.RemoveAlarmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the number of the alarm you want to remove.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveAlarmButton);
            this.Controls.Add(this.RemoveAlarmTextBox);
            this.Controls.Add(this.strtConnectionButton);
            this.Controls.Add(this.showActiveAlarmsRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAlarmButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxPairs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPairs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addAlarmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox showActiveAlarmsRichTextBox;
        private System.Windows.Forms.Button strtConnectionButton;
        private System.Windows.Forms.TextBox RemoveAlarmTextBox;
        private System.Windows.Forms.Button RemoveAlarmButton;
        private System.Windows.Forms.Label label3;
    }
}

