using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            if (Form2.punkti == 10) labRezultats.Text = "  Tu esi īsts savass zemes patriots!Turklāt vēl ar lieliskām zināšanām! Tu atbildēji pareizi uz visiem jautājumiem!\n" + "(" + Form2.punkti + " punkti" + ")";
            else if (Form2.punkti >=6 && Form2.punkti <= 9) labRezultats.Text = " Atbildes  liecina, ka pazīsti Latviju, bet tev vēl ir fakti ko atklāt!\r\n" + "(" + Form2.punkti + " punkti" + ")";
            else if (Form2.punkti >= 0 && Form2.punkti <= 5) labRezultats.Text = " Spriežot pēc atbildēm, zināšanas par Latviju tev ir jāpapildina!Diemžēl liela daļa tavu atbilžu bija nepareizas.\r\n"+ "("+Form2.punkti + " punkti"+ ")" ;
        }
    }
}
