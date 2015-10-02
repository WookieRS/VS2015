using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashThing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            while (Visible)                                                     //После закрытия окна становится false
            {
                for (int c = 0; c < 255 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(255, 255 - c, 255 - c);
                    Application.DoEvents();                                     //Принудительно обновляет форму. НЕ СЛЕДУЕТ ПРИМЕНЯТЬ!!
                    System.Threading.Thread.Sleep(10);                          //Задержка на 10 мс
                    label1.Text = "c: " + c.ToString();
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(255, 255 - c, 255 - c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                    label1.Text = "c: " + c.ToString();
                }
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
