using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;

namespace home_archive
{
    public partial class add_to_archive_form : Form
    {
        string author_name_surname;
        Author author;
        string type;
        string title;
        DateTime release_date;
        string genre;
        string spec_field;
        Ref<List<Author>> authors;
        Ref<List<Item>> items;
        public add_to_archive_form(Ref<List<Author>> authors, Ref<List<Item>> items)
        {
            InitializeComponent();
            item_type_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> vars = authors.value.Select((a) => (a.Name + ' ' + a.Surname)).ToList();
            vars.Insert(0, "Новый Автор");
            author_combobox.DataSource = vars;
            this.authors = authors;
            this.items = items;
        }

        private void item_type_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.type = item_type_combobox.Text;
            switch (type)
            {
                case "Фильм":
                    spec_field_textbox.Text = "Киностудия";
                    break;
                case "Песня":
                    spec_field_textbox.Text = "Альбом";
                    break;
                case "Книга":
                    spec_field_textbox.Text = "Издательство";
                    break;
            }
        }

        private void release_date_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genre_textbox_TextChanged(object sender, EventArgs e)
        {
            genre = genre_textbox.Text;
        }

        private void title_textbox_TextChanged(object sender, EventArgs e)
        {
            title = title_textbox.Text;
        }

        private void author_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_author_btn.Enabled = author_combobox.Text == "Новый Автор";
            if (author_combobox.Text != "Новый Автор") 
            {
                author_name_surname = author_combobox.Text;
                File.WriteAllText("debug", author_name_surname);
                author = this.authors.value.Where((a) => (a.Name + ' ' + a.Surname == author_name_surname)).First();
            }
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"auth: {author}, title: {title}, type: {type}, genre: {genre}, spec_field: {spec_field}");
            if (author != null && title != null && type != null && genre != null && spec_field != null)
            {
                release_date = DateTime.ParseExact(release_date_textbox.Text, "dd-MM-yyyy", null);
                Item n;
                switch (type)
                {
                    case "Фильм":
                        n = new Film(title, author, genre, release_date, spec_field);
                        break;
                    case "Книга":
                        n = new Book(title, author, genre, release_date, spec_field);
                        break;
                    case "Песня":
                        n = new Song(title, author, genre, release_date, spec_field);
                        break;
                    default:
                        throw new Exception("wtf");
                }
                this.items.value.Add(n);
                MessageBox.Show("Успешно добавлено");
                this.Dispose();
                return;
            }
            MessageBox.Show("Не все поля заполнены");
        }

        private void add_author_btn_Click(object sender, EventArgs e)
        {
            author_combobox.Enabled = false;
            string name = author_name_textbox.Text;
            string surname = surname_textbox.Text;
            DateTime birth_date = DateTime.ParseExact(birth_date_textbox.Text, "dd-MM-yyyy", null);
            this.author = new Author(name, surname, birth_date);
            this.authors.value.Add(this.author);
            List<string> vars = this.authors.value.Select((a) => (a.Name + ' ' + a.Surname)).ToList();
            vars.Insert(0, name + ' ' + surname);
            author_combobox.DataSource = vars;
        }

        private void spec_field_textbox_TextChanged(object sender, EventArgs e)
        {
            this.spec_field = spec_field_textbox.Text;
        }
    }
}
