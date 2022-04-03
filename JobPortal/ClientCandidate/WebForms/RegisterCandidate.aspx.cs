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
        private CandidateService.ICandidateService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = (CandidateService.ICandidateService)Session["service_1"];
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
            string skills = "";
            foreach (var item in listbox_skills.Items)
                skills += item.ToString() + ",";

            string locations = "";        
            foreach (var item in listbox_prefered_location.Items)
                locations += item.ToString() + ",";

            string experience = "";
            foreach (var item in listbox_experience.Items)
                experience += item.ToString() + ",";

            CandidateService.Candidate candidate = new CandidateService.Candidate
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
            Response.Redirect("~/Webforms/LoginCandidate.aspx");
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