
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timerLog = new System.Windows.Forms.Timer(this.components);
            this.checkBoxPly2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPly3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPly4 = new System.Windows.Forms.CheckBox();
            this.checkBoxPly5 = new System.Windows.Forms.CheckBox();
            this.checkBoxPly6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLog
            // 
            this.timerLog.Enabled = true;
            this.timerLog.Interval = 1000;
            this.timerLog.Tick += new System.EventHandler(this.Logging);
            // 
            // checkBoxPly2
            // 
            this.checkBoxPly2.AutoSize = true;
            this.checkBoxPly2.Location = new System.Drawing.Point(134, 13);
            this.checkBoxPly2.Name = "checkBoxPly2";
            this.checkBoxPly2.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPly2.TabIndex = 0;
            this.checkBoxPly2.Text = "PLY 2";
            this.checkBoxPly2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPly3
            // 
            this.checkBoxPly3.AutoSize = true;
            this.checkBoxPly3.Location = new System.Drawing.Point(134, 37);
            this.checkBoxPly3.Name = "checkBoxPly3";
            this.checkBoxPly3.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPly3.TabIndex = 1;
            this.checkBoxPly3.Text = "PLY 3";
            this.checkBoxPly3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPly4
            // 
            this.checkBoxPly4.AutoSize = true;
            this.checkBoxPly4.Location = new System.Drawing.Point(134, 61);
            this.checkBoxPly4.Name = "checkBoxPly4";
            this.checkBoxPly4.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPly4.TabIndex = 2;
            this.checkBoxPly4.Text = "PLY 4";
            this.checkBoxPly4.UseVisualStyleBackColor = true;
            // 
            // checkBoxPly5
            // 
            this.checkBoxPly5.AutoSize = true;
            this.checkBoxPly5.Location = new System.Drawing.Point(134, 85);
            this.checkBoxPly5.Name = "checkBoxPly5";
            this.checkBoxPly5.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPly5.TabIndex = 3;
            this.checkBoxPly5.Text = "PLY 5";
            this.checkBoxPly5.UseVisualStyleBackColor = true;
            // 
            // checkBoxPly6
            // 
            this.checkBoxPly6.AutoSize = true;
            this.checkBoxPly6.Location = new System.Drawing.Point(134, 109);
            this.checkBoxPly6.Name = "checkBoxPly6";
            this.checkBoxPly6.Size = new System.Drawing.Size(55, 17);
            this.checkBoxPly6.TabIndex = 4;
            this.checkBoxPly6.Text = "PLY 6";
            this.checkBoxPly6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select for observation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tag name:";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(16, 33);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(198, 20);
            this.textBoxTag.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 265);
            this.label10.MaximumSize = new System.Drawing.Size(288, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Folder for file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logging period:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "30 sec",
            "1 min",
            "2 min",
            "5 min",
            "10 min",
            "30 min"});
            this.comboBox1.Location = new System.Drawing.Point(14, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "1 sec";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = "Start logging with new tag";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxPly6);
            this.groupBox1.Controls.Add(this.checkBoxPly5);
            this.groupBox1.Controls.Add(this.checkBoxPly4);
            this.groupBox1.Controls.Add(this.checkBoxPly3);
            this.groupBox1.Controls.Add(this.checkBoxPly2);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 131);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxTag);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 94);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 20;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 295);
            this.label8.MinimumSize = new System.Drawing.Size(288, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 13);
            this.label8.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 384);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Name = "Form1";
            this.Text = "Logger for PlyCutters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLog;
        private System.Windows.Forms.CheckBox checkBoxPly2;
        private System.Windows.Forms.CheckBox checkBoxPly3;
        private System.Windows.Forms.CheckBox checkBoxPly4;
        private System.Windows.Forms.CheckBox checkBoxPly5;
        private System.Windows.Forms.CheckBox checkBoxPly6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}

