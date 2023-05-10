using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteReadonlyFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            File.SetAttributes("myFile.txt", FileAttributes.Normal);
            File.Delete("myFile.txt");
            MessageBox.Show("Deleted");
        }
    }
}
