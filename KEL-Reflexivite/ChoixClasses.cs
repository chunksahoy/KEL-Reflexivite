﻿/**************************************************************************|
|                                                                          |
|  ChoixConstructeurs                                                      |
|  Charles Hunter-Roy,                                                     |
|  Daren Ken Saint-Laurent                                                 |
|  2015                                                                    |
|                                                                          |
|  Petite fenêtre offrant un simple menu qui offre le choix                |
|  de la classe à instancier.                                              |
|                                                                          |
***************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEL_Reflexivite
{
    public partial class ChoixClasses : Form
    {
        List<Explorateur> Explor;
        Explorateur choix;
        public Explorateur Choix
        {
            get { return choix; }
            private set { choix = value; }
        }
        public int IndexConstructeur { get; private set; }
        public ChoixClasses()
        {
            InitializeComponent();
        }
        public ChoixClasses(List<Explorateur> li)
        {
            InitializeComponent();
            Explor = li;
        }
        private void RemplirOptions()
        {
            foreach (Explorateur ex in Explor)
                CB_Classes.Items.Add(ex.Type.ToString());
        }
        private void ChoixClasses_Load(object sender, EventArgs e)
        {
            RemplirOptions();
        }
        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            ChoixConstructeurs diag = new ChoixConstructeurs(Explor[CB_Classes.SelectedIndex]);
            if(diag.ShowDialog() == DialogResult.OK)
            {
                Choix = Explor[CB_Classes.SelectedIndex];
                IndexConstructeur = diag.IndexConstructeur;
            }
        }
    }
}