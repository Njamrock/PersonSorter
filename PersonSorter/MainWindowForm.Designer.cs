using System.Windows.Forms;

/// <summary>
/// PersonSorter is a scope that contains a set of objects related to GUI app for "Person Sorter program."
/// </summary>
namespace PersonSorter
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.registryButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.countryOfBirthLabel = new System.Windows.Forms.Label();
            this.placeOfBirthLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.mottoLabel = new System.Windows.Forms.Label();
            this.dataPrivacyLabel = new System.Windows.Forms.Label();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.countryOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.placeOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.registeredUsersListView = new System.Windows.Forms.ListView();
            this.canteredImagePictureBox = new System.Windows.Forms.PictureBox();
            this.lowerDecorationPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.upperDecorationPictureBox = new System.Windows.Forms.PictureBox();
            this.registrationGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canteredImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerDecorationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDecorationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // registryButton
            // 
            this.registryButton.BackColor = System.Drawing.Color.Coral;
            this.registryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registryButton.Location = new System.Drawing.Point(175, 206);
            this.registryButton.Name = "registryButton";
            this.registryButton.Size = new System.Drawing.Size(127, 23);
            this.registryButton.TabIndex = 12;
            this.registryButton.Text = "Register Person";
            this.registryButton.UseVisualStyleBackColor = false;
            this.registryButton.Click += new System.EventHandler(this.RegistryButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Coral;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeButton.ForeColor = System.Drawing.Color.SeaShell;
            this.removeButton.Location = new System.Drawing.Point(38, 476);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(73, 23);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Coral;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.ForeColor = System.Drawing.Color.SeaShell;
            this.editButton.Location = new System.Drawing.Point(117, 476);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(63, 23);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(25, 53);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(71, 13);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(25, 79);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(71, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(25, 105);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(52, 13);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(25, 131);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(62, 13);
            this.birthdateLabel.TabIndex = 9;
            this.birthdateLabel.Text = "Birthdate:";
            // 
            // countryOfBirthLabel
            // 
            this.countryOfBirthLabel.AutoSize = true;
            this.countryOfBirthLabel.Location = new System.Drawing.Point(25, 157);
            this.countryOfBirthLabel.Name = "countryOfBirthLabel";
            this.countryOfBirthLabel.Size = new System.Drawing.Size(99, 13);
            this.countryOfBirthLabel.TabIndex = 10;
            this.countryOfBirthLabel.Text = "Country of Birth:";
            // 
            // placeOfBirthLabel
            // 
            this.placeOfBirthLabel.AutoSize = true;
            this.placeOfBirthLabel.Location = new System.Drawing.Point(25, 183);
            this.placeOfBirthLabel.Name = "placeOfBirthLabel";
            this.placeOfBirthLabel.Size = new System.Drawing.Size(88, 13);
            this.placeOfBirthLabel.TabIndex = 11;
            this.placeOfBirthLabel.Text = "Place of Birth:";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Cooper Black", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.Tomato;
            this.logoLabel.Location = new System.Drawing.Point(133, 18);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(286, 68);
            this.logoLabel.TabIndex = 19;
            this.logoLabel.Text = "MeetIng.";
            // 
            // mottoLabel
            // 
            this.mottoLabel.AutoSize = true;
            this.mottoLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mottoLabel.ForeColor = System.Drawing.Color.Tomato;
            this.mottoLabel.Location = new System.Drawing.Point(150, 86);
            this.mottoLabel.Name = "mottoLabel";
            this.mottoLabel.Size = new System.Drawing.Size(192, 19);
            this.mottoLabel.TabIndex = 20;
            this.mottoLabel.Text = "Join. Network. Work.";
            // 
            // dataPrivacyLabel
            // 
            this.dataPrivacyLabel.ForeColor = System.Drawing.Color.Coral;
            this.dataPrivacyLabel.Location = new System.Drawing.Point(6, 255);
            this.dataPrivacyLabel.Name = "dataPrivacyLabel";
            this.dataPrivacyLabel.Size = new System.Drawing.Size(318, 48);
            this.dataPrivacyLabel.TabIndex = 18;
            this.dataPrivacyLabel.Text = "*MeetIng. guarantees discretion during the storage and processing of clients\' per" +
    "sonal data. The data entered is used to connect with more suitable users.";
            // 
            // quoteLabel
            // 
            this.quoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quoteLabel.ForeColor = System.Drawing.Color.Coral;
            this.quoteLabel.Location = new System.Drawing.Point(647, 22);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(378, 97);
            this.quoteLabel.TabIndex = 23;
            this.quoteLabel.Text = "\"MeetIng. is no ordinary chatting platform.  Whether You\'re looking for a job, bu" +
    "siness partner or a person to simply exchange ideas, MeetIng. will leave You sat" +
    "isfied.\"\r\nJeff B., an active user";
            this.quoteLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.Coral;
            this.firstNameTextBox.ForeColor = System.Drawing.Color.SeaShell;
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 50);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.Coral;
            this.lastNameTextBox.ForeColor = System.Drawing.Color.SeaShell;
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 76);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // countryOfBirthTextBox
            // 
            this.countryOfBirthTextBox.BackColor = System.Drawing.Color.Coral;
            this.countryOfBirthTextBox.ForeColor = System.Drawing.Color.SeaShell;
            this.countryOfBirthTextBox.Location = new System.Drawing.Point(130, 154);
            this.countryOfBirthTextBox.Name = "countryOfBirthTextBox";
            this.countryOfBirthTextBox.Size = new System.Drawing.Size(172, 20);
            this.countryOfBirthTextBox.TabIndex = 4;
            // 
            // placeOfBirthTextBox
            // 
            this.placeOfBirthTextBox.BackColor = System.Drawing.Color.Coral;
            this.placeOfBirthTextBox.ForeColor = System.Drawing.Color.SeaShell;
            this.placeOfBirthTextBox.Location = new System.Drawing.Point(130, 180);
            this.placeOfBirthTextBox.Name = "placeOfBirthTextBox";
            this.placeOfBirthTextBox.Size = new System.Drawing.Size(172, 20);
            this.placeOfBirthTextBox.TabIndex = 7;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.Coral;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderComboBox.ForeColor = System.Drawing.Color.SeaShell;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(130, 102);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(172, 21);
            this.genderComboBox.TabIndex = 16;
            // 
            // dayComboBox
            // 
            this.dayComboBox.BackColor = System.Drawing.Color.Coral;
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayComboBox.ForeColor = System.Drawing.Color.SeaShell;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4.",
            "5.",
            "6.",
            "7.",
            "8.",
            "9.",
            "10.",
            "11.",
            "12.",
            "13.",
            "14.",
            "15.",
            "16.",
            "17.",
            "18.",
            "19.",
            "20.",
            "21.",
            "22.",
            "23.",
            "24.",
            "25.",
            "26.",
            "27.",
            "28.",
            "29.",
            "30.",
            "31."});
            this.dayComboBox.Location = new System.Drawing.Point(130, 127);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(48, 21);
            this.dayComboBox.TabIndex = 16;
            // 
            // monthComboBox
            // 
            this.monthComboBox.BackColor = System.Drawing.Color.Coral;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monthComboBox.ForeColor = System.Drawing.Color.SeaShell;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4.",
            "5.",
            "6.",
            "7.",
            "8.",
            "9.",
            "10.",
            "11.",
            "12."});
            this.monthComboBox.Location = new System.Drawing.Point(184, 127);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(52, 21);
            this.monthComboBox.TabIndex = 17;
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.Coral;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearComboBox.ForeColor = System.Drawing.Color.SeaShell;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2022.",
            "2021.",
            "2020.",
            "2019.",
            "2018.",
            "2017.",
            "2016.",
            "2015.",
            "2014.",
            "2013.",
            "2012.",
            "2011.",
            "2010.",
            "2009.",
            "2008.",
            "2007.",
            "2006.",
            "2005.",
            "2004.",
            "2003.",
            "2002.",
            "2001.",
            "2000.",
            "1999.",
            "1998.",
            "1997.",
            "1996.",
            "1995.",
            "1994.",
            "1993.",
            "1992.",
            "1991.",
            "1990.",
            "1989.",
            "1988.",
            "1987.",
            "1986.",
            "1985.",
            "1984.",
            "1983.",
            "1982.",
            "1981.",
            "1980.",
            "1979.",
            "1978.",
            "1977.",
            "1976.",
            "1975.",
            "1974.",
            "1973.",
            "1972.",
            "1971.",
            "1970.",
            "1969.",
            "1968.",
            "1967.",
            "1966.",
            "1965.",
            "1964.",
            "1963.",
            "1962.",
            "1961.",
            "1960.",
            "1959.",
            "1958.",
            "1957.",
            "1956.",
            "1955.",
            "1954.",
            "1953.",
            "1952.",
            "1951.",
            "1950.",
            "1949.",
            "1948.",
            "1947.",
            "1946.",
            "1945.",
            "1944.",
            "1943.",
            "1942.",
            "1941.",
            "1940.",
            "1939.",
            "1938.",
            "1937.",
            "1936.",
            "1935.",
            "1934.",
            "1933.",
            "1932.",
            "1931.",
            "1930.",
            "1929.",
            "1928.",
            "1927.",
            "1926.",
            "1925.",
            "1924.",
            "1923.",
            "1922.",
            "1921.",
            "1920.",
            "1919.",
            "1918.",
            "1917.",
            "1916.",
            "1915.",
            "1914.",
            "1913.",
            "1912.",
            "1911.",
            "1910.",
            "1909.",
            "1908.",
            "1907.",
            "1906.",
            "1905.",
            "1904.",
            "1903.",
            "1902.",
            "1901.",
            "1900."});
            this.yearComboBox.Location = new System.Drawing.Point(242, 127);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(60, 21);
            this.yearComboBox.TabIndex = 17;
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.dataPrivacyLabel);
            this.registrationGroupBox.Controls.Add(this.yearComboBox);
            this.registrationGroupBox.Controls.Add(this.monthComboBox);
            this.registrationGroupBox.Controls.Add(this.dayComboBox);
            this.registrationGroupBox.Controls.Add(this.genderComboBox);
            this.registrationGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrationGroupBox.Controls.Add(this.registryButton);
            this.registrationGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrationGroupBox.Controls.Add(this.placeOfBirthLabel);
            this.registrationGroupBox.Controls.Add(this.countryOfBirthLabel);
            this.registrationGroupBox.Controls.Add(this.birthdateLabel);
            this.registrationGroupBox.Controls.Add(this.countryOfBirthTextBox);
            this.registrationGroupBox.Controls.Add(this.genderLabel);
            this.registrationGroupBox.Controls.Add(this.firstNameLabel);
            this.registrationGroupBox.Controls.Add(this.placeOfBirthTextBox);
            this.registrationGroupBox.Controls.Add(this.lastNameLabel);
            this.registrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registrationGroupBox.ForeColor = System.Drawing.Color.SeaShell;
            this.registrationGroupBox.Location = new System.Drawing.Point(12, 315);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(330, 306);
            this.registrationGroupBox.TabIndex = 13;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration*";
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.editButton);
            this.listGroupBox.Controls.Add(this.removeButton);
            this.listGroupBox.Controls.Add(this.registeredUsersListView);
            this.listGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listGroupBox.ForeColor = System.Drawing.Color.SeaShell;
            this.listGroupBox.Location = new System.Drawing.Point(379, 122);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(646, 517);
            this.listGroupBox.TabIndex = 15;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "List of Registered Users:";
            // 
            // registeredUsersListView
            // 
            this.registeredUsersListView.AllowColumnReorder = true;
            this.registeredUsersListView.BackColor = System.Drawing.Color.SlateBlue;
            this.registeredUsersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registeredUsersListView.ForeColor = System.Drawing.Color.SeaShell;
            this.registeredUsersListView.FullRowSelect = true;
            this.registeredUsersListView.GridLines = true;
            this.registeredUsersListView.HideSelection = false;
            this.registeredUsersListView.Location = new System.Drawing.Point(38, 29);
            this.registeredUsersListView.Name = "registeredUsersListView";
            this.registeredUsersListView.Size = new System.Drawing.Size(575, 444);
            this.registeredUsersListView.TabIndex = 14;
            this.registeredUsersListView.UseCompatibleStateImageBehavior = false;
            this.registeredUsersListView.View = System.Windows.Forms.View.Details;
            this.registeredUsersListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.RegisteredUsersListView_ColumnClick);
            // 
            // canteredImagePictureBox
            // 
            this.canteredImagePictureBox.Image = global::PersonSorter.Properties.Resources.orange_people_connected;
            this.canteredImagePictureBox.Location = new System.Drawing.Point(12, 122);
            this.canteredImagePictureBox.Name = "canteredImagePictureBox";
            this.canteredImagePictureBox.Size = new System.Drawing.Size(330, 178);
            this.canteredImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canteredImagePictureBox.TabIndex = 21;
            this.canteredImagePictureBox.TabStop = false;
            // 
            // lowerDecorationPictureBox
            // 
            this.lowerDecorationPictureBox.Image = global::PersonSorter.Properties.Resources.orange_waves;
            this.lowerDecorationPictureBox.Location = new System.Drawing.Point(-2, 587);
            this.lowerDecorationPictureBox.Name = "lowerDecorationPictureBox";
            this.lowerDecorationPictureBox.Size = new System.Drawing.Size(1056, 75);
            this.lowerDecorationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerDecorationPictureBox.TabIndex = 17;
            this.lowerDecorationPictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PersonSorter.Properties.Resources.orange_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 18);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(115, 104);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 18;
            this.logoPictureBox.TabStop = false;
            // 
            // upperDecorationPictureBox
            // 
            this.upperDecorationPictureBox.Image = global::PersonSorter.Properties.Resources.orange_waves_upside_down;
            this.upperDecorationPictureBox.Location = new System.Drawing.Point(-1, -1);
            this.upperDecorationPictureBox.Name = "upperDecorationPictureBox";
            this.upperDecorationPictureBox.Size = new System.Drawing.Size(1055, 13);
            this.upperDecorationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperDecorationPictureBox.TabIndex = 22;
            this.upperDecorationPictureBox.TabStop = false;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1054, 662);
            this.Controls.Add(this.quoteLabel);
            this.Controls.Add(this.upperDecorationPictureBox);
            this.Controls.Add(this.canteredImagePictureBox);
            this.Controls.Add(this.mottoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.lowerDecorationPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MeetIng.";
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canteredImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerDecorationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDecorationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button registryButton;
        private Button removeButton;
        private Button editButton;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label genderLabel;
        private Label birthdateLabel;
        private Label countryOfBirthLabel;
        private Label placeOfBirthLabel;
        private Label logoLabel;
        private Label mottoLabel;
        private Label dataPrivacyLabel;
        private Label quoteLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox countryOfBirthTextBox;
        private TextBox placeOfBirthTextBox;
        private ComboBox genderComboBox;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private PictureBox canteredImagePictureBox;
        private PictureBox lowerDecorationPictureBox;
        private PictureBox logoPictureBox;
        private PictureBox upperDecorationPictureBox;
        private GroupBox registrationGroupBox;
        private GroupBox listGroupBox;
        private ListView registeredUsersListView;
    }
}
