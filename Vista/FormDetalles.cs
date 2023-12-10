using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapeleriaGUI
{
    public partial class FormDetalles : Form
    {
        
        public FormDetalles(String titutlo, IEnumerable<Object> elementos)
        {
            InitializeComponent();
            this.Text = titutlo;
            grid.DataSource = elementos;
        }
    }
}
