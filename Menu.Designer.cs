
namespace Example
{
    partial class Menu
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
            this.profile_btn = new System.Windows.Forms.Button();
            this.char_btn = new System.Windows.Forms.Button();
            this.relog_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profile_btn
            // 
            this.profile_btn.Location = new System.Drawing.Point(14, 18);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(5);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(213, 37);
            this.profile_btn.TabIndex = 0;
            this.profile_btn.Text = "Профиль";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // char_btn
            // 
            this.char_btn.Location = new System.Drawing.Point(14, 65);
            this.char_btn.Margin = new System.Windows.Forms.Padding(5);
            this.char_btn.Name = "char_btn";
            this.char_btn.Size = new System.Drawing.Size(213, 37);
            this.char_btn.TabIndex = 1;
            this.char_btn.Text = "Персонажи";
            this.char_btn.UseVisualStyleBackColor = true;
            this.char_btn.Click += new System.EventHandler(this.char_btn_Click);
            // 
            // relog_btn
            // 
            this.relog_btn.Location = new System.Drawing.Point(14, 112);
            this.relog_btn.Margin = new System.Windows.Forms.Padding(5);
            this.relog_btn.Name = "relog_btn";
            this.relog_btn.Size = new System.Drawing.Size(213, 37);
            this.relog_btn.TabIndex = 2;
            this.relog_btn.Text = "Выйти из профиля";
            this.relog_btn.UseVisualStyleBackColor = true;
            this.relog_btn.Click += new System.EventHandler(this.relog_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(14, 159);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(213, 37);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Выйти из приложения";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 217);
            this.ControlBox = false;
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.relog_btn);
            this.Controls.Add(this.char_btn);
            this.Controls.Add(this.profile_btn);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button char_btn;
        private System.Windows.Forms.Button relog_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}