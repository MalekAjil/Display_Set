using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_set
{
    internal class Symbole
    {

        public static string _DISPLAY_BLINK = "d";
        public static string _DISPLAY = "u";
        public static string _CLOSE = "c";
        public static string _OPEN = "o";
        public static string _CLEAR = "r";


        public  string s;
        public  string title;
        public Symbole() { }
        public Symbole(string s, string title)
        {
            this.s = s;
            this.title = title;
        }
        public static List<Symbole> getItems()
        {
            List<Symbole> list = new List<Symbole>();
            list.Add(new Symbole("d", "Display"));
            list.Add(new Symbole("u", "Update"));
            list.Add(new Symbole("c", "Close"));
            list.Add(new Symbole("o", "Open"));
            list.Add(new Symbole("r", "Erase"));

            return list;
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
