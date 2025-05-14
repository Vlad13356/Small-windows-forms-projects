using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._04_L3_MSOA
{
    public partial class AdaugareJucator : Form
    {
        public string CNP { get => txtCNP.Text;
            set => txtCNP.Text = value;
        }

        public string Nume { get => txtNume.Text;
            set => txtNume.Text = value;
        }

        public Post Post { get => (Post)Enum.Parse(typeof(Post), 
            cmbPost.Text);
            set => cmbPost.Text = value.ToString();
        }

        public AdaugareJucator()
        {
            InitializeComponent();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
