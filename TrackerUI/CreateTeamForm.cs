using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = new List<PersonModel>(GlobalConfig.Connection.GetPerson_All());
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
         
        public CreateTeamForm()
        {
            InitializeComponent();
           // CreateSeedData();
            WireUpLists();
        }

        private void CreateSeedData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Alex", LastName = "Coupe" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Tony", LastName = "Stark" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Bruce", LastName = "Banner" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Thor", LastName = "Odinson" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.MobileNumber = mobileValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                mobileValue.Text = "";


            }
            else
            {
                MessageBox.Show("Please Fill Out All Fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
                return false;

            if (lastNameValue.Text.Length == 0)
                return false;

            if (emailValue.Text.Length == 0)
                return false;

            if (mobileValue.Text.Length == 0)
                return false;

            return true;
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

        }
    }
}
