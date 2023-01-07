using Microsoft.VisualBasic;
using System.IO;

namespace Harjoitus19_NiklasVuorio
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// List of profiles
        /// </summary>
        List<Profile> profiles = new List<Profile>();

        /// <summary>
        /// stores currently active profile
        /// </summary>
        Profile active_profile = new Profile();

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        /// <summary>
        /// Load profiles and contacts within them from a file
        /// </summary>
        private void loadData()
        {
            foreach (string file in Directory.GetFiles(@"./profiles/", "*", SearchOption.AllDirectories))
            {
                Profile p = new Profile();
                p.createProfile(file.Substring(file.LastIndexOf("/") + 1, file.LastIndexOf(".") - file.LastIndexOf("/") - 1));
                profiles.Add(p);
            }
            profileCB.Items.Clear();
            foreach (Profile pro in profiles)
            {
                profileCB.Items.Add(pro.getName());
                foreach (string line in File.ReadLines(@"./profiles/" + pro.getName() + ".txt"))
                {
                    if (line == null) continue;
                    var text = line.Split('\"', StringSplitOptions.RemoveEmptyEntries);
                    Contact c = new Contact();
                    c.createContact(text[0], text[1], text[2], text[3], text[4]);
                    pro.addToList(c);
                }
                //using (StreamReader sr = File.OpenText(@"./profiles/" + pro.getName() + ".txt"))
                //{
                //    //string line = sr.ReadLine();
                //}
            }
        }

        /// <summary>
        /// Show the form to add contacts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBT_Click(object sender, EventArgs e)
        {
            if (profileCB.Items.Count == 0 || profileCB.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select/create a profile first.");
                return;
            }

            infoPanel.Visible = false;
            newConPanel.Visible = true;
            applyBT.Visible = false;
            addConBT.Visible = true;
        }

        /// <summary>
        /// Add profile and let the user name it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProfileBT_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();

            //Get profile name from user input
            string name = Interaction.InputBox("Profile name?", "create new profile");

            //Return if user does not give a name for the profile
            if (name == "") return;

            //give profile the name and update the profile combobox
            p.createProfile(name);
            profiles.Add(p);
            profileCB.Items.Clear();
            foreach (Profile pro in profiles)
            {
                profileCB.Items.Add(pro.getName());
            }

            profileCB.SelectedIndex = profileCB.Items.Count - 1;
        }

        /// <summary>
        /// changes the active profile and updates the contact list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            active_profile = profiles[profileCB.SelectedIndex];

            updateContacts();
        }

        /// <summary>
        /// Used to update the contact list
        /// </summary>
        private void updateContacts()
        {
            contactsLB.Items.Clear();
            foreach (Contact con in active_profile.getConList())
            {
                contactsLB.Items.Add(con.getFullname());
            }
            active_profile.saveProfile();
        }

        /// <summary>
        /// cretes a new contact and updates the contact list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addConBT_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.createContact(firstnameTB.Text, lastnameTB.Text, phoneTB.Text, emailTB.Text, addressTB.Text);

            firstnameTB.Text = "";
            lastnameTB.Text = "";
            phoneTB.Text = "";
            emailTB.Text = "";
            addressTB.Text = "";

            infoPanel.Visible = true;
            newConPanel.Visible = false;

            active_profile.addToList(c);

            updateContacts();
        }

        /// <summary>
        /// cancels adding a new contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBT_Click(object sender, EventArgs e)
        {
            firstnameTB.Text = "";
            lastnameTB.Text = "";
            phoneTB.Text = "";
            emailTB.Text = "";
            addressTB.Text = "";

            infoPanel.Visible = true;
            newConPanel.Visible = false;
            contactsLB.Enabled = true;
        }

        /// <summary>
        /// Shows and changes information when selecting a contact from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstnameLB.Visible = true;
            lastnameLB.Visible = true;
            phoneLB.Visible = true;
            emailLB.Visible = true;
            addressLB.Visible = true;

            if(contactsLB.SelectedIndex == -1) return;

            firstnameLB.Text = active_profile.getConList()[contactsLB.SelectedIndex].Firstname;
            lastnameLB.Text = active_profile.getConList()[contactsLB.SelectedIndex].Lastname;
            phoneLB.Text = active_profile.getConList()[contactsLB.SelectedIndex].Phonenumber;
            emailLB.Text = active_profile.getConList()[contactsLB.SelectedIndex].Email;
            addressLB.Text = active_profile.getConList()[contactsLB.SelectedIndex].Address;
        }

        /// <summary>
        /// Removes the selected contact from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeBT_Click(object sender, EventArgs e)
        {
            if (contactsLB.SelectedIndex == -1)
            {
                MessageBox.Show("No contact selected");
                return;
            }

            active_profile.getConList().RemoveAt(contactsLB.SelectedIndex);
            updateContacts();
        }

        private void editBT_Click(object sender, EventArgs e)
        {
            if(contactsLB.SelectedIndex == -1)
            {
                MessageBox.Show("No contact selected");
                return;
            }

            //TODO get the current profile that is selected and save the changes the user made to it

            Contact con_to_edit = active_profile.getConList()[contactsLB.SelectedIndex];

            firstnameTB.Text = con_to_edit.Firstname;
            lastnameTB.Text = con_to_edit.Lastname;
            phoneTB.Text = con_to_edit.Phonenumber;
            emailTB.Text = con_to_edit.Email;
            addressTB.Text = con_to_edit.Address;

            infoPanel.Visible = false;
            addConBT.Visible = false;
            newConPanel.Visible = true;
            applyBT.Visible = true;
            contactsLB.Enabled = false;
        }

        private void applyBT_Click(object sender, EventArgs e)
        {
            Contact con_to_edit = active_profile.getConList()[contactsLB.SelectedIndex];

            con_to_edit.createContact(firstnameTB.Text, lastnameTB.Text, phoneTB.Text, emailTB.Text, addressTB.Text);

            infoPanel.Visible = true;
            newConPanel.Visible = false;
            contactsLB.Enabled = true;

            updateContacts();
        }
    }

    /// <summary>
    /// Profile which stores a list of contacts
    /// </summary>
    public partial class Profile
    {
        private string profile_dir = @"./profiles/";
        private string profile_name = "";
        private string file_path = @"";
        private List<Contact> contact_list = new List<Contact>();

        /// <summary>
        /// Used to give a name to a new profile
        /// </summary>
        /// <param name="name">name of the profile</param>
        public void createProfile(string name)
        {
            this.profile_name = name;
            this.file_path = profile_dir + profile_name + ".txt";
        }

        public List<Contact> getConList()
        {
            return contact_list;
        }

        /// <summary>
        /// add contact to the list of contacts
        /// </summary>
        /// <param name="c">contact that is added to the list</param>
        public void addToList(Contact c)
        {
            contact_list.Add(c);
        }

        /// <summary>
        /// get the name of the profile used for displaying profile name
        /// </summary>
        /// <returns>profile name as a string</returns>
        public string getName()
        {
            return profile_name;
        }

        public void saveProfile()
        {
            if(!Directory.Exists(profile_dir))
            {
                Directory.CreateDirectory(profile_dir);
            }

            using (StreamWriter sw = File.CreateText(file_path))
            {
                foreach(Contact con in contact_list)
                {
                    sw.WriteLine("\"" + con.Firstname + "\"" +
                        "\"" + con.Lastname + "\"" +
                        "\"" + con.Phonenumber + "\"" +
                        "\"" + con.Email + "\"" +
                        "\"" + con.Address + "\"");
                }
            }
        }
    }

    /// <summary>
    /// Class for contacts that are saved as objects
    /// </summary>
    public partial class Contact
    {
        private string firstname, lastname, phonenumber, email, address;

        /// <summary>
        /// Create a contact
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="phonenumber"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        public void createContact(string firstname, string lastname, string phonenumber, string email, string address)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.address = address;

            if (this.firstname == "") this.firstname = "-";
            if (this.lastname == "") this.lastname = "-";
            if (this.phonenumber == "") this.phonenumber = "-";
            if (this.email == "") this.email = "-";
            if (this.address == "") this.address = "-";
        }

        /// <summary>
        /// gets the fullname of the contact
        /// </summary>
        /// <returns>firstname and lastname as a string</returns>
        public string getFullname()
        {
            return this.firstname + " " + this.lastname;
        }

        public string Firstname
        {
            get { return this.firstname; }
        }
        public string Lastname
        {
            get { return this.lastname; }
        }
        public string Phonenumber
        {
            get { return this.phonenumber; }
        }
        public string Email
        {
            get { return this.email; }
        }
        public string Address
        {
            get { return this.address; }
        }
    }
}