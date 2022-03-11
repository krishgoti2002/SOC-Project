using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientCandidate.WebForms
{
    public partial class UpdateCandidate : System.Web.UI.Page
    {
        private DummyService.ICandidateService service;
        private int _id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["id"] == null && Session["name"] == null)
                Response.Redirect("~/Webforms/LoginCandidate.aspx");

            service = (DummyService.ICandidateService)Session["service"];
            _id = int.Parse(Session["id"].ToString());
            DummyService.Candidate candidate = service.GetCandidate(_id);
            if (!IsPostBack)
            {
                textbox_name.Text = candidate.Name;
                textbox_email.Text = candidate.Email;
                textbox_collage_name.Text = candidate.CollageName;
                textbox_dob.Text = candidate.DateOfBirth.ToString();
                radio_button_gender.SelectedIndex = ("male".Equals(candidate.Gender)) ? 0 : 1 ;
                
                textbox_mobile.Text = candidate.Mobile;
                textbox_password.Text = candidate.Password;
                string[] skills = candidate.Skills;
                string[] locations = candidate.PreferedJobLocations;
                string[] experience = candidate.JobExperiences;

                listbox_skills.Items.Clear();
                listbox_prefered_location.Items.Clear();
                listbox_experience.Items.Clear();

                foreach (string s in skills)
                    listbox_skills.Items.Add(s);
                foreach (string s in locations)
                    listbox_prefered_location.Items.Add(s);
                foreach (string s in experience)
                    listbox_experience.Items.Add(s);
            }
        }

        protected void button_add_skills_Click(object sender, EventArgs e)
        {
            if ("".Equals(textbox_skills.Text.ToString()))
                return;
            listbox_skills.Items.Add(textbox_skills.Text.ToString());
            textbox_skills.Text = "";
        }

        protected void button_add_prefered_location_Click(object sender, EventArgs e)
        {
            if ("".Equals(textbox_prefered_location.Text.ToString()))
                return;
            listbox_prefered_location.Items.Add(textbox_prefered_location.Text.ToString());
            textbox_prefered_location.Text = "";
        }

        protected void button_add_experience_Click(object sender, EventArgs e)
        {
            if ("".Equals(textbox_experience.Text.ToString()))
                return;
            listbox_experience.Items.Add(textbox_experience.Text.ToString());
            textbox_experience.Text = "";
        }

        protected void button_update_Click(object sender, EventArgs e)
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
                Id = _id,
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
            service.UpdateCandidate(candidate);
            label_update.Text = _id.ToString() + " " + textbox_name.Text + " " + service.GetCandidate(_id).Gender;

            textbox_name.ReadOnly = true;
            textbox_email.ReadOnly = true;
            textbox_password.ReadOnly = true;
            textbox_mobile.ReadOnly = true;
            textbox_collage_name.ReadOnly = true;
            radio_button_gender.Enabled = false;
            textbox_dob.ReadOnly = true;
            textbox_skills.ReadOnly = true;
            textbox_prefered_location.ReadOnly = true;
            textbox_experience.ReadOnly = true;

            button_add_skills.Enabled = false;
            button_add_prefered_location.Enabled = false;
            button_add_experience.Enabled = false;
        }

        protected void button_clear_skills_Click(object sender, EventArgs e)
        {
            if(listbox_skills.SelectedItem != null)
                listbox_skills.Items.Remove(listbox_skills.SelectedItem);
        }

        protected void button_clear_location_Click(object sender, EventArgs e)
        {
            if(listbox_prefered_location.SelectedItem != null)
                listbox_prefered_location.Items.Remove(listbox_prefered_location.SelectedItem);
        }

        protected void button_clear_experience_Click(object sender, EventArgs e)
        {
            if(listbox_experience.SelectedItem != null)
                listbox_experience.Items.Remove(listbox_experience.SelectedItem);
        }

        protected void button_edit_Click(object sender, EventArgs e)
        {
            textbox_name.ReadOnly = false;
            textbox_email.ReadOnly = false;
            textbox_password.ReadOnly = false;
            textbox_mobile.ReadOnly = false;
            textbox_collage_name.ReadOnly = false;
            radio_button_gender.Enabled = true;
            textbox_dob.ReadOnly = false;
            textbox_skills.ReadOnly = false;
            textbox_prefered_location.ReadOnly = false;
            textbox_experience.ReadOnly = false;

            button_add_skills.Enabled = true;
            button_add_prefered_location.Enabled = true;
            button_add_experience.Enabled = true;
            button_clear_skills.Enabled = true;
            button_clear_location.Enabled = true;
            button_clear_experience.Enabled = true;
        }
    }
}