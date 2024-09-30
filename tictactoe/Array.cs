using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Array
    {
        private static int a = 0, b = 0, c = 0, win1 = 0, win2 = 0;
        private static string[] name = new string[100];
        private static string[] score = new string[100];

        public static string[] getname
        {
            get { return name; }
            set { name = value; }
        }
        public static string[] getscore
        {
            get { return score; }
            set { score = value; }
        }
        public static int increment
        {
            get { return a; }
            set { a = value; }
        }
        public static int increment2
        {
            get { return b; }
            set { b = value; }
        }
        public static int increment3
        {
            get { return c; }
            set { c = value; }
        }
        public static int getwin1
        {
            get { return win1; }
            set { win1 = value; }
        }
        public static int getwin2
        {
            get { return win2; }
            set { win2 = value; }
        }

    }
}