using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PersonSorter
{
    /// <summary>
    /// Class that contains all methods needed for setting up the main window of the application.
    /// </summary>
    public partial class MainWindowForm : Form
    {
        private List<Person> personList = new List<Person>();
        private int registeredPersons;
        private int flagFirstName = 1;
        private int flagLastName = 1;
        private int flagGender = 1;
        private int flagBirthdate = 1;
        private int flagCountryOfBirth = 1;
        private int flagPlaceOfBirth = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowForm"/> class.
        /// </summary>
        public MainWindowForm()
        {
            this.InitializeComponent();
            this.ListViewSetUp();
        }

        /// <summary>
        /// Sets up the List View of registered users (including columns).
        /// </summary>
        private void ListViewSetUp()
        {
            this.registeredUsersListView.View = View.Details;
            var oppositeArrows = char.ConvertFromUtf32(8595) + char.ConvertFromUtf32(8593);
            this.registeredUsersListView.Columns.Add("No.", 36, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("First Name " + oppositeArrows, 86, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("Last Name " + oppositeArrows, 86, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("Gender " + oppositeArrows, 76, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("Birthdate " + oppositeArrows, 76, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("Country of Birth " + oppositeArrows, 107, HorizontalAlignment.Left);
            this.registeredUsersListView.Columns.Add("Place of Birth " + oppositeArrows, 107, HorizontalAlignment.Left);

            this.GenerateAndDisplayFewPersons();
        }


        /// <summary>
        /// Generates few initial registered users (For experiment, only.).
        /// </summary>
        private void GenerateAndDisplayFewPersons()
        {
            var person1 = new Person("Pavle", "Pavičić", "Male", "8.9.1997.", "Croatia", "Zagreb");
            var person2 = new Person("Nikola", "Pavičić", "Male", "21.4.2004.", "Croatia", "Zagreb");
            var person3 = new Person("Avgustin", "Pavičić", "Male", "28.8.1967.", "Bosnia and Herzegovina", "Jajce");
            var person4 = new Person("Stanislava", "Sečkar Pavičić", "Female", "13.2.1969.", "Croatia", "Slavonski Brod");
            var person5 = new Person("Dwyane", "Wade", "Male", "17.1.1982.", "USA", "Illinois");
            var person6 = new Person("Dolly", "Parton", "Female", "19.1.1946.", "USA", "Tennessee");
            this.personList.AddRange(new List<Person> {person1, person2, person3, person4, person5, person6});

            this.DisplayPersons();
        }

        /// <summary>
        /// Displays all Person() instances inside this.personList in the List View.
        /// </summary>
        private void DisplayPersons()
        {
            this.registeredPersons = 0;
            this.registeredUsersListView.Items.Clear();
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
                this.registeredUsersListView.Items.Add(item);
            }
        }


        /// <summary>
        /// Displays proper message through pop-up window.
        /// </summary>
        /// <param name="message">Represents a feedback information to user.</param>
        /// <param name="infoType">Represents type of feedback information (LOG, WARNING, ERROR).</param>
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

        /// <summary>
        /// Removes all user entries inside Registration Text Boxes and Combo Boxes.
        /// </summary>
        private void ClearRegistrationField()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.countryOfBirthTextBox.Clear();
            this.placeOfBirthTextBox.Clear();
            this.genderComboBox.SelectedIndex = -1;
            this.dayComboBox.SelectedIndex = -1;
            this.monthComboBox.SelectedIndex = -1;
            this.yearComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Saves new Person() instance into this.personList.
        /// </summary>
        /// <param name="sender">Parameter that contains a reference to the control or object which raised the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
        private void RegistryButton_Click(object sender, EventArgs e)
        {
            if (this.firstNameTextBox.Text != string.Empty && this.lastNameTextBox.Text != string.Empty &&
                this.genderComboBox.Text != string.Empty && this.dayComboBox.Text != string.Empty &&
                this.monthComboBox.Text != string.Empty && this.yearComboBox.Text != string.Empty &&
                this.countryOfBirthTextBox.Text != string.Empty && this.placeOfBirthTextBox.Text != string.Empty)
            {
                this.personList.Add(new Person(char.ToUpper(this.firstNameTextBox.Text[0]) + this.firstNameTextBox.Text.Substring(1),
                                        char.ToUpper(this.lastNameTextBox.Text[0]) + this.lastNameTextBox.Text.Substring(1),
                                        this.genderComboBox.Text,
                                        this.dayComboBox.Text + this.monthComboBox.Text + this.yearComboBox.Text,
                                        char.ToUpper(this.countryOfBirthTextBox.Text[0]) + this.countryOfBirthTextBox.Text.Substring(1),
                                        char.ToUpper(this.placeOfBirthTextBox.Text[0]) + this.placeOfBirthTextBox.Text.Substring(1)));

                this.DisplayPersons();
                this.DisplayMessage("Person has been registered.", "LOG");
                this.ClearRegistrationField();
            }
            else
            {
                this.DisplayMessage("You have to fill out all registration fields.", "WARNING");
            }
        }

        /// <summary>
        /// Removes Person() instances from this.personList.
        /// </summary>
        /// <param name="sender">Parameter that contains a reference to the control or object which raised the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (this.registeredUsersListView.SelectedItems.Count == 0)
            {
                this.DisplayMessage("Select persons You wish to remove from the list.", "ERROR");
            }
            else
            {
                var allSequenceNumbersToRemove = new List<int>();
                foreach (ListViewItem item in this.registeredUsersListView.SelectedItems)
                {
                    allSequenceNumbersToRemove.Add(Convert.ToInt32(item.SubItems[0].Text.Split('.')[0]));
                    this.registeredUsersListView.Items.Remove(item);
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
        }

        /// <summary>
        /// Edits a single Person() instance from this.personList.
        /// </summary>
        /// <param name="sender">Parameter that contains a reference to the control or object which raised the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.registeredUsersListView.SelectedItems.Count != 1)
            {
                this.DisplayMessage("Select exactly one person to edit their data.", "ERROR");
            }
            else
            {
                var f2 = new EditForm(this.registeredUsersListView.SelectedItems[0]);
                f2.ShowDialog();
                this.registeredUsersListView.SelectedItems[0].SubItems[1].Text = f2.PersonData.SubItems[1].Text;
                this.registeredUsersListView.SelectedItems[0].SubItems[2].Text = f2.PersonData.SubItems[2].Text;
                this.registeredUsersListView.SelectedItems[0].SubItems[3].Text = f2.PersonData.SubItems[3].Text;
                this.registeredUsersListView.SelectedItems[0].SubItems[4].Text = f2.PersonData.SubItems[4].Text;
                this.registeredUsersListView.SelectedItems[0].SubItems[5].Text = f2.PersonData.SubItems[5].Text;
                this.registeredUsersListView.SelectedItems[0].SubItems[6].Text = f2.PersonData.SubItems[6].Text;

                foreach (var personData in this.personList.Where(person => person.SequenceNumber == Convert.ToInt32(f2.PersonData.SubItems[0].Text.Split('.')[0])))
                {
                    personData.Name = this.registeredUsersListView.SelectedItems[0].SubItems[1].Text;
                    personData.LastName = this.registeredUsersListView.SelectedItems[0].SubItems[2].Text;
                    personData.Gender = this.registeredUsersListView.SelectedItems[0].SubItems[3].Text;
                    personData.Birthdate = new DateTime(Convert.ToInt32(this.registeredUsersListView.SelectedItems[0].SubItems[4].Text.Split('.')[2]), Convert.ToInt32(this.registeredUsersListView.SelectedItems[0].SubItems[4].Text.Split('.')[1]), Convert.ToInt32(this.registeredUsersListView.SelectedItems[0].SubItems[4].Text.Split('.')[0]));
                    personData.CountryOfBirth = this.registeredUsersListView.SelectedItems[0].SubItems[5].Text;
                    personData.PlaceOfBirth = this.registeredUsersListView.SelectedItems[0].SubItems[6].Text;
                }
            }
        }

        /// <summary>
        /// Sorts this.personList in List View regarding the clicked column.
        /// </summary>
        /// <param name="sender">Parameter that contains a reference to the control or object which raised the event.</param>
        /// <param name="e">Parameter that contains event data.</param>
        private void RegisteredUsersListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    this.personList = this.personList.OrderBy(person => person.Name).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(11) + char.ConvertFromUtf32(8595);
                    if (this.flagFirstName % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(11) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagFirstName++;
                    this.DisplayPersons();
                    break;
                case 2:
                    this.personList = this.personList.OrderBy(person => person.LastName).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8595);
                    if (this.flagLastName % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagLastName++;
                    this.DisplayPersons();
                    break;
                case 3:
                    this.personList = this.personList.OrderBy(person => person.Gender).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(7) + char.ConvertFromUtf32(8595);
                    if (this.flagGender % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(7) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagGender++;
                    this.DisplayPersons();
                    break;
                case 4:
                    this.personList = this.personList.OrderBy(person => person.Birthdate).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8595);
                    if (this.flagBirthdate % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(10) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagBirthdate++;
                    this.DisplayPersons();
                    break;
                case 5:
                    this.personList = this.personList.OrderBy(person => person.CountryOfBirth).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(17) + char.ConvertFromUtf32(8595);
                    if (this.flagCountryOfBirth % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(17) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagCountryOfBirth++;
                    this.DisplayPersons();
                    break;
                case 6:
                    this.personList = this.personList.OrderBy(person => person.PlaceOfBirth).ToList();
                    this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(15) + char.ConvertFromUtf32(8595);
                    if (this.flagPlaceOfBirth % 2 == 0)
                    {
                        this.registeredUsersListView.Columns[e.Column].Text = this.registeredUsersListView.Columns[e.Column].Text.Remove(15) + char.ConvertFromUtf32(8593);
                        this.personList.Reverse();
                    }

                    this.flagPlaceOfBirth++;
                    this.DisplayPersons();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Could not identify column.");
            }
        }
    }
}
