namespace home_archive
{
    partial class add_to_archive_form
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
            this.item_type_combobox = new System.Windows.Forms.ComboBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.genre_textbox = new System.Windows.Forms.TextBox();
            this.release_date_textbox = new System.Windows.Forms.TextBox();
            this.author_combobox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.author_name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.birth_date_textbox = new System.Windows.Forms.TextBox();
            this.add_author_btn = new System.Windows.Forms.Button();
            this.spec_field_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // item_type_combobox
            // 
            this.item_type_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_type_combobox.FormattingEnabled = true;
            this.item_type_combobox.ItemHeight = 25;
            this.item_type_combobox.Items.AddRange(new object[] {
            "Книга",
            "Песня",
            "Фильм"});
            this.item_type_combobox.Location = new System.Drawing.Point(25, 71);
            this.item_type_combobox.Name = "item_type_combobox";
            this.item_type_combobox.Size = new System.Drawing.Size(219, 33);
            this.item_type_combobox.TabIndex = 0;
            this.item_type_combobox.Text = "Тип произведения";
            this.item_type_combobox.SelectedIndexChanged += new System.EventHandler(this.item_type_combobox_SelectedIndexChanged);
            // 
            // title_textbox
            // 
            this.title_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_textbox.Location = new System.Drawing.Point(25, 110);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(219, 30);
            this.title_textbox.TabIndex = 2;
            this.title_textbox.Text = "Название";
            this.title_textbox.TextChanged += new System.EventHandler(this.title_textbox_TextChanged);
            // 
            // genre_textbox
            // 
            this.genre_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_textbox.Location = new System.Drawing.Point(25, 182);
            this.genre_textbox.Name = "genre_textbox";
            this.genre_textbox.Size = new System.Drawing.Size(219, 30);
            this.genre_textbox.TabIndex = 4;
            this.genre_textbox.Text = "Жанр";
            this.genre_textbox.TextChanged += new System.EventHandler(this.genre_textbox_TextChanged);
            // 
            // release_date_textbox
            // 
            this.release_date_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_date_textbox.Location = new System.Drawing.Point(25, 146);
            this.release_date_textbox.Name = "release_date_textbox";
            this.release_date_textbox.Size = new System.Drawing.Size(219, 30);
            this.release_date_textbox.TabIndex = 5;
            this.release_date_textbox.Text = "Дата выхода";
            this.release_date_textbox.TextChanged += new System.EventHandler(this.release_date_textbox_TextChanged);
            // 
            // author_combobox
            // 
            this.author_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_combobox.FormattingEnabled = true;
            this.author_combobox.Location = new System.Drawing.Point(25, 218);
            this.author_combobox.Name = "author_combobox";
            this.author_combobox.Size = new System.Drawing.Size(219, 33);
            this.author_combobox.TabIndex = 6;
            this.author_combobox.Text = "Автор";
            this.author_combobox.SelectedIndexChanged += new System.EventHandler(this.author_combobox_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(25, 371);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(219, 67);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Добавить  произведение";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // author_name_textbox
            // 
            this.author_name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.author_name_textbox.Location = new System.Drawing.Point(513, 71);
            this.author_name_textbox.Name = "author_name_textbox";
            this.author_name_textbox.Size = new System.Drawing.Size(187, 30);
            this.author_name_textbox.TabIndex = 8;
            this.author_name_textbox.Text = "Имя автора";
            // 
            // surname_textbox
            // 
            this.surname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.surname_textbox.Location = new System.Drawing.Point(513, 132);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(187, 30);
            this.surname_textbox.TabIndex = 9;
            this.surname_textbox.Text = "Фамилия автора";
            // 
            // birth_date_textbox
            // 
            this.birth_date_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.birth_date_textbox.Location = new System.Drawing.Point(513, 192);
            this.birth_date_textbox.Name = "birth_date_textbox";
            this.birth_date_textbox.Size = new System.Drawing.Size(187, 30);
            this.birth_date_textbox.TabIndex = 10;
            this.birth_date_textbox.Text = "Дата рождения";
            // 
            // add_author_btn
            // 
            this.add_author_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.add_author_btn.Location = new System.Drawing.Point(513, 268);
            this.add_author_btn.Name = "add_author_btn";
            this.add_author_btn.Size = new System.Drawing.Size(187, 67);
            this.add_author_btn.TabIndex = 11;
            this.add_author_btn.Text = "Добавить автора";
            this.add_author_btn.UseVisualStyleBackColor = true;
            this.add_author_btn.Click += new System.EventHandler(this.add_author_btn_Click);
            // 
            // spec_field_textbox
            // 
            this.spec_field_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.spec_field_textbox.Location = new System.Drawing.Point(25, 268);
            this.spec_field_textbox.Name = "spec_field_textbox";
            this.spec_field_textbox.Size = new System.Drawing.Size(219, 30);
            this.spec_field_textbox.TabIndex = 12;
            this.spec_field_textbox.Text = "Издательство";
            this.spec_field_textbox.TextChanged += new System.EventHandler(this.spec_field_textbox_TextChanged);
            // 
            // add_to_archive_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spec_field_textbox);
            this.Controls.Add(this.add_author_btn);
            this.Controls.Add(this.birth_date_textbox);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.author_name_textbox);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.author_combobox);
            this.Controls.Add(this.release_date_textbox);
            this.Controls.Add(this.genre_textbox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.item_type_combobox);
            this.Name = "add_to_archive_form";
            this.Text = "add_to_archive_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox item_type_combobox;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.TextBox genre_textbox;
        private System.Windows.Forms.TextBox release_date_textbox;
        private System.Windows.Forms.ComboBox author_combobox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox author_name_textbox;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.TextBox birth_date_textbox;
        private System.Windows.Forms.Button add_author_btn;
        private System.Windows.Forms.TextBox spec_field_textbox;
    }
}