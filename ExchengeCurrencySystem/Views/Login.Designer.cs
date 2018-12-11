namespace WindowsForms
{
    partial class Login
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
            this.btnEnterView = new System.Windows.Forms.Button();
            this.grpBoxRolesView = new System.Windows.Forms.GroupBox();
            this.rbtnCashierView = new System.Windows.Forms.RadioButton();
            this.rbtnAdminView = new System.Windows.Forms.RadioButton();
            this.grpBoxCashiersView = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCashier5View = new System.Windows.Forms.RadioButton();
            this.rbtnCashier4View = new System.Windows.Forms.RadioButton();
            this.rbtnCashier3View = new System.Windows.Forms.RadioButton();
            this.rbtnCashier2View = new System.Windows.Forms.RadioButton();
            this.rbtnCashier1View = new System.Windows.Forms.RadioButton();
            this.grpBoxRolesView.SuspendLayout();
            this.grpBoxCashiersView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterView
            // 
            this.btnEnterView.Location = new System.Drawing.Point(248, 208);
            this.btnEnterView.Name = "btnEnterView";
            this.btnEnterView.Size = new System.Drawing.Size(254, 68);
            this.btnEnterView.TabIndex = 1;
            this.btnEnterView.Text = "Войти";
            this.btnEnterView.UseVisualStyleBackColor = true;
            this.btnEnterView.Click += new System.EventHandler(this.btnEnter);
            // 
            // grpBoxRolesView
            // 
            this.grpBoxRolesView.Controls.Add(this.rbtnCashierView);
            this.grpBoxRolesView.Controls.Add(this.rbtnAdminView);
            this.grpBoxRolesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxRolesView.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRolesView.Name = "grpBoxRolesView";
            this.grpBoxRolesView.Size = new System.Drawing.Size(223, 264);
            this.grpBoxRolesView.TabIndex = 2;
            this.grpBoxRolesView.TabStop = false;
            this.grpBoxRolesView.Enter += new System.EventHandler(this.grpBoxRoles);
            // 
            // rbtnCashierView
            // 
            this.rbtnCashierView.AutoSize = true;
            this.rbtnCashierView.Location = new System.Drawing.Point(7, 67);
            this.rbtnCashierView.Name = "rbtnCashierView";
            this.rbtnCashierView.Size = new System.Drawing.Size(92, 28);
            this.rbtnCashierView.TabIndex = 1;
            this.rbtnCashierView.TabStop = true;
            this.rbtnCashierView.Text = "Кассир";
            this.rbtnCashierView.UseVisualStyleBackColor = true;
            this.rbtnCashierView.CheckedChanged += new System.EventHandler(this.rbtnCashier);
            // 
            // rbtnAdminView
            // 
            this.rbtnAdminView.AutoSize = true;
            this.rbtnAdminView.Location = new System.Drawing.Point(7, 31);
            this.rbtnAdminView.Name = "rbtnAdminView";
            this.rbtnAdminView.Size = new System.Drawing.Size(172, 28);
            this.rbtnAdminView.TabIndex = 0;
            this.rbtnAdminView.TabStop = true;
            this.rbtnAdminView.Text = "Администратор";
            this.rbtnAdminView.UseVisualStyleBackColor = true;
            this.rbtnAdminView.CheckedChanged += new System.EventHandler(this.rbtnAdmin);
            // 
            // grpBoxCashiersView
            // 
            this.grpBoxCashiersView.Controls.Add(this.panel1);
            this.grpBoxCashiersView.Location = new System.Drawing.Point(241, 12);
            this.grpBoxCashiersView.Name = "grpBoxCashiersView";
            this.grpBoxCashiersView.Size = new System.Drawing.Size(261, 190);
            this.grpBoxCashiersView.TabIndex = 3;
            this.grpBoxCashiersView.TabStop = false;
            this.grpBoxCashiersView.Text = "Кассиры";
            this.grpBoxCashiersView.Enter += new System.EventHandler(this.grpBoxCashiers);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.rbtnCashier5View);
            this.panel1.Controls.Add(this.rbtnCashier4View);
            this.panel1.Controls.Add(this.rbtnCashier3View);
            this.panel1.Controls.Add(this.rbtnCashier2View);
            this.panel1.Controls.Add(this.rbtnCashier1View);
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 154);
            this.panel1.TabIndex = 0;
            // 
            // rbtnCashier5View
            // 
            this.rbtnCashier5View.AutoSize = true;
            this.rbtnCashier5View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCashier5View.Location = new System.Drawing.Point(3, 139);
            this.rbtnCashier5View.Name = "rbtnCashier5View";
            this.rbtnCashier5View.Size = new System.Drawing.Size(112, 28);
            this.rbtnCashier5View.TabIndex = 7;
            this.rbtnCashier5View.TabStop = true;
            this.rbtnCashier5View.Text = "Кассир_5";
            this.rbtnCashier5View.UseVisualStyleBackColor = true;
            this.rbtnCashier5View.CheckedChanged += new System.EventHandler(this.rbtnCashier5);
            // 
            // rbtnCashier4View
            // 
            this.rbtnCashier4View.AutoSize = true;
            this.rbtnCashier4View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCashier4View.Location = new System.Drawing.Point(3, 105);
            this.rbtnCashier4View.Name = "rbtnCashier4View";
            this.rbtnCashier4View.Size = new System.Drawing.Size(112, 28);
            this.rbtnCashier4View.TabIndex = 6;
            this.rbtnCashier4View.TabStop = true;
            this.rbtnCashier4View.Text = "Кассир_4";
            this.rbtnCashier4View.UseVisualStyleBackColor = true;
            this.rbtnCashier4View.CheckedChanged += new System.EventHandler(this.rbtnCashier4);
            // 
            // rbtnCashier3View
            // 
            this.rbtnCashier3View.AutoSize = true;
            this.rbtnCashier3View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCashier3View.Location = new System.Drawing.Point(3, 71);
            this.rbtnCashier3View.Name = "rbtnCashier3View";
            this.rbtnCashier3View.Size = new System.Drawing.Size(112, 28);
            this.rbtnCashier3View.TabIndex = 5;
            this.rbtnCashier3View.TabStop = true;
            this.rbtnCashier3View.Text = "Кассир_3";
            this.rbtnCashier3View.UseVisualStyleBackColor = true;
            this.rbtnCashier3View.CheckedChanged += new System.EventHandler(this.rbtnCashier3);
            // 
            // rbtnCashier2View
            // 
            this.rbtnCashier2View.AutoSize = true;
            this.rbtnCashier2View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCashier2View.Location = new System.Drawing.Point(3, 37);
            this.rbtnCashier2View.Name = "rbtnCashier2View";
            this.rbtnCashier2View.Size = new System.Drawing.Size(112, 28);
            this.rbtnCashier2View.TabIndex = 4;
            this.rbtnCashier2View.TabStop = true;
            this.rbtnCashier2View.Text = "Кассир_2";
            this.rbtnCashier2View.UseVisualStyleBackColor = true;
            this.rbtnCashier2View.CheckedChanged += new System.EventHandler(this.rbtnCashier2);
            // 
            // rbtnCashier1View
            // 
            this.rbtnCashier1View.AutoSize = true;
            this.rbtnCashier1View.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCashier1View.Location = new System.Drawing.Point(3, 3);
            this.rbtnCashier1View.Name = "rbtnCashier1View";
            this.rbtnCashier1View.Size = new System.Drawing.Size(112, 28);
            this.rbtnCashier1View.TabIndex = 3;
            this.rbtnCashier1View.TabStop = true;
            this.rbtnCashier1View.Text = "Кассир_1";
            this.rbtnCashier1View.UseVisualStyleBackColor = true;
            this.rbtnCashier1View.CheckedChanged += new System.EventHandler(this.rbtnCashier1);
            // 
            // Registration
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(513, 285);
            this.Controls.Add(this.grpBoxCashiersView);
            this.Controls.Add(this.grpBoxRolesView);
            this.Controls.Add(this.btnEnterView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECS";
            //this.Load += new System.EventHandler(this.Registration_Load);
            this.grpBoxRolesView.ResumeLayout(false);
            this.grpBoxRolesView.PerformLayout();
            this.grpBoxCashiersView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterView;
        private System.Windows.Forms.GroupBox grpBoxRolesView;
        private System.Windows.Forms.RadioButton rbtnCashierView;
        private System.Windows.Forms.RadioButton rbtnAdminView;
        private System.Windows.Forms.GroupBox grpBoxCashiersView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCashier4View;
        private System.Windows.Forms.RadioButton rbtnCashier3View;
        private System.Windows.Forms.RadioButton rbtnCashier2View;
        private System.Windows.Forms.RadioButton rbtnCashier1View;
        private System.Windows.Forms.RadioButton rbtnCashier5View;
    }
}

