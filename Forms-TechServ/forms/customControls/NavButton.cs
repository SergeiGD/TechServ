using System.Drawing;
using System.Windows.Forms;

namespace Forms_TechServ.forms.customControls
{
    public class NavButton : Button
    {
        public NavButton()
        {
            SetGeneralProps();
            BackColor = Color.FromArgb(50, 52, 77);
            Size = new Size(200, 40);
        }

        public NavButton(NavButton parentButton)
        {
            SetGeneralProps();
            Size = new Size(140, 40);
            ParentButton = parentButton;
        }

        public NavButton
            ParentButton
        {
            get;
            set;
        } // Если ParentButton != null, то это кнопка, являющаяся элементом "выпадающего" меню

        private void SetGeneralProps()
        {
            TextAlign = ContentAlignment.MiddleLeft;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.FromArgb(155, 250, 255);
            Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);
        }
    }
}