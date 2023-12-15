namespace home_archive
{
    partial class archive_search
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
            this.search_param_combobox = new System.Windows.Forms.ComboBox();
            this.return_btn = new System.Windows.Forms.Button();
            this.cmp_value = new System.Windows.Forms.TextBox();
            this.comparator_combobox = new System.Windows.Forms.ComboBox();
            this.use_filter = new System.Windows.Forms.Button();
            this.filter_result_grid = new System.Windows.Forms.DataGridView();
            this.delete_filter_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filter_result_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // search_param_combobox
            // 
            this.search_param_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_param_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.search_param_combobox.FormattingEnabled = true;
            this.search_param_combobox.Items.AddRange(new object[] {
            "Название",
            "Автор",
            "Дата выхода",
            "Жанр"});
            this.search_param_combobox.Location = new System.Drawing.Point(94, 403);
            this.search_param_combobox.Name = "search_param_combobox";
            this.search_param_combobox.Size = new System.Drawing.Size(154, 33);
            this.search_param_combobox.TabIndex = 0;
            this.search_param_combobox.SelectedIndexChanged += new System.EventHandler(this.search_param_combobox_SelectedIndexChanged);
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.return_btn.Location = new System.Drawing.Point(12, 402);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(76, 34);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "Назад";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // cmp_value
            // 
            this.cmp_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmp_value.Location = new System.Drawing.Point(254, 404);
            this.cmp_value.Name = "cmp_value";
            this.cmp_value.Size = new System.Drawing.Size(114, 30);
            this.cmp_value.TabIndex = 2;
            this.cmp_value.Text = "Значение";
            this.cmp_value.TextChanged += new System.EventHandler(this.cmp_value_TextChanged);
            // 
            // comparator_combobox
            // 
            this.comparator_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comparator_combobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comparator_combobox.FormattingEnabled = true;
            this.comparator_combobox.Items.AddRange(new object[] {
            ">",
            "<",
            "=",
            ">=",
            "<="});
            this.comparator_combobox.Location = new System.Drawing.Point(387, 402);
            this.comparator_combobox.Name = "comparator_combobox";
            this.comparator_combobox.Size = new System.Drawing.Size(72, 33);
            this.comparator_combobox.TabIndex = 3;
            this.comparator_combobox.SelectedIndexChanged += new System.EventHandler(this.comparator_combobox_SelectedIndexChanged);
            // 
            // use_filter
            // 
            this.use_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.use_filter.Location = new System.Drawing.Point(484, 401);
            this.use_filter.Name = "use_filter";
            this.use_filter.Size = new System.Drawing.Size(144, 34);
            this.use_filter.TabIndex = 4;
            this.use_filter.Text = "Применить";
            this.use_filter.UseVisualStyleBackColor = true;
            this.use_filter.Click += new System.EventHandler(this.use_filter_Click);
            // 
            // filter_result_grid
            // 
            this.filter_result_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filter_result_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filter_result_grid.Location = new System.Drawing.Point(0, 0);
            this.filter_result_grid.Name = "filter_result_grid";
            this.filter_result_grid.ReadOnly = true;
            this.filter_result_grid.Size = new System.Drawing.Size(801, 394);
            this.filter_result_grid.TabIndex = 5;
            this.filter_result_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filter_result_grid_CellContentClick);
            // 
            // delete_filter_btn
            // 
            this.delete_filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.delete_filter_btn.Location = new System.Drawing.Point(643, 402);
            this.delete_filter_btn.Name = "delete_filter_btn";
            this.delete_filter_btn.Size = new System.Drawing.Size(128, 34);
            this.delete_filter_btn.TabIndex = 6;
            this.delete_filter_btn.Text = "Сбросить";
            this.delete_filter_btn.UseVisualStyleBackColor = true;
            this.delete_filter_btn.Click += new System.EventHandler(this.delete_filter_btn_Click);
            // 
            // archive_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_filter_btn);
            this.Controls.Add(this.filter_result_grid);
            this.Controls.Add(this.use_filter);
            this.Controls.Add(this.comparator_combobox);
            this.Controls.Add(this.cmp_value);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.search_param_combobox);
            this.Name = "archive_search";
            this.Text = "archive_search";
            this.Load += new System.EventHandler(this.archive_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filter_result_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox search_param_combobox;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox cmp_value;
        private System.Windows.Forms.ComboBox comparator_combobox;
        private System.Windows.Forms.Button use_filter;
        private System.Windows.Forms.DataGridView filter_result_grid;
        private System.Windows.Forms.Button delete_filter_btn;
    }
}