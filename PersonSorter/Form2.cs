using System;
using System.Drawing;
using System.Windows.Forms;
using PersonSorter.Properties;

namespace PersonSorter
{
    public partial class Form2 : Form
    {
        public ListViewItem PersonData { get; set; }
        public Form2(ListViewItem personData)
        {
            InitializeComponent();
            this.textBox1.Text = personData.SubItems[1].Text;
            this.textBox2.Text = personData.SubItems[2].Text;
            this.comboBox1.Text = personData.SubItems[3].Text;
            this.comboBox2.Text = string.Concat(personData.SubItems[4].Text.Split('.')[0], '.'); 
            this.comboBox3.Text = string.Concat(personData.SubItems[4].Text.Split('.')[1], '.');
            this.comboBox4.Text = string.Concat(personData.SubItems[4].Text.Split('.')[2], '.');
            this.textBox5.Text = personData.SubItems[5].Text;
            this.textBox6.Text = personData.SubItems[6].Text;
            this.PersonData = personData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadToForm1();
            this.Close();
        }

        public void LoadToForm1()
        {
            if (this.textBox1.Text != string.Empty && this.textBox2.Text != string.Empty &&
                this.comboBox1.Text != string.Empty && this.comboBox2.Text != string.Empty &&
                this.comboBox3.Text != string.Empty && this.comboBox4.Text != string.Empty &&
                this.textBox5.Text != string.Empty && this.textBox6.Text != string.Empty)
            {
                this.PersonData.SubItems[1].Text = this.textBox1.Text;
                this.PersonData.SubItems[2].Text = this.textBox2.Text;
                this.PersonData.SubItems[3].Text = this.comboBox1.Text;
                this.PersonData.SubItems[4].Text = this.comboBox2.Text + this.comboBox3.Text + this.comboBox4.Text;
                this.PersonData.SubItems[5].Text = this.textBox5.Text;
                this.PersonData.SubItems[6].Text = this.textBox6.Text;
            }
        }
    }
}
