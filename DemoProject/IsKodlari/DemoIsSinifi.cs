using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public class DemoIsSinifi
    {
        public void DialogResultChoose(DialogResult dialog)
        {
            if (dialog== DialogResult.Yes)
            {
                MessageBox.Show("Evet Tıklandı");
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("Hayır Tıklandı.");
            }
            else if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show("İptal Tıklandı.");
            }
        }
    }
}
