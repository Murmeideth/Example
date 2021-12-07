
namespace Example
{
    partial class Char_profile
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
            this.label4 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.race_label = new System.Windows.Forms.Label();
            this.bio_box = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.chng_btn = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.class_box = new System.Windows.Forms.ComboBox();
            this.race_box = new System.Windows.Forms.ComboBox();
            this.inventory_box = new System.Windows.Forms.DataGridView();
            this.del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_box)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя персонажа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Класс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Раса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Биография";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(186, 22);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 21);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "label5";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Location = new System.Drawing.Point(186, 66);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(53, 21);
            this.class_label.TabIndex = 4;
            this.class_label.Text = "label5";
            // 
            // race_label
            // 
            this.race_label.AutoSize = true;
            this.race_label.Location = new System.Drawing.Point(186, 110);
            this.race_label.Name = "race_label";
            this.race_label.Size = new System.Drawing.Size(53, 21);
            this.race_label.TabIndex = 4;
            this.race_label.Text = "label5";
            // 
            // bio_box
            // 
            this.bio_box.Location = new System.Drawing.Point(190, 154);
            this.bio_box.Multiline = true;
            this.bio_box.Name = "bio_box";
            this.bio_box.Size = new System.Drawing.Size(371, 199);
            this.bio_box.TabIndex = 5;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 379);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(99, 26);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.Location = new System.Drawing.Point(430, 379);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(131, 26);
            this.inventory_btn.TabIndex = 6;
            this.inventory_btn.Text = "Инвентарь";
            this.inventory_btn.UseVisualStyleBackColor = true;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // chng_btn
            // 
            this.chng_btn.Location = new System.Drawing.Point(140, 379);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(99, 26);
            this.chng_btn.TabIndex = 6;
            this.chng_btn.Text = "Изменить";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(190, 19);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(173, 29);
            this.name_box.TabIndex = 7;
            // 
            // class_box
            // 
            this.class_box.FormattingEnabled = true;
            this.class_box.Location = new System.Drawing.Point(190, 63);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(173, 29);
            this.class_box.TabIndex = 8;
            // 
            // race_box
            // 
            this.race_box.FormattingEnabled = true;
            this.race_box.Location = new System.Drawing.Point(190, 107);
            this.race_box.Name = "race_box";
            this.race_box.Size = new System.Drawing.Size(173, 29);
            this.race_box.TabIndex = 9;
            // 
            // inventory_box
            // 
            this.inventory_box.AllowUserToAddRows = false;
            this.inventory_box.AllowUserToDeleteRows = false;
            this.inventory_box.AllowUserToResizeColumns = false;
            this.inventory_box.AllowUserToResizeRows = false;
            this.inventory_box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_box.Location = new System.Drawing.Point(617, 19);
            this.inventory_box.MultiSelect = false;
            this.inventory_box.Name = "inventory_box";
            this.inventory_box.ReadOnly = true;
            this.inventory_box.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.inventory_box.Size = new System.Drawing.Size(210, 385);
            this.inventory_box.TabIndex = 10;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(262, 379);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(99, 26);
            this.del_btn.TabIndex = 11;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // Char_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 416);
            this.ControlBox = false;
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.inventory_box);
            this.Controls.Add(this.race_box);
            this.Controls.Add(this.class_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.inventory_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.bio_box);
            this.Controls.Add(this.race_label);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Char_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char_profile";
            ((System.ComponentModel.ISupportInitialize)(this.inventory_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label race_label;
        private System.Windows.Forms.TextBox bio_box;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.ComboBox class_box;
        private System.Windows.Forms.ComboBox race_box;
        private System.Windows.Forms.DataGridView inventory_box;
        private System.Windows.Forms.Button del_btn;
    }
}