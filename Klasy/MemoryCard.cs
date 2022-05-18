using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMemory.Klasy
{
    public class MemoryCard : Label
    {
        public Guid ID;
        public Image Back;
        public Image Front;

        public MemoryCard(Guid iD, string back, string front)
        {
            ID = iD;
            Back = Image.FromFile(back);
            Front = Image.FromFile(front);

            BackgroundImageLayout = ImageLayout.Stretch;
        }

        //Metody zakrywania i odkrywania kart
        public void HideCard()
        {
            BackgroundImage = Back;
            Enabled = true;
        }

        public void ShowCard()
        {
            BackgroundImage = Front;
            Enabled = false;
        }

    }
}
