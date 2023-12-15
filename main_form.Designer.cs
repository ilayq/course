namespace home_archive
{
    partial class main_form
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
            this.add_to_archive_btn = new System.Windows.Forms.Button();
            this.find_in_archive_btn = new System.Windows.Forms.Button();
            this.all_items_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_to_archive_btn
            // 
            this.add_to_archive_btn.Location = new System.Drawing.Point(559, 212);
            this.add_to_archive_btn.Name = "add_to_archive_btn";
            this.add_to_archive_btn.Size = new System.Drawing.Size(107, 45);
            this.add_to_archive_btn.TabIndex = 0;
            this.add_to_archive_btn.Text = "Добавить в архив";
            this.add_to_archive_btn.UseVisualStyleBackColor = true;
            this.add_to_archive_btn.Click += new System.EventHandler(this.add_to_archive_btn_Click);
            // 
            // find_in_archive_btn
            // 
            this.find_in_archive_btn.Location = new System.Drawing.Point(314, 212);
            this.find_in_archive_btn.Name = "find_in_archive_btn";
            this.find_in_archive_btn.Size = new System.Drawing.Size(131, 45);
            this.find_in_archive_btn.TabIndex = 1;
            this.find_in_archive_btn.Text = "Поиск по архиву";
            this.find_in_archive_btn.UseVisualStyleBackColor = true;
            this.find_in_archive_btn.Click += new System.EventHandler(this.find_in_archive_btn_Click);
            // 
            // all_items_btn
            // 
            this.all_items_btn.Location = new System.Drawing.Point(75, 212);
            this.all_items_btn.Name = "all_items_btn";
            this.all_items_btn.Size = new System.Drawing.Size(123, 45);
            this.all_items_btn.TabIndex = 2;
            this.all_items_btn.Text = "Все произведения";
            this.all_items_btn.UseVisualStyleBackColor = true;
            this.all_items_btn.Click += new System.EventHandler(this.all_items_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(314, 349);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(131, 48);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.all_items_btn);
            this.Controls.Add(this.find_in_archive_btn);
            this.Controls.Add(this.add_to_archive_btn);
            this.Name = "main_form";
            this.Text = "Home Archive";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_to_archive_btn;
        private System.Windows.Forms.Button find_in_archive_btn;
        private System.Windows.Forms.Button all_items_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

