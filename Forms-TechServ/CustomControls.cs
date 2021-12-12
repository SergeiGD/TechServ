using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Forms_TechServ
{
    public class ManageButton : Button
    {
        public ManageButton()
        {
            this.Size = new Size(190, 40);
            this.BackColor = Color.FromArgb(51, 225, 231);
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }
    }

    public class EditButton : Button
    {
        public EditButton()
        {
            this.Size = new Size(150, 30);
            this.BackColor = Color.FromArgb(51, 225, 231);
            this.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.TextAlign = ContentAlignment.MiddleLeft;
        }
    }

    public class NavButton : Button
    {

        public NavButton()
        {
            SetGeneralProps();
            this.BackColor = Color.FromArgb(50, 52, 77);
            this.Size = new Size(200, 40);
        }

        public NavButton(NavButton parentButton)
        {
            SetGeneralProps();
            this.Size = new Size(140, 40);
            ParentButton = parentButton;
        }

        public NavButton ParentButton { get; set; }            // Если ParentButton != null, то это кнопка, являющаяся элементом "выпадающего" меню

        private void SetGeneralProps()
        {
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor = Color.FromArgb(155, 250, 255);
            this.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
