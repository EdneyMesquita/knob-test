using System.Windows.Forms;

namespace KnobTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void knobControl_ValueChanged(object Sender)
        {
            lblValor.Text = string.Format("R$ {0},00", knobControl.Value.ToString());
        }
    }
}
