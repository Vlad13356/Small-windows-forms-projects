using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2025._03._18_L2_MSOA
{
    public partial class Form1 : Form
    {
        private List<Persoana> persoane = new List<Persoana>();
        private TreeNode[] radacini = new TreeNode[4];
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            TreeNode prieteni = new TreeNode();
            prieteni.Text = Categorie.Prieteni.ToString();
            prieteni.Name = Categorie.Prieteni.ToString();
            radacini[0] = prieteni;

            TreeNode colegi = new TreeNode();
            colegi.Text = Categorie.Colegi.ToString();
            colegi.Name = Categorie.Colegi.ToString();
            radacini[1] = colegi;

            TreeNode rude = new TreeNode();
            rude.Text = Categorie.Rude.ToString();
            rude.Name = Categorie.Rude.ToString();
            radacini[2] = rude;

            TreeNode diversi = new TreeNode();
            diversi.Text = Categorie.Diversi.ToString();
            diversi.Name = Categorie.Diversi.ToString();
            radacini[3] = diversi;

            treeViewAgenda.Nodes.Add(radacini[0]);
            treeViewAgenda.Nodes.Add(radacini[1]);
            treeViewAgenda.Nodes.Add(radacini[2]);
            treeViewAgenda.Nodes.Add(radacini[3]);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string telefon = txtTelefon.Text;
            Categorie categorie = (Categorie)cmbCategorie.SelectedIndex;

            Persoana p = new Persoana(nume, telefon, categorie);
            persoane.Add(p);
            TreeNode node = new TreeNode();

            node.Text = nume;
            radacini[(int)categorie].Nodes.Add(node);
        }

        private void treeViewAgenda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (radacini.Contains(e.Node))
                return;
            string nume = e.Node.Text;
            Persoana pers = persoane.Find((p) => p.Nume == nume);
            if (pers != null)
                pgAgenda.SelectedObject = pers;
            else
                pgAgenda.SelectedObject = null;
        }

        private void pgAgenda_Click(object sender, EventArgs e)
        {

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string telefon = txtTelefon.Text;
            Categorie categorie = (Categorie)cmbCategorie.SelectedIndex;
            Persoana p=new Persoana(nume, telefon, categorie);
            pgAgenda.SelectedObject = p;
            if (MessageBox.Show("Doriti sa stergeti persoana [" + p.Nume + "]?", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                treeViewAgenda.SelectedNode.Remove();

            }


        }
    }
}

  
