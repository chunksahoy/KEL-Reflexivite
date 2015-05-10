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
            return (T)Type.GetConstructors()[index].Invoke(parametres);
        }
        public T InvoquerMethode<T>(T obj, int index, object cible, object[] parametres)
        {
            int nMeth = Type.GetMethods().Length;
            return (T)Type.GetMethods()[index].Invoke(cible, parametres);
        }
    }
}