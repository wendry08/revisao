using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_divisao.Text);
                int b = Convert.ToInt32(tx_divisao2.Text);

                int c = a / b;

                lb_resultado.Text = c.ToString();
                MessageBox.Show(c.ToString());

            }
            catch(Exception ex) 
            {
                MessageBox.Show("erro de devisao");
            }
          

            
        }
    }
}
