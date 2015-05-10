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

        public ChoixConstructeurs()
        {
            InitializeComponent();
        }
        public ChoixConstructeurs(Explorateur ex)
        {
            InitializeComponent();
            Explorateur = ex;
        }
        private void VerifierObjetValide()
        {
            if (Explorateur.Methodes[0].GetParameters().Length > 0)
            {

            }
            else
            {

            }
        }
        private void AjusterParametres()
        {
            foreach (ParameterInfo pi in Explorateur.Constructeurs[CB_Constructeurs.SelectedIndex].GetParameters())
                DeterminerAjustement(pi);
        }
        private void DeterminerAjustement(ParameterInfo pi)
        {
            switch(pi.ParameterType.ToString())
            {
                case "System.Int32":
                    break;
                default:
                    break;
            }
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
            var magie = Explorateur.InvoquerConstructeur(Activator.CreateInstance(Explorateur.Type), CB_Constructeurs.SelectedIndex, new object[] { });
            //Explorateur.InvoquerMethode(Activator.CreateInstance(Explorateur.Methodes[0].ReturnType), 0, magie, new object[] { });
        }
        private void CB_Constructeurs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}