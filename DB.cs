using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace home_archive
{
    public interface DataBase 
    {
        Ref<List<Item>> Get_Items();
        Ref<List<Author>> Get_Authors();

        void Commit();
    }

    public class SQLiteDB: DataBase
    {
        public Ref<List<Item>> items;
        public Ref<List<Author>> authors;

        public SQLiteDB()
        {
            items = new Ref<List<Item>>(new List<Item>());
            authors = new Ref<List<Author>>(new List<Author>());
            SQLiteConnection con = new SQLiteConnection("Data Source=db.db");
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "create table if not exists authors (id int, name varchar(50), surname varchar(50), birth_date date);";
            cmd.ExecuteScalar();
            cmd.CommandText = "create table if not exists items (id int,type int,title varchar(50),author_name_surname varchar(50),genre varchar(50),release_date date,album varchar(50),publishing varchar(50),studio varchar(50));";
            cmd.ExecuteScalar();
            cmd.CommandText = @"select * from authors";
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    authors.value.Add(new Author(rd.GetString(1), rd.GetString(2), rd.GetDateTime(3)));
                }
            }
            cmd.CommandText = "select * from items";
            using (var rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    string type = rd.GetString(1);
                    string title = rd.GetString(2);
                    string name_surname = rd.GetString(3);
                    string genre = rd.GetString(4);
                    DateTime release = DateTime.ParseExact(rd.GetString(5), "yyyy-MM-dd", null);
                    Author auth = authors.value.Where((a) => (a.Name + ' ' + a.Surname == name_surname)).First();
                    string spec;
                    switch (type)
                    {
                        case "film":
                            spec = rd.GetString(8);
                            items.value.Add(new Film(title, auth, genre, release, spec));
                            break;
                        case "song":
                            spec = rd.GetString(6);
                            items.value.Add(new Song(title, auth, genre, release, spec));
                            break;
                        case "book":
                            spec = rd.GetString(7);
                            items.value.Add(new Book(title, auth, genre, release, spec));
                            break;
                    }
                }
            }
        }

        public Ref<List<Item>> Get_Items() { return items; }
        public Ref<List<Author>> Get_Authors() { return authors; }

        public void Commit() 
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=db.db");
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = @"drop table if exists authors; drop table if exists items;";
            cmd.CommandText += "create table authors (id int, name varchar(50), surname varchar(50), birth_date date);";
            cmd.CommandText += "create table items (id int,type int,title varchar(50),author_name_surname varchar(50),genre varchar(50),release_date date,album varchar(50),publishing varchar(50),studio varchar(50));";
            cmd.ExecuteScalar();
            foreach (Author asd in authors.value)
            {
                cmd.CommandText = $"insert into authors(id, name, surname, birth_date) values({asd.id}, '{asd.Name}', '{asd.Surname}', '{asd.BirthDate.ToString("yyyy-MM-dd")}')";
                File.WriteAllText("debug", cmd.CommandText);
                cmd.ExecuteScalar();
            }
            foreach (Item a in items.value)
            {
                if (a is Book)
                {
                    Book asd = (Book)a;
                    cmd.CommandText = $"insert into items(id, type, title, author_name_surname, genre, release_date, publishing)" +
                        $" values({asd.id}, '{asd.type}','{asd.Title}', '{asd.Author.Name + ' ' + asd.Author.Surname}', '{asd.Genre}', '{asd.ReleaseDate.ToString("yyyy-MM-dd")}', '{asd.Publishing}')";
                }else if (a is Film)
                {
                    Film asd = (Film)a;
                    cmd.CommandText = $"insert into items(id, type, title, author_name_surname, genre, release_date, studio)" +
                        $" values({asd.id}, '{asd.type}', '{asd.Title}','{asd.Author.Name + ' ' + asd.Author.Surname}', '{asd.Genre}', '{asd.ReleaseDate.ToString("yyyy-MM-dd")}', '{asd.Studio}')";
                }
                else
                {
                    Song asd = (Song)a;
                    cmd.CommandText = $"insert into items(id, type, title, author_name_surname, genre, release_date, album)" +
                        $" values({asd.id}, '{asd.type}', '{asd.Title}', '{asd.Author.Name + ' ' + asd.Author.Surname}', '{asd.Genre}', '{asd.ReleaseDate.ToString("yyyy-MM-dd")}', '{asd.Album}')";
                }
                cmd.ExecuteScalar();
                //File.WriteAllText("debug", cmd.CommandText);
            }
        }
    }
}
