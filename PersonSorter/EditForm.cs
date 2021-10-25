using System;
using System.Windows.Forms;

namespace PersonSorter
{
    public partial class EditForm : Form
    {
        public ListViewItem PersonData { get; set; }
        public EditForm(ListViewItem personData)
        {
            this.InitializeComponent();
            this.LoadToEditForm(personData);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.LoadToMainWindowForm();
            this.Close();
        }

        public void LoadToMainWindowForm()
        {
            if (this.firstNameTextBox.Text != string.Empty && this.lastNameTextBox.Text != string.Empty &&
                this.genderComboBox.Text != string.Empty && this.dayComboBox.Text != string.Empty &&
                this.monthComboBox.Text != string.Empty && this.yearComboBox.Text != string.Empty &&
                this.countryOfBirthTextBox.Text != string.Empty && this.placeOfBirthTextBox.Text != string.Empty)
            {
                this.PersonData.SubItems[1].Text = this.firstNameTextBox.Text;
                this.PersonData.SubItems[2].Text = this.lastNameTextBox.Text;
                this.PersonData.SubItems[3].Text = this.genderComboBox.Text;
                this.PersonData.SubItems[4].Text = this.dayComboBox.Text + this.monthComboBox.Text + this.yearComboBox.Text;
                this.PersonData.SubItems[4].Text = this.dayComboBox.Text + this.monthComboBox.Text + this.yearComboBox.Text;
                this.PersonData.SubItems[5].Text = this.countryOfBirthTextBox.Text;
                this.PersonData.SubItems[6].Text = this.placeOfBirthTextBox.Text;
            }
        }

        private void LoadToEditForm(ListViewItem personData)
        {
            this.firstNameTextBox.Text = personData.SubItems[1].Text;
            this.lastNameTextBox.Text = personData.SubItems[2].Text;
            this.genderComboBox.Text = personData.SubItems[3].Text;
            this.dayComboBox.Text = string.Concat(personData.SubItems[4].Text.Split('.')[0], '.');
            this.monthComboBox.Text = string.Concat(personData.SubItems[4].Text.Split('.')[1], '.');
            this.yearComboBox.Text = string.Concat(personData.SubItems[4].Text.Split('.')[2], '.');
            this.countryOfBirthTextBox.Text = personData.SubItems[5].Text;
            this.placeOfBirthTextBox.Text = personData.SubItems[6].Text;
            this.PersonData = personData;
        }
    }
}

