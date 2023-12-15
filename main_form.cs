using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_archive
{
    public partial class main_form : Form
    {

        public Ref<List<Author>> authorList;
        public Ref<List<Item>> items;
        public DataBase DB;

        public main_form(DataBase db)
        {
            InitializeComponent();
            authorList = db.Get_Authors();
            items = db.Get_Items();
            DB = db;
        }

        private void all_items_btn_Click(object sender, EventArgs e)
        {
            all_items_form all_items_form = new all_items_form(authorList, items);
            all_items_form.Show();
        }

        private void add_to_archive_btn_Click(object sender, EventArgs e)
        {
            add_to_archive_form add_form = new add_to_archive_form(authorList, items);
            add_form.Show();
        }

        private void find_in_archive_btn_Click(object sender, EventArgs e)
        {
            archive_search search_form = new archive_search(authorList, items);
            search_form.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }
    }
}
