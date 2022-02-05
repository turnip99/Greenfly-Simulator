using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Greenfly_Simulator
{
    class Bug
    {
        public PictureBox image = new PictureBox();

        public Bug ()
        {
            image.Size = new Size(83, 103);
            image.Location = new Point(-83, -103);
        }
    }
}
