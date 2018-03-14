using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bonus
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        int y = 0;
        int k = 0;
        List<Button> body = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            Width = 420;
            Height = 420;
        }

        bool F()
        {
            int x = button1.Location.X;
            int y = button1.Location.Y;
            int w = button1.Width;
            for (int i = 0; i < body.Count; i++)
            {
                int x1 = body[i].Location.X;
                int y1 = body[i].Location.Y;
                int w1 = body[i].Width;
                if (x > x1 && y > y1)
                {
                    if (y + w - y1 < w + w1 && x + w - x1 < w + w1)
                        {
                        return true;
                    }
                }
                if (x < x1 && y > y1) 
                {
                    if (y + w - y1 < w + w1 && x1 + w1 - x < w + w1 )
                    {
                        return true;
                    }
                }
                if(x>x1 && y < y1)
                {
                    if (y1 + w1 - y < w + w1 && x + w - x1 < w + w1)
                    {
                        return true;
                    }
                }
                if (x < x1 && y < y1)
                {
                    if (y1 + w1 - y < w + w1 && x1 + w1 - x < w + w1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k % 60 == 0)
            {
                Button btn = new Button();
                Random rdm = new Random();
                btn.Text = "";
                btn.BackColor = Color.Green;
                int x = rdm.Next(0, Width - 40);
                btn.Size = new Size(30, 30);
                body.Add(btn);
                Controls.Add(btn);
                btn.Location = new Point(x, y);
                label1.Text = cnt.ToString();
            }
            if (F())
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER!!!" + "\n" + "Your Score = " + cnt.ToString());
            }
            else
            {
                for (int i = 0; i < body.Count; i++)
                {
                    int a = body[i].Location.Y;
                    int b = body[i].Location.X;
                    a++;
                    if (a <= Height-45)
                    {
                        body[i].Location = new Point(b, a);
                    }
                    else
                    {
                        cnt++;
                        Button btr = body[i];
                        body.Remove(btr);
                        this.Controls.Remove(btr);
                    }
                }
            }
            k++;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown_1(object sender, KeyEventArgs e)
        {

            int n = 0;
            int m = 0;
            if (e.KeyCode == Keys.W)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                m = m - 10;
                button1.Location = new Point(n, m);
            }
            if (e.KeyCode == Keys.S)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                m = m + 10;
                button1.Location = new Point(n, m);
            }
            if (e.KeyCode == Keys.D)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                n += 10;
                button1.Location = new Point(n, m);
            }
            if (e.KeyCode == Keys.A)
            {
                n = button1.Location.X;
                m = button1.Location.Y;
                n -= 10;
                button1.Location = new Point(n, m);
            }
        }
    }
}

