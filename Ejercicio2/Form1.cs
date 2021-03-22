using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lst = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String texto = txt_in.Text;
            if (texto.Equals("SUMAR"))
            {
                Int32 total = 0;
                for(int i = 0; i < lst.Count; i++)
                {
                    total += (Int32)lst[i];
                }
                texto += (" " + total);
            }
            else
            {
                try
                {
                    Int32 num = Int32.Parse(texto);
                    lst.Add(num);
                }
                catch (Exception ex)
                {
                }
            
               
            }
            txt_out.AppendText(texto + "\r\n ");
            isClicked = !isClicked;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_in.Text = "";
            txt_out.Text = "";
            lst.Clear();
        }
        bool isClicked = false;
        ArrayList lst;

    }
}
