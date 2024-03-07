using Speaker.leison.Forms;
using Speaker.leison.Kontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speaker.leison
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SpeakerDb db = new SpeakerDb();
            db.Database.CreateIfNotExists();
            Application.Run(new Index());
        }
    }
}
