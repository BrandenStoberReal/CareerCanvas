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
        /// <summary>
        /// Clears the active control of the given MaterialForm.
        /// </summary>
        /// <param name="form">The MaterialForm whose active control should be cleared.</param>
        public static void ClearActiveControl(MaterialForm form)
        {
            form.ActiveControl = null;
        }
    }
}
