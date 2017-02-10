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
    public partial class Ajout : Form
    {
        private Principal princ { get; set; }

        public Ajout(Principal pr)
        {
            InitializeComponent();

            this.princ = pr;
            this.InitComboBox();
            this.CacheTout();
        }

        private void CacheTout()
        {
            this.label1.Text = "--";
            this.label2.Text = "--";
            this.label3.Text = "--";
            this.label4.Text = "--";
            this.label5.Text = "--";
            this.label6.Text = "--";

            this.textBox1.Enabled = false;
            this.textBox1.Text = "";
            this.textBox2.Enabled = false;
            this.textBox2.Text = "";
            this.textBox3.Enabled = false;
            this.textBox3.Text = "";
            this.textBox4.Enabled = false;
            this.textBox4.Text = "";
            this.textBox5.Enabled = false;
            this.textBox5.Text = "";
            this.textBox6.Enabled = false;
            this.textBox6.Text = "";
        }

        private void InitComboBox()
        {
            this.TypeComboBox.Items.Add("Personne");
            this.TypeComboBox.Items.Add("Pays");
            this.TypeComboBox.Items.Add("Commande");
            this.TypeComboBox.Items.Add("Bien");
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            princ.Show();
            this.Close();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CacheTout();
            if (this.TypeComboBox.SelectedItem.ToString() == "Personne")
            {
                this.label1.Text = "Nom: *";
                this.textBox1.Enabled = true;

                this.label2.Text = "Prénom: ";
                this.textBox2.Enabled = true;

                this.label3.Text = "Age: ";
                this.textBox3.Enabled = true;
            }
            else if (this.TypeComboBox.SelectedItem.ToString() == "Commande")
            {
                this.label1.Text = "Type de bien: *";
                this.textBox1.Enabled = true;

                this.label2.Text = "Quantité: *";
                this.textBox2.Enabled = true;

                this.label3.Text = "Nom de la personne: ";
                this.textBox3.Enabled = true;
            }
            else if (this.TypeComboBox.SelectedItem.ToString() == "Bien")
            {
                this.label1.Text = "Type: *";
                this.textBox1.Enabled = true;

                this.label2.Text = "Commentaire: ";
                this.textBox2.Enabled = true;
            }
            else if (this.TypeComboBox.SelectedItem.ToString() == "Pays")
            {
                this.label1.Text = "Nom: *";
                this.textBox1.Enabled = true;
            }
        }

        private void AjoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TypeComboBox.SelectedItem.ToString() == "Personne")
                {
                    Personne p = Personne.CreatePersonne(0, this.textBox1.Text);
                    p.prenom = this.textBox2.Text;
                    p.age = int.Parse(this.textBox3.Text);

                    Principal.entity.AddToPersonne(p);
                    Principal.entity.SaveChanges();

                    MessageBox.Show(string.Format("Personne ajoutée: {0}", p.prenom));
                }
                else if (this.TypeComboBox.SelectedItem.ToString() == "Commande")
                {
                    int id_pers = 0;
                    int id_bien = 0;

                    Personne pers = Principal.entity.Personne.FirstOrDefault(a => a.nom == this.textBox3.Text);
                    if (pers == null)
                    {
                        MessageBox.Show(string.Concat("Impossible de trouver la personne: ", this.textBox3.Text, "."));
                        return;
                    }
                    else
                        id_pers = pers.id_pers;

                    Bien bien = Principal.entity.Bien.FirstOrDefault(a => a.type == this.textBox1.Text);
                    if (bien == null)
                    {
                        MessageBox.Show(string.Concat("Impossible de trouver le type de bien: ", this.textBox1.Text, "."));
                        return;
                    }
                    else
                        id_bien = bien.id_bien;

                    Commande cmd = Commande.CreateCommande(1, id_pers, id_bien, int.Parse(this.textBox2.Text));

                    Principal.entity.AddToCommande(cmd);
                    Principal.entity.SaveChanges();

                    MessageBox.Show("Commande ajoutée !");
                }
                else if (this.TypeComboBox.SelectedItem.ToString() == "Bien")
                {
                    Bien p = Bien.CreateBien(0, this.textBox1.Text);
                    p.commentaire = this.textBox2.Text;

                    Principal.entity.AddToBien(p);
                    Principal.entity.SaveChanges();

                    MessageBox.Show(string.Format("Bien ajouté: {0}", p.type));
                }
                else if (this.TypeComboBox.SelectedItem.ToString() == "Pays")
                {
                    Pays p = Pays.CreatePays(0, this.textBox1.Text);

                    Principal.entity.AddToPays(p);
                    Principal.entity.SaveChanges();

                    MessageBox.Show(string.Format("Pays ajouté: {0}", p.nom_pays));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                this.CacheTout();
            }
        }

        private void Ajout_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            this.princ.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.princ.Show();
            this.Close();
        }
    }
}
