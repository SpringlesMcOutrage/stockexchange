using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stockexchange
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            users usersForm = new users();
            usersForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            assets assetsForm = new assets();
            assetsForm.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Exchanges form = new Exchanges();
            form.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
    }
}
