using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_archive
{
    public class Item
    {
        static protected int ID = 0;

        public string type = "item";

        public string Title;

        public string Genre;
        public int id;

        public DateTime ReleaseDate;
        public Author Author;

        public Item(string title, Author author, string genre, DateTime release_date)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.ReleaseDate = release_date;
            this.id = ++ID;
        }

        public override string ToString()
        {
            return $"<title: {Title} author: {Author} genre: {Genre} release_date: {ReleaseDate} id: {id}>";
        }
    }

    public class Book : Item
    {
        public string Publishing;
        public Book(string title, Author author, string genre, DateTime release_date, string publishing)
        : base(title, author, genre, release_date)
        {
            this.Publishing = publishing;
            this.type = "book";
        }

    }

    public class Film : Item
    {
        public string Studio;

        public Film(string title, Author author, string genre, DateTime release_date, string studio)
        : base(title, author, genre, release_date)
        {
            this.Studio = studio;
            this.type = "film";
        }
    }

    public class Song : Item
    {

        public string Album;
        public Song(string title, Author author, string genre, DateTime release_date, string album)
        : base(title, author, genre, release_date)
        {
            this.Album = album;
            this.type = "song";
        }
    }
}
