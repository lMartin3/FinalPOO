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
