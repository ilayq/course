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
    public partial class archive_search : Form
    {
        Ref<List<Author>> authors;
        Ref<List<Item>> items;
        string cmp_type;
        string cmp_val;
        string comparator;
        IEnumerable<Item> q;
        delegate bool rd_comparator(DateTime x, DateTime y);
        rd_comparator rd_compare;
        DataTable dt;

        public archive_search(Ref<List<Author>> authors, Ref<List<Item>> items)
        {
            this.authors = authors;
            this.items = items;
            InitializeComponent();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void search_param_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comparator_combobox.Enabled = search_param_combobox.Text == "Дата выхода";
            cmp_type = search_param_combobox.Text;
        }

        private void cmp_value_TextChanged(object sender, EventArgs e)
        {
            cmp_val = cmp_value.Text;
        }

        private void comparator_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comparator = comparator_combobox.Text;
        }

        private void use_filter_Click(object sender, EventArgs e)
        {
            switch (cmp_type)
            {
                case "Название":
                    q = items.value.Where((it) => it.Title.Contains(cmp_val));
                    break;
                case "Автор":
                    q = items.value.Where((it) => (it.Author.Name + ' ' + it.Author.Surname).Contains(cmp_val));
                    break;
                case "Жанр":
                    q = items.value.Where((it) => it.Genre.Contains(cmp_val));
                    break;
                case "Дата выхода":
                    DateTime cmp_rd = DateTime.ParseExact(cmp_val, "dd-MM-yyyy", null);
                    switch (comparator)
                    {
                        case ">":
                            rd_compare = (x, y) => (x > y);
                            break;
                        case "<":
                            rd_compare = (x, y) => (x < y);
                            break;
                        case "=":
                            rd_compare = (x, y) => (x == y);
                            break;
                        case ">=":
                            rd_compare = (x, y) => (x >= y);
                            break;
                        case "<=":
                            rd_compare = (x, y) => (x <= y);
                            break;
                    }
                    q = items.value.Where((it) => rd_compare(it.ReleaseDate, cmp_rd));
                    break;
                default:
                    return;
            }
            dt.Rows.Clear();
            foreach (Item a in q)
            {
                string rd = a.ReleaseDate.ToString().Split(' ')[0];
                if (a is Book)
                {
                    Book asd = (Book)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, asd.Publishing);
                }
                else if (a is Film)
                {
                    Film asd = (Film)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, asd.Studio);
                }
                else
                {
                    Song asd = (Song)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, null, asd.Album);
                }
            }
            filter_result_grid.DataSource = dt;
        }

        private void archive_search_Load(object sender, EventArgs e)
        {
            comparator_combobox.Enabled = false;
            filter_result_grid.AllowUserToAddRows = false;
            filter_result_grid.DataSource = items.value.ToList();
            dt = new DataTable();
            dt.Columns.Add("Название", typeof(string));
            dt.Columns.Add("Автор", typeof(string));
            dt.Columns.Add("Жанр", typeof(string));
            dt.Columns.Add("Дата выхода", typeof(string));
            dt.Columns.Add("Издательство", typeof(string));
            dt.Columns.Add("Киностудия", typeof(string));
            dt.Columns.Add("Альбом", typeof(string));

            foreach (Item a in items.value)
            {
                string rd = a.ReleaseDate.ToString().Split(' ')[0];
                if (a is Book)
                {
                    Book asd = (Book)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, asd.Publishing);
                }
                else if (a is Film)
                {
                    Film asd = (Film)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, asd.Studio);
                }
                else
                {
                    Song asd = (Song)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, null, asd.Album);
                }
            }
            filter_result_grid.DataSource = dt;
        }

        private void filter_result_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_filter_btn_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            foreach (Item a in items.value)
            {
                string rd = a.ReleaseDate.ToString().Split(' ')[0];
                if (a is Book)
                {
                    Book asd = (Book)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, asd.Publishing);
                }
                else if (a is Film)
                {
                    Film asd = (Film)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, asd.Studio);
                }
                else
                {
                    Song asd = (Song)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, null, null, asd.Album);
                }
            }
            filter_result_grid.DataSource = dt;
        }
    }
}
