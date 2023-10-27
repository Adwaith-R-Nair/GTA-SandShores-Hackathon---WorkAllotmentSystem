using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkAllotmentSystem
{
    public partial class Form1 : Form
    {
        internal Manager tempmanager = new Manager();
       
        public Form1()
        {
            InitializeComponent();

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
             Work enteredWork = new Work();
             Employee employee = new Employee();
        employee.employeeName = workname.Text;

            foreach (var i in Skills.CheckedItems)
            {

                if (i.ToString() == "AIKnowledge")
                {
                    employee.skillset.Append(skills.AIExperience);
                }

                if (i.ToString() == "Leadership")
                {
                    employee.skillset.Append(skills.Leadership);
                }

                if (i.ToString() == "DatabaseKnowledge")
                {
                    employee.skillset.Append(skills.DatabaseKnowledge);
                }
                if (i.ToString() == "Communication")
                {
                    employee.skillset.Append(skills.Communication);
                }
                if (i.ToString() == "TimeManagement")
                {
                    employee.skillset.Append(skills.TimeManagement);
                }
            }
            tempmanager.employeeList.Append(employee);

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            tempmanager.scheduler();
        }

        private void button3_Click(object sender, EventArgs e)

        {
             Work enteredWork = new Work();
       Employee employee = new Employee();
        enteredWork.WorkName = workname.Text;

            foreach (var i in skillsRequired.Items)
            {
                if (i.ToString() == "AIKnowledge")
                {
                    enteredWork.requiredSkills.Append(skills.AIExperience);
                    continue;
                }

                if (i.ToString() == "Leadership")
                {
                    enteredWork.requiredSkills.Append(skills.Leadership);
                    continue;
                }

                if (i.ToString() == "DatabaseKnowledge")
                {
                    enteredWork.requiredSkills.Append(skills.DatabaseKnowledge);
                    continue;
                }
                if (i.ToString() == "Communication")
                {
                    enteredWork.requiredSkills.Append(skills.Communication);
                    continue;
                }
                if (i.ToString() == "TimeManagement")
                {
                    enteredWork.requiredSkills.Append(skills.TimeManagement);
                    continue;
                }
            }
            foreach (skills i in enteredWork.requiredSkills) {
                debug.Text = enteredWork.WorkName + i;
            }
        }
    }
}