using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class RegisterCandidate : System.Web.UI.Page
    {
        private DummyService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (DummyService.ICandidateService)Session["service"];
        }

        protected void button_add_skills_Click(object sender, EventArgs e)
        {
            listbox_skills.Items.Add(textbox_skills.Text.ToString());
            textbox_skills.Text = "";
        }

        protected void button_add_prefered_location_Click(object sender, EventArgs e)
        {
            listbox_prefered_location.Items.Add(textbox_prefered_location.Text.ToString());
            textbox_prefered_location.Text = "";
        }

        protected void button_add_experience_Click(object sender, EventArgs e)
        {
            listbox_experience.Items.Add(textbox_experience.Text.ToString());
            textbox_experience.Text = "";
        }

        protected void button_register_Click(object sender, EventArgs e)
        {
            string[] skills = new string[listbox_skills.Items.Count];
            int i = 0;
            foreach (var item in listbox_skills.Items)
                skills[i++] = item.ToString();

            string[] locations = new string[listbox_prefered_location.Items.Count];
            i = 0;
            foreach (var item in listbox_prefered_location.Items)
                locations[i++] = item.ToString();

            string[] experience = new string[listbox_experience.Items.Count];
            i = 0;
            foreach (var item in listbox_experience.Items)
                experience[i] = item.ToString();

            DummyService.Candidate candidate = new DummyService.Candidate
            {
                Name = textbox_name.Text,
                Email = textbox_email.Text,
                CollageName = textbox_collage_name.Text,
                DateOfBirth = DateTime.Parse(textbox_dob.Text),
                Gender = radio_button_gender.SelectedValue,
                Mobile = textbox_mobile.Text,
                Password = textbox_password.Text,
                Skills = skills,
                PreferedJobLocations = locations,
                JobExperiences = experience
            };
            service.AddCandidate(candidate);
            label_register.Text = "Done";
        }

        protected void button_clear_skills_Click(object sender, EventArgs e)
        {
            listbox_skills.Items.Clear();
        }

        protected void button_clear_location_Click(object sender, EventArgs e)
        {
            listbox_prefered_location.Items.Clear();
        }

        protected void button_clear_experience_Click(object sender, EventArgs e)
        {
            listbox_experience.Items.Clear();
        }
    }
}