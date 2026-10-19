using CegesAutoNyilvatartas.Data;
using CegesAutoNyilvatartas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CegesAutoNyilvatartas
{
    public partial class Emberek : Form
    {
        public Emberek()
        {
            InitializeComponent();
        }

        private void Emberek_Load(object sender, EventArgs e)
        {
            Emberek_Betolt();
        }



        private void btnMentes_Click(object sender, EventArgs e)
        {

            using AutoNyilvContext db = new AutoNyilvContext();

            db.Peoples.Add(new People
            {
                Name = txtNev.Text,
                Class = txtOsztaly.Text,
            });

            db.SaveChanges();
            Emberek_Betolt();
            mezoUtites();
        }


        private void Emberek_Betolt()
        {
            using AutoNyilvContext db = new AutoNyilvContext();
            lstEmberek.Items.Clear();
            foreach (People people in db.Peoples)
            {
                lstEmberek.Items.Add(people);
            }
            btnModositas.Enabled = false;
            btnTorles.Enabled = false;
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            //if (lstEmberek.SelectedItem is not People kivalasztott)
            //{
            //    MessageBox.Show("Nincs kiválasztott ember!"+kivalasztott.ToString());
            //    return;
            //}

            if (lstEmberek.SelectedItem == null)
            {
                MessageBox.Show("Nincs kiválasztott ember!");
                return;
            }
            People kivalasztott = (People)lstEmberek.SelectedItem;

            if (MessageBox.Show($"Biztosan törlöd {kivalasztott.Name}?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            { return; }

            using AutoNyilvContext db = new AutoNyilvContext();
            People torlendo = db.Peoples.Find(kivalasztott.Id);

            if (torlendo != null)
            {
                db.Peoples.Remove(torlendo);
                db.SaveChanges();
                Emberek_Betolt();
                mezoUtites();
            }

        }

        private void lstEmberek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmberek.SelectedItem == null)
            {
                return;
            }

            People kivalasztott = (People)lstEmberek.SelectedItem;
            txtNev.Text = kivalasztott.Name;
            txtOsztaly.Text = kivalasztott.Class;
            btnModositas.Enabled = true;
            btnTorles.Enabled = true;
        }

        private void mezoUtites()
        {
            txtNev.Clear();
            txtOsztaly.Clear();
            lstEmberek.ClearSelected();
            errorProvider1.Clear();
            btnModositas.Enabled = false;
            btnTorles.Enabled = false;
            txtNev.Focus();

        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtNev.Text))
            {
                errorProvider1.SetError(txtNev, "A név mező nem lehet üres!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOsztaly.Text))
            {
                errorProvider1.SetError(txtOsztaly, "A osztály mező nem lehet üres!");
                return;
            }

            if (lstEmberek.SelectedItem == null)
            {
                return;
            }

            using AutoNyilvContext db = new AutoNyilvContext();

            People kivalasztott = (People)lstEmberek.SelectedItem;
            People modositando = db.Peoples.Find(kivalasztott.Id);
            modositando.Name = txtNev.Text;
            modositando.Class = txtOsztaly.Text;

            db.SaveChanges();
            mezoUtites();
            Emberek_Betolt();

        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            mezoUtites();
        }
    }
}
