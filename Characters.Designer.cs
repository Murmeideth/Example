
namespace Example
{
    partial class Characters
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
            this.char_list = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.char_list)).BeginInit();
            this.SuspendLayout();
            // 
            // char_list
            // 
            this.char_list.AllowUserToAddRows = false;
            this.char_list.AllowUserToDeleteRows = false;
            this.char_list.AllowUserToResizeColumns = false;
            this.char_list.AllowUserToResizeRows = false;
            this.char_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.char_list.Location = new System.Drawing.Point(12, 12);
            this.char_list.Name = "char_list";
            this.char_list.ReadOnly = true;
            this.char_list.Size = new System.Drawing.Size(493, 376);
            this.char_list.TabIndex = 0;
            this.char_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.char_list_CellClick);
            this.char_list.SelectionChanged += new System.EventHandler(this.char_list_SelectionChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 394);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 34);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(299, 394);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(206, 34);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить персонажа";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 433);
            this.ControlBox = false;
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.char_list);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Characters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Characters";
            ((System.ComponentModel.ISupportInitialize)(this.char_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView char_list;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_btn;
    }
}