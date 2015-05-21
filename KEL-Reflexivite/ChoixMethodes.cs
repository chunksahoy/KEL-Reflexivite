using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEL_Reflexivite
{
    public partial class ChoixMethodes : Form
    {

        Explorateur Explor;
        public int IndexMethode { get; private set; }
        public ChoixMethodes()
        {
            InitializeComponent();
        }
        public ChoixMethodes(Explorateur ex)
        {
            InitializeComponent();
            Explor = ex;
        }
        private void RemplirMethodes()
        {
            foreach (MethodInfo mi in Explor.Methodes)
            {
                CB_Methodes.Items.Add(mi.ToString());
            }
        }
        private void ChoixMethodes_Load(object sender, EventArgs e)
        {
            RemplirMethodes();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            IndexMethode = CB_Methodes.SelectedIndex;
        }
    }
}
