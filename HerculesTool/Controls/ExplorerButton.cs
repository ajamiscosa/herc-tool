using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerculesTool.Controls
{
    public class ExplorerButton
        : Button
    {
        protected override Size DefaultSize
        {
            get
            {
                return new Size(250,50);
            }
        }

    }
}
