﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySite
{
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddInfo_Load(object sender, EventArgs e)
        {

        }

        private void AddInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["ChooseAction"]; ;
            form1.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Department dep = null;
            Faculty fac = null;
            Speciality spec = null;
            Head head = null; 
            int year = 0;
            string address = "";
            string phone = "";
            string site = "";
            FormOfEducation edForm = FormOfEducation.intramuralForm;

            if (textBoxDep.Text.Length != 0)
                dep = new Department(GetInfo.DepMaxCode(), textBoxDep.Text);
            else if (textBoxFac.Text.Length != 0)
                fac = new Faculty(GetInfo.FacMaxCode(), textBoxFac.Text);
            else if (textBoxSpec.Text.Length != 0)
                spec = new Speciality(GetInfo.SpecMaxCode(), textBoxFac.Text);
            else if (textBoxYear.Text.Length != 0 && CheckingInfo.CheckCorectness(textBoxYear.Text))
                year = Int32.Parse(textBoxYear.Text);
            else if (textBoxName.Text.Length != 0 && textBoxRank.Text.Length != 0 && textBoxDegree.Text.Length != 0)
                head = new Head(year, textBoxName.Text, textBoxDegree.Text, textBoxRank.Text);
            else if (textBoxAddress.Text.Length != 0)
                address = textBoxAddress.Text;
            else if (textBoxPhone.Text.Length != 0)
                phone = textBoxPhone.Text;
            else if (textBoxSite.Text.Length != 0)
                site = textBoxSite.Text;

            if (RBExtramural.Checked)
                edForm = FormOfEducation.extramuralForm;
            if (RBPart.Checked)
                edForm = FormOfEducation.partTimeForm;

            AddingInformation.AddInfo(dep, spec, fac, head, address, phone, site, year, edForm);
        }
    }
}