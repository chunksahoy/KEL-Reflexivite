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
    public partial class ExplorateurClasses : Form
    {
        List<Explorateur> explorateurs = new List<Explorateur>() ;
        //var magie = null;
        public List<Explorateur> Explorateurs
        {
            get { return explorateurs; }
            private set { explorateurs = value; }
        }
        string[] Statut = { "Inerte", "Actif" };
        public ExplorateurClasses()
        {
            InitializeComponent();
            RemplirTypes();
        }
        private void RemplirTypes()
        {
            Explorateurs.Add(new Explorateur(new ClasseMagique()));
        }
        private void VerifierEtat()
        {

        }
        private void Nettoyer()
        {
            LB_Methodes.Items.Clear();
            LB_Constructeurs.Items.Clear();
        }
        private void AfficherTypes()
        {
            foreach(Explorateur ex in Explorateurs)
            {
                LB_Classes.Items.Add(ex.Type);
            }
        }
        private void AfficherConstructeurs(int index)
        {
            foreach (ConstructorInfo ci in Explorateurs[index].Constructeurs)
            {
               LB_Constructeurs.Items.Add(ci.ToString());
            }
        }
        private void AfficherMethodes(int index)
        {
           foreach (MethodInfo mi in Explorateurs[index].Methodes)
            {
                LB_Methodes.Items.Add(mi.ToString());
            }
        }
        private void ConstructeurClasses_Load(object sender, EventArgs e)
        {
            AfficherTypes();
        }
        private void LB_Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nettoyer();
            AfficherConstructeurs(LB_Classes.SelectedIndex);
            AfficherMethodes(LB_Classes.SelectedIndex);
        }
        private void créerObjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChoixClasses diag = new ChoixClasses(Explorateurs);
            if(diag.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}