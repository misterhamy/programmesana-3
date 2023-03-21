using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



class Program
{
    private static void Main(string[] args)
    {
        Main(args, text2);
    }

    static void Main(string[] args, DateTime text2)
    {
        DateTime theDate;

        string file = "C:\Users\maxho\OneDrive\Desktop\repozitorijas\programmesana-3\2,3uzdevums\2,3.uzd.txt";

        string text1 = "Datumi kad programma 2,3uzdevums bija iedarbināta:"; 
        File.WriteAllText(file, text1);

        var text2 = (theDate = DateTime.Now);
        File.AppendAllText(file, text2);

        Console.WriteLine(File.ReadAllText(file));
        Console.ReadKey();
    }
}

namespace _2_3uzdevums
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime theDate;

            theDate = DateTime.Now;

            labDatums.Text = (theDate.ToString());

            string writeText = (theDate.ToString());

        }



        private void labDatums_Click(object sender, EventArgs e)
        {

        }
    }
}


