/**************************************************************************|
|                                                                          |
|  ExplorateurClasses                                                      |
|  Charles Hunter-Roy,                                                     |
|  Daren Ken Saint-Laurent                                                 |
|  2015                                                                    |
|                                                                          |
|  Fenêtre principale, offrant une vue d'ensembles                         |
|  sur les objets couverts, sans rentrer dans les détails.                 |
|  C'est à partir du menu que l'on peut créer un nouvel objet.             |
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

    public partial class ExplorateurClasses : Form
    {

        List<Explorateur> explorateurs = new List<Explorateur>() ;
        Explorateur Choix;
        int IndexConstructeur;
        public List<Explorateur> Explorateurs
        {
            get { return explorateurs; }
            private set { explorateurs = value; }
        }
        public ExplorateurClasses()
        {
            InitializeComponent();
            RemplirTypes();
        }

        private void RemplirTypes()
        {
            Explorateurs.Add(new Explorateur(new ClasseMagique()));
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
        /// <summary>
        ///  Ici on créé l'objet choisi avec le constructeur demandé, 
        ///  et on ouvre un dialogue offrant un choix de méthode, pour en afficher le résultat
        ///  tout ça de manière très simpliste bien sûr 
        /// </summary>
        private void InteractionObjet()
        {
            var magie = Choix.InvoquerConstructeur(Activator.CreateInstance(Choix.Type), IndexConstructeur, new object[] { });
            if (magie != null)
            {
                LBL_Statut.Text = "Actif";
                ChoixMethodes diag = new ChoixMethodes(Choix);
                if(diag.ShowDialog() == DialogResult.OK)
                {
                    int i = diag.IndexMethode;
                    try
                    {
                        object ob = Choix.Methodes[i].ReturnType.ToString() == "System.String" ? "" :
                        Activator.CreateInstance(Choix.Methodes[i].ReturnType, new object[] { });
                        Choix.InvoquerMethode(ob, i, magie, new object[] { });
                        MessageBox.Show(Choix.InvoquerMethode(ob, i, magie, new object[] { }).ToString());
                    }
                    catch(Explorateur.Erreur er)
                    {
                        MessageBox.Show(er.Message.ToString());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
                LBL_Statut.Text = "Inerte";
            }
            else
            {
                MessageBox.Show("L'objet n'as pas pu être créé");
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
                Choix = diag.Choix;
                IndexConstructeur = diag.IndexConstructeur;
                InteractionObjet();
            }
        }
    }
}