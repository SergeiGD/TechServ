using System.Drawing;
using System.Windows.Forms;

namespace Forms_TechServ.forms.customControls
{
    public class ManageButton : Button
    {
        public ManageButton()
        {
            Size = new Size(190, 40);
            BackColor = Color.FromArgb(51, 225, 231);
            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}