
namespace Example
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.greet_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата регистрации";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(173, 141);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(120, 21);
            this.date_label.TabIndex = 3;
            this.date_label.Text = "Какая-то дата";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(177, 58);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(211, 29);
            this.name_box.TabIndex = 4;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(177, 98);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(211, 29);
            this.password_box.TabIndex = 4;
            // 
            // greet_label
            // 
            this.greet_label.AutoSize = true;
            this.greet_label.Location = new System.Drawing.Point(14, 19);
            this.greet_label.Name = "greet_label";
            this.greet_label.Size = new System.Drawing.Size(164, 21);
            this.greet_label.TabIndex = 5;
            this.greet_label.Text = "Текст приветствиЯ";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 186);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 28);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Location = new System.Drawing.Point(275, 186);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(113, 28);
            this.chng_btn.TabIndex = 7;
            this.chng_btn.Text = "Изменить";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(173, 61);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(53, 21);
            this.login_label.TabIndex = 8;
            this.login_label.Text = "label6";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(173, 101);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 21);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "label7";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 229);
            this.ControlBox = false;
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.greet_label);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label greet_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
    }
}