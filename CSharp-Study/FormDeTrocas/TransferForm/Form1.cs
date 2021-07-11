using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lista1Passa1_Click(object sender, EventArgs e)
        {
            if (lista1.SelectedIndices.Count > 0)
            {
                foreach(int i in lista1.SelectedIndices)
                {
                    lista2.Items.Add(lista1.Items[i]);
                    lista1.Items.RemoveAt(i);
                }
            }
        }

        private void lista1PassaTudo_Click(object sender, EventArgs e)
        {
            while(lista1.Items.Count > 0)
            {
                lista2.Items.Add(lista1.Items[0]);
                lista1.Items.RemoveAt(0);
            }
        }

        private void Lista1Apaga_Click(object sender, EventArgs e)
        {
            lista1.Items.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lista2.SelectedIndices.Count > 0)
            {
                foreach (int i in lista2.SelectedIndices)
                {
                    lista1.Items.Add(lista2.Items[i]);
                    lista2.Items.RemoveAt(i);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            while (lista2.Items.Count > 0)
            {
                lista1.Items.Add(lista2.Items[0]);
                lista2.Items.RemoveAt(0);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            lista2.Items.Clear();
        }


        private void CheckBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                lista1.SelectionMode = SelectionMode.MultiExtended;
                lista2.SelectionMode = SelectionMode.MultiExtended;
            }
            else
            {
                lista1.SelectionMode = SelectionMode.One;
                lista2.SelectionMode = SelectionMode.One;
            }
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e != null)
            {
                lista1.Items.Add(comboBox1.SelectedItem);
            }
        }
    /*
     Two different ways to validate if there's no selected ComboItem
    */

        private void ComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox2.SelectedItem != null)
            {
                lista2.Items.Add(comboBox2.SelectedItem);
            }
        }
    }
}
