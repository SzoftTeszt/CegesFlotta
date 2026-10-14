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
        }


        private void Emberek_Betolt()
        {
            using AutoNyilvContext db = new AutoNyilvContext();
            lstEmberek.Items.Clear();
            foreach (People people in db.Peoples)
            {
                lstEmberek.Items.Add(people?.ToString());
            }
        }
    }
}
