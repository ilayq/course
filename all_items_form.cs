using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_archive
{
    public partial class all_items_form : Form
    {
        Ref<List<Author>> authors;
        Ref<List<Item>> items;
        public all_items_form(Ref<List<Author>> authors, Ref<List<Item>> items)
        {
            this.authors = authors;
            this.items = items;
            InitializeComponent();
            all_items_grid.AllowUserToAddRows = false;
            all_items_grid.DataSource = items.value.ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Название", typeof(string));
            dt.Columns.Add("Автор", typeof(string));
            dt.Columns.Add("Жанр", typeof(string));
            dt.Columns.Add("Дата выхода", typeof(string));
            dt.Columns.Add("Издательство", typeof(string));
            dt.Columns.Add("Киностудия", typeof(string));
            dt.Columns.Add("Альбом", typeof(string));

            foreach(Item a in items.value)
            {
                string rd = a.ReleaseDate.ToString().Split(' ')[0];
                if (a is Book)
                {
                    Book asd = (Book)a;
                    dt.Rows.Add(asd.Title, asd.Author.Name + ' ' + asd.Author.Surname, asd.Genre, rd, asd.Publishing);
                }else if (a is Film)
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
            all_items_grid.DataSource = dt;
        }

        private void all_items_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_to_archive_form f = new add_to_archive_form(authors, items);
            f.Show();
        }

        private void all_items_form_Load(object sender, EventArgs e)
        {

        }
    }
}
