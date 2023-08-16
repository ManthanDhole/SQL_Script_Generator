using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ScriptGenUtility.CommonHelperCode
{
    public static class OpenComponent_inPanel
    {
        public static void ClearControlsFromPanel(Panel panelName)
        {           
            if (panelName.Controls.Count > 0)
            {
                panelName.Controls.RemoveAt(0);
            }
        }
    }
}
