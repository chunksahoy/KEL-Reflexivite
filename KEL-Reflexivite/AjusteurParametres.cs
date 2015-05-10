using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEL_Reflexivite
{
    class AjusteurParametres
    {
        GroupBox ParamSection;
        public AjusteurParametres(GroupBox gb)
        {
            ParamSection = gb;
        }
        public void NumericUpDown()
        {
            NumericUpDown nud = new NumericUpDown();
            nud.Width = 10;
            Control last = ParamSection.Controls[ParamSection.Controls.Count];
            nud.Location = new Point(last.Left, last.Bottom + 30);
            ParamSection.Height += 30;
            ParamSection.Controls.Add(nud);
        }
    }
}
