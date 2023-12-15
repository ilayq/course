namespace home_archive
{
    partial class all_items_form
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
            this.all_items_grid = new System.Windows.Forms.DataGridView();
            this.return_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.all_items_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // all_items_grid
            // 
            this.all_items_grid.AllowUserToAddRows = false;
            this.all_items_grid.AllowUserToDeleteRows = false;
            this.all_items_grid.AllowUserToOrderColumns = true;
            this.all_items_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.all_items_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_items_grid.Location = new System.Drawing.Point(-1, 0);
            this.all_items_grid.Name = "all_items_grid";
            this.all_items_grid.ReadOnly = true;
            this.all_items_grid.Size = new System.Drawing.Size(816, 396);
            this.all_items_grid.TabIndex = 0;
            this.all_items_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_items_grid_CellContentClick);
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.return_btn.Location = new System.Drawing.Point(12, 402);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(105, 36);
            this.return_btn.TabIndex = 1;
            this.return_btn.Text = "Назад";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.add_btn.Location = new System.Drawing.Point(612, 402);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(124, 36);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // all_items_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.all_items_grid);
            this.Name = "all_items_form";
            this.Text = "all_items_form";
            this.Load += new System.EventHandler(this.all_items_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.all_items_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView all_items_grid;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button add_btn;
    }
}