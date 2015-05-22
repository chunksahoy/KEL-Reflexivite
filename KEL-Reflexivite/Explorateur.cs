/**************************************************************************|
|                                                                          |
|  Explorateur                                                             |
|  Charles Hunter-Roy,                                                     |
|  Daren Ken Saint-Laurent                                                 |
|  2015                                                                    |
|  Très fortement inspiré des travaux de Patrice Roy,                      |
|  cette classe, très simpliste et naïve, se sert de la                    |
|  réflexivité pour offrir une liste de constructeurs et                   |
|  de méthodes à utiliser.                                                 |
|                                                                          |
***************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KEL_Reflexivite
{
    public class Explorateur
    {
        #region Erreurs
        public class Erreur : SystemException
        {
            string msg;
            public Erreur()
            {

            }
            public Erreur(string s) : base(s)
            {
                msg = s;
            }
        }

        public class ErreurMethode : Erreur
        {
            const string ERREUR_METHODE = "Une erreur est survenue lors de l'invocation d'une méthode";
            public ErreurMethode() : base(ERREUR_METHODE)
            {

            }
        }

        public class ErreurConstructeur : Erreur
        {
            const string ERREUR_CONSTRUCT = "Une erreur est survenue lors de la création de l'objet";
            public ErreurConstructeur() : base(ERREUR_CONSTRUCT)
            {
                
            }
        }
        #endregion

        public Type Type { get; private set; } 
        List<ConstructorInfo> constructeurs = new List<ConstructorInfo>();
        List<MethodInfo> methodes = new List<MethodInfo>();
        int NbParamC = 0,
            NbParamM = 0;
        public List<ConstructorInfo> Constructeurs
        {
            get { return constructeurs; }
            private set { Constructeurs = value; }
        }
        public List<MethodInfo> Methodes
        {
            get { return methodes; }
            private set { methodes = value; }
        }
        public Explorateur(object obj)
        {
            Type = obj.GetType();
            StorerConstructeurs();
            StorerMethodes();
        }
        private void StorerConstructeurs()
        {
            ConstructorInfo[] ctorInf = Type.GetConstructors();
            foreach (ConstructorInfo ci in ctorInf)
                if(ci.GetParameters().Count() <= NbParamC)
                    Constructeurs.Add(ci);
        }
        private void StorerMethodes()
        {
            MethodInfo[] methInf = Type.GetMethods();
            foreach (MethodInfo mi in methInf)
                if(mi.GetParameters().Count() <= NbParamM)
                    Methodes.Add(mi);
        }        
        public T InvoquerConstructeur<T>(T obj, int index, object[] parametres)
        {
            int nCtors = Type.GetConstructors().Length;
            try
            {
                return (T)Type.GetConstructors()[index].Invoke(parametres);
            }
            catch (Exception ex)
            {
                throw new ErreurConstructeur();
            }
        }
        public T InvoquerMethode<T>(T obj, int index, object cible, object[] parametres)
        {
            int nMeth = Type.GetMethods().Length;
            try
            {
                return (T)Type.GetMethods()[index].Invoke(cible, parametres);
            }
            catch(Exception ex)
            {
                throw new ErreurMethode();
            }
        }
    }
}