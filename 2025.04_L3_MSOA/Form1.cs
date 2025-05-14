using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025._04_L3_MSOA
{
    public partial class Form1 : Form
    {
        string[] pathEchipe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //legatura cu form Login

            string path = Application.StartupPath;
            string[] echipe = Directory.EnumerateDirectories(path).ToArray();
            pathEchipe = echipe;
            foreach (string echipa in echipe)
            {
                DirectoryInfo infoEchipa = new DirectoryInfo(echipa);
                cmbEchipa.Items.Add(infoEchipa.Name);
            }
        }

        private void cmbEchipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string echipa = pathEchipe[cmbEchipa.SelectedIndex];
            string[] jucatori = Directory.EnumerateFiles(echipa).ToArray();
            flpEchipa.Controls.Clear();
            foreach (string jucator in jucatori)
            {
                string cnp = Path.GetFileNameWithoutExtension(jucator);
                StreamReader reader = new StreamReader(jucator);
                string nume = reader.ReadLine();
                Post post = (Post)Enum.Parse(typeof(Post), reader.ReadLine());

                Button b = new Button();
                Jucator j = new Jucator(cnp, nume, post);
                b.Width = 200;
                b.Text = nume;
                b.Tag = j;
                //de adaugat eveniment

                b.Click += Btn_Click;
                flpEchipa.Controls.Add(b);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Jucator j = (Jucator)b.Tag;
            txtNume.Text = j.Nume;
            txtPost.Text = j.Post.ToString();
            txtCNP.Text = j.CNP;
        }

        private void btnJucator_Click(object sender, EventArgs e)
        {
            AdaugareJucator j = new AdaugareJucator();
            if (j.ShowDialog() == DialogResult.OK)
            {
                string filename = Application.StartupPath +
                    "\\" + cmbEchipa.Text + "\\" + j.CNP + ".lpf";
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(j.Nume);
                    sw.WriteLine(j.Post);
                }
            }
        }
    }
}
