using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaLTaiizor.Forms;

namespace CareerCanvas.Classes.Static.Utils
{
    public static class InputUtils
    {
        public static void ClearActiveControl(MaterialForm form)
        {
            form.ActiveControl = null;
        }
    }
}
