namespace WindowsForms
{
    partial class Cashier
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox8.Location = new System.Drawing.Point(6, 16);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox8.Size = new System.Drawing.Size(526, 192);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(324, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 239);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Обмен валюты";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Location = new System.Drawing.Point(6, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 53);
            this.panel5.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(413, 47);
            this.button6.TabIndex = 3;
            this.button6.Text = "совершить обмен";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 53);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.domainUpDown2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.domainUpDown1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("BYN");
            this.domainUpDown2.Items.Add("RUB");
            this.domainUpDown2.Items.Add("EUR");
            this.domainUpDown2.Items.Add("USD");
            this.domainUpDown2.Items.Add("JPY");
            this.domainUpDown2.Items.Add("GBR");
            this.domainUpDown2.Items.Add("CHF");
            this.domainUpDown2.Location = new System.Drawing.Point(212, 3);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(204, 26);
            this.domainUpDown2.TabIndex = 5;
            this.domainUpDown2.Text = "Валюта для покупки";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 46);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 26);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "введите сумму";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(212, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(204, 26);
            this.textBox7.TabIndex = 3;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("BYN");
            this.domainUpDown1.Items.Add("RUB");
            this.domainUpDown1.Items.Add("EUR");
            this.domainUpDown1.Items.Add("USD");
            this.domainUpDown1.Items.Add("JPY");
            this.domainUpDown1.Items.Add("GBR");
            this.domainUpDown1.Items.Add("CHF");
            this.domainUpDown1.Location = new System.Drawing.Point(3, 3);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(203, 26);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "Валюта для продажи";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 198);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 53);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "проверить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(556, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 86);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 77);
            this.button3.TabIndex = 0;
            this.button3.Text = "завершить операцию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "Узнать курс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(556, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 106);
            this.panel4.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 74);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(176, 28);
            this.button7.TabIndex = 0;
            this.button7.Text = "выйти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "посмотреть ограничения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 29);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер паспорта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о клиенте";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
    }
}