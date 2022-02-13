using System.Drawing;
using System.Windows.Forms;

namespace Forms_TechServ.forms.customControls
{
    public class EditButton : Button
    {
        public EditButton()
        {
            Size = new Size(150, 30);
            BackColor = Color.FromArgb(51, 225, 231);
            Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}