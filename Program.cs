using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_archive
{
    public class Ref<T>
    {
        public T value { get; set; }
        public Ref(T value)
        {
            this.value = value;
        }
    }


    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SQLiteDB db = new SQLiteDB();
            Application.Run(new main_form(db));
            db.Commit();
        }
    }
}
