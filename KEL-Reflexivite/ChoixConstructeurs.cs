/**************************************************************************|
|                                                                          |
|  ChoixConstructeurs                                                      |
|  Charles Hunter-Roy,                                                     |
|  Daren Ken Saint-Laurent                                                 |
|  2015                                                                    |
|                                                                          |
|  Petite fenêtre offrant un simple menu qui offre le choix                |
|  du constructeur à utiliser.                                             |
|                                                                          |
***************************************************************************/
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
    public partial class ChoixConstructeurs : Form
    {
        Explorateur Explorateur;
        public int IndexConstructeur = 0;
        public ChoixConstructeurs()
        {
            InitializeComponent();
        }
        public ChoixConstructeurs(Explorateur ex)
        {
            InitializeComponent();
            Explorateur = ex;
        }
        private void RemplirOptions()
        {
            foreach (ConstructorInfo ci in Explorateur.Constructeurs)
                CB_Constructeurs.Items.Add(ci.ToString());
        }
        private void ChoixConstructeurs_Load(object sender, EventArgs e)
        {
            RemplirOptions();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            IndexConstructeur = CB_Constructeurs.SelectedIndex;

        }
        private void CB_Constructeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}