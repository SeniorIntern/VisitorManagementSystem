using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
        }

        public static void VisitorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.VisitorView = null;
        }
    }
}
