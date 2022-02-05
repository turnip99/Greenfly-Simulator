using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Greenfly_Simulator.Properties;

namespace Greenfly_Simulator
{
    class Ladybird : Bug
    {
        public Ladybird()
        {
            image.Image = Resources.Ladybird;
        }
    }
}
