using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        private Form1 acc { get; set; }
        private Ajout aj { get; set; }
        public static Entities entity { get; set; }

        public Principal(Form1 accueil)
        {
            InitializeComponent();

            entity = new Entities();
            this.InitComboBox();

            this.acc = accueil;
        }

        private void InitComboBox()
        {
            this.PersonneComboBox.Items.Clear();
            this.PersonneComboBox.Items.Add("");
            foreach(Personne p in entity.Personne)
            {
                string s = string.Format("[{0}] {1} {2} {3}", p.id_pers, p.nom, p.prenom, p.age != null ? string.Concat("[", p.age, "]") : null);
                this.PersonneComboBox.Items.Add(s);
            }

            this.PaysComboBox.Items.Clear();
            this.PaysComboBox.Items.Add("");
            foreach (Pays p in entity.Pays)
            {
                string s = string.Format("[{0}] {1}", p.id_pays, p.nom_pays);
                this.PaysComboBox.Items.Add(s);
            }

            this.CommandeComboBox.Items.Clear();
            this.CommandeComboBox.Items.Add("");
            foreach (Commande p in entity.Commande)
            {
                Personne pers = entity.Personne.FirstOrDefault(a => a.id_pers == p.id_pers);
                string s = string.Format("{0} {1}", pers.nom, pers.prenom);
                
                Bien b = entity.Bien.FirstOrDefault(a => a.id_bien == p.id_bien);

                string str = string.Format("[{0}] {1} achète {2} de {3}.", p.id_cmd,s, p.quantite, b.type);
                this.CommandeComboBox.Items.Add(str);
            }

            this.BienComboBox.Items.Clear();
            this.BienComboBox.Items.Add("");
            foreach (Bien p in entity.Bien)
            {
                string s = string.Format("[{0}] {1}", p.id_bien, p.type);
                this.BienComboBox.Items.Add(s);
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.acc.Show();
            this.Close();
        }

        private void ChercheButton_Click(object sender, EventArgs e)
        {
            this.dataGridView.Columns.Clear();
            this.dataGridView.Rows.Clear();

            this.dataGridView.Columns.Add("Prénom", "Prénom");
            this.dataGridView.Columns.Add("Nom", "Nom");
            this.dataGridView.Columns.Add("Age", "Age");
            this.dataGridView.Columns.Add("Quantité", "Quantité");
            this.dataGridView.Columns.Add("Type", "Type");

            foreach(Commande p in entity.Commande)
            {
                if (this.PersonneComboBox.SelectedItem != null)
                {
                    string id_pers = this.PersonneComboBox.SelectedItem.ToString().Split('[')[1].Split(']')[0];
                    if (this.PersonneComboBox.SelectedItem.ToString() != "" && p.id_pers != int.Parse(id_pers))
                        continue;
                }

                if (this.BienComboBox.SelectedItem != null)
                {
                    string id_bien = this.BienComboBox.SelectedItem.ToString().Split('[')[1].Split(']')[0];
                    if (this.BienComboBox.SelectedItem.ToString() != "" && p.id_bien != int.Parse(id_bien))
                        continue;
                }

                if (this.CommandeComboBox.SelectedItem != null)
                {
                    string id_cmd = this.CommandeComboBox.SelectedItem.ToString().Split('[')[1].Split(']')[0];
                    if (this.CommandeComboBox.SelectedItem.ToString() != "" && p.id_cmd != int.Parse(id_cmd))
                        continue;
                }

                Personne pers = Principal.entity.Personne.FirstOrDefault(a => a.id_pers == p.id_pers);
                Bien bien = Principal.entity.Bien.FirstOrDefault(a => a.id_bien == p.id_bien);
                this.dataGridView.Rows.Add(pers.prenom, pers.nom, pers.age, p.quantite, bien.type);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.aj = new Ajout(this);
            this.Hide();
            this.aj.Show();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            this.aj = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.InitComboBox();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.acc.Close();
        }
    }
}
