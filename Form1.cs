using student2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trudim_se
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IzObjUKontr(Student student) 
        {
            txtIme.Text = student.Ime;
            txtPrez.Text = student.Prezime;
            numInd.Value = student.BrInd;
            SelektujRadioDugm(student.NivoStudija);
        }

        private void SelektujRadioDugm(NivoStudija nivoStudija)
        {
            switch (nivoStudija)
            { 
                case NivoStudija.Doktorske:
                    radDok.Checked = true; break;
                case NivoStudija.Master:
                    radMas.Checked = true; break;
                case NivoStudija.Osnovne:
                    radOsn.Checked = true; break;
            }
        }

        private void IzKontrUObj(Student student)
        {
            student.Ime = txtIme.Text;
            student.Prezime = txtPrez.Text;
            student.BrInd = (int)numInd.Value;
            student.NivoStudija = OdrediGodStud();
        }

        private NivoStudija OdrediGodStud()
        {
            if (radOsn.Checked)
                return NivoStudija.Osnovne;
            else if (radMas.Checked)
                return NivoStudija.Master;
            else
                return NivoStudija.Doktorske;
        }

        private 



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
