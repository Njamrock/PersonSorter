using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PersonSorter
{
    public partial class Form1 : Form
    {
        private List<Person> personList = new List<Person>();
        private int registeredPersons;
        private int flagButton2 = 1;
        private int flagButton3 = 1;
        private int flagButton4 = 1;
        private int flagButton5 = 1;
        private int flagButton6 = 1;
        private int flagButton7 = 1;
        public Form1()
        {
            this.InitializeComponent();

            this.listView1.View = View.Details;
            var oppositeArrows = char.ConvertFromUtf32(8595) + char.ConvertFromUtf32(8593);
            this.listView1.Columns.Add("No.", 36, HorizontalAlignment.Left);
            this.listView1.Columns.Add("First Name " + oppositeArrows, 86, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Last Name " + oppositeArrows, 86, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Gender " + oppositeArrows, 76, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Birthdate " + oppositeArrows, 76, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Country of Birth " + oppositeArrows, 107, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Place of Birth " + oppositeArrows, 107, HorizontalAlignment.Left);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);

            this.GenerateAndDisplayFewPersons();
        }

        private void GenerateAndDisplayFewPersons() // TODO:01 Remove this when the whole App is implemented. 
        {
            var person1 = new Person("Pavle", "Pavičić", "Male", "8.9.1997.", "Croatia", "Zagreb");
            var person2 = new Person("Nikola", "Pavičić", "Male", "21.4.2004.", "Croatia", "Zagreb");
            var person3 = new Person("Avgustin", "Pavičić", "Male", "28.8.1967.", "Bosnia and Herzegovina", "Jajce");
            var person4 = new Person("Stanislava", "Sečkar Pavičić", "Female", "13.2.1969.", "Croatia", "Slavonski Brod");
            var person5 = new Person("Dwyane", "Wade", "Male", "17.1.1982.", "USA", "Illinois");
            var person6 = new Person("Dolly", "Parton", "Female", "19.1.1946.", "USA", "Tennessee");
            this.personList.AddRange(new List<Person>{person1, person2, person3, person4, person5, person6});

            this.DisplayPersons();
        }

        private void DisplayPersons()
        {
            this.registeredPersons = 0;
            this.listView1.Items.Clear();
            foreach (var person in this.personList)
            {
                this.registeredPersons++;
                person.SequenceNumber = this.registeredPersons;
                var item = new ListViewItem(this.registeredPersons + ".");
                item.SubItems.Add(person.Name);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Gender);
                item.SubItems.Add(person.Birthdate.ToShortDateString());
                item.SubItems.Add(person.CountryOfBirth);
                item.SubItems.Add(person.PlaceOfBirth);
                this.listView1.Items.Add(item);
            }
        }

        private void DisplayMessage(string message, string infoType)
        {
            switch (infoType)
            {
                case "LOG":
                    MessageBox.Show(message, infoType, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "WARNING":
                    MessageBox.Show(message, infoType, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "ERROR":
                    MessageBox.Show(message, infoType, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ClearRegistrationField()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            this.comboBox3.SelectedIndex = -1;
            this.comboBox4.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
        }

        /* TODO:02 Try to change images at column header of ListView just like here below.
        private void button7_Click(object sender, EventArgs e)
        {
            this.flagButton7 *= -1;
            this.button7.BackgroundImage = this.flagButton7 == -1 ? Properties.Resources.down_smaller : Properties.Resources.up_smaller;

            if (this.flagButton7 == 1)
            {
                this.SortReverseAlphabetically("PlaceOfBirth");
                this.DisplayPersons();
            }
            else
            {
                this.SortAlphabetically("PlaceOfBirth");
                this.DisplayPersons();
            }
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty && this.textBox2.Text != string.Empty &&
                this.comboBox1.Text != string.Empty && this.comboBox2.Text != string.Empty &&
                this.comboBox3.Text != string.Empty && this.comboBox4.Text != string.Empty &&
                this.textBox5.Text != string.Empty && this.textBox6.Text != string.Empty)
            {
                this.personList.Add(new Person(char.ToUpper(this.textBox1.Text[0]) + this.textBox1.Text.Substring(1),
                                        char.ToUpper(this.textBox2.Text[0]) + this.textBox2.Text.Substring(1),
                                        this.comboBox1.Text,
                                        this.comboBox2.Text + this.comboBox3.Text + this.comboBox4.Text,
                                        char.ToUpper(this.textBox5.Text[0]) + this.textBox5.Text.Substring(1),
                                        char.ToUpper(this.textBox6.Text[0]) + this.textBox6.Text.Substring(1)));

                this.DisplayPersons();
                this.DisplayMessage("Person has been registered.", "LOG");
                this.ClearRegistrationField();
            }
            else
            {
                this.DisplayMessage("You have to fill out all registration fields.", "WARNING");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var allSequenceNumbersToRemove = new List<int>();
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                allSequenceNumbersToRemove.Add(Convert.ToInt32(item.SubItems[0].Text.Split('.')[0]));
                this.listView1.Items.Remove(item);
            }

            var personsToBeRemoved = new List<Person>();
            foreach (var person in this.personList)
            {
                foreach (var sequenceNumber in allSequenceNumbersToRemove)
                {
                    if (person.SequenceNumber == sequenceNumber)
                    {
                        personsToBeRemoved.Add(person);
                    }
                }
            }

            foreach (var removablePerson in personsToBeRemoved)
            {
                this.personList.Remove(removablePerson);
            }
            this.DisplayPersons();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 1)
            {
                this.DisplayMessage("Select exactly one person to edit their data.", "ERROR");
            }
            else
            {
                Form2 f2 = new Form2(this.listView1.SelectedItems[0]);
                f2.ShowDialog();
                var a = this.listView1.SelectedItems[0].SubItems[0].Text;
                var b = f2.PersonData.SubItems[0].Text;
                this.listView1.SelectedItems[0].SubItems[1].Text = f2.PersonData.SubItems[1].Text;
                this.listView1.SelectedItems[0].SubItems[2].Text = f2.PersonData.SubItems[2].Text;
                this.listView1.SelectedItems[0].SubItems[3].Text = f2.PersonData.SubItems[3].Text;
                this.listView1.SelectedItems[0].SubItems[4].Text = f2.PersonData.SubItems[4].Text;
                this.listView1.SelectedItems[0].SubItems[5].Text = f2.PersonData.SubItems[5].Text;
                this.listView1.SelectedItems[0].SubItems[6].Text = f2.PersonData.SubItems[6].Text;

                foreach (var personData in this.personList.Where(person => person.SequenceNumber == Convert.ToInt32(f2.PersonData.SubItems[0].Text.Split('.')[0])))
                {
                    personData.Name = this.listView1.SelectedItems[0].SubItems[1].Text;
                    personData.LastName = this.listView1.SelectedItems[0].SubItems[2].Text;
                    personData.Gender = this.listView1.SelectedItems[0].SubItems[3].Text;
                    personData.Birthdate = new DateTime(Convert.ToInt32(this.listView1.SelectedItems[0].SubItems[4].Text.Split('.')[2]), Convert.ToInt32(this.listView1.SelectedItems[0].SubItems[4].Text.Split('.')[1]), Convert.ToInt32(this.listView1.SelectedItems[0].SubItems[4].Text.Split('.')[0]));
                    personData.CountryOfBirth = this.listView1.SelectedItems[0].SubItems[5].Text;
                    personData.PlaceOfBirth = this.listView1.SelectedItems[0].SubItems[6].Text;
                }

                this.DisplayMessage("Person's data has been updated.", "LOG");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    this.personList = this.personList.OrderBy(person => person.Name).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(11) + char.ConvertFromUtf32(8595);
                    if (this.flagButton2 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(11) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }
                    this.flagButton2++;
                    this.DisplayPersons();
                    break;
                case 2:
                    this.personList = this.personList.OrderBy(person => person.LastName).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8595);
                    if (this.flagButton3 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagButton3++;
                    this.DisplayPersons();
                    break;
                case 3:
                    this.personList = this.personList.OrderBy(person => person.Gender).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(7) + char.ConvertFromUtf32(8595);
                    if (this.flagButton4 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(7) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagButton4++;
                    this.DisplayPersons();
                    break;
                case 4:
                    this.personList = this.personList.OrderBy(person => person.Birthdate).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8595);
                    if (this.flagButton5 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagButton5++;
                    this.DisplayPersons();
                    break;
                case 5:
                    this.personList = this.personList.OrderBy(person => person.CountryOfBirth).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(17) + char.ConvertFromUtf32(8595);
                    if (this.flagButton6 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(17) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagButton6++;
                    this.DisplayPersons();
                    break;
                case 6:
                    this.personList = this.personList.OrderBy(person => person.PlaceOfBirth).ToList();
                    this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(15) + char.ConvertFromUtf32(8595);
                    if (this.flagButton7 % 2 == 0)
                    {
                        this.listView1.Columns[e.Column].Text = this.listView1.Columns[e.Column].Text.Remove(15) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagButton7++;
                    this.DisplayPersons();
                    break;
            }
        }
    }
}
