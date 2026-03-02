using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Laboratory2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("No image selected.");
            }
        }

        private void Program_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ComboBox*/
            Program_comboBox.Items.Add("BS Computer Engineering");
            Program_comboBox.Items.Add("BS Electronics Engineering");
            Program_comboBox.Items.Add("BS Industrial Engineering");
            Program_comboBox.Items.Add("BS Mechanical Engineering");
        }

        private void NewCancel_button_Click(object sender, EventArgs e)
        {
            /*Textbox*/
            StudentName_textBox.Clear();
            StudentNumber_textBox.Clear();
            YearLevel_textBox.Clear();
            Scholar_textBox.Clear();
            CourseNumber_textBox.Clear();
            CourseCode_textBox.Clear();
            CourseDesc_textBox.Clear();
            UnitLecture_textBox.Clear();
            UnitLaboratory_textBox.Clear();
            Time_textBox.Clear();
            Day_textBox.Clear();
            CreditUnits_textBox.Clear();
            TotalNumberofUnits_textBox.Clear();
            LaboratoryFee_textBox.Clear();
            TotalTuitionFee_textBox.Clear();
            TotalMiscellanousFee_textBox.Clear();
            CiscoLabFee_textBox.Clear();
            ExamBookletFee_textBox.Clear();
            TotalTuitionandFee_textBox.Clear();
            TotalTuitionFee_textBox2.Clear();
            TotalMiscellanousFee_textBox2.Clear();
            TotalNumberofUnits_textBox2.Clear();
            TotalTuitionandFee_textBox2.Clear();
            ComputerLaboratoryFee_textBox.Clear();
            CISCOLabFee_textBox2.Clear();
            ExamBooklet_textBox.Clear();
            TotalOtherSchoolFees_textBox.Clear();

            Program_comboBox.SelectedIndex = -1;
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            // Add data from TextBoxes to ListBoxes
            listBox1.Items.Add(CourseCode_textBox.Text);
            listBox2.Items.Add(CourseDesc_textBox.Text);
            listBox3.Items.Add(UnitLecture_textBox.Text);
            listBox4.Items.Add(UnitLaboratory_textBox.Text);
            listBox5.Items.Add(CreditUnits_textBox.Text);
            listBox6.Items.Add(Time_textBox.Text);
            listBox7.Items.Add(Day_textBox.Text);
            // You mentioned listBox8, add it here if you have an 8th TextBox
            // listBox8.Items.Add(Your8thTextBox.Text);

            // Clear the TextBoxes
            CourseCode_textBox.Clear();
            CourseDesc_textBox.Clear();
            UnitLecture_textBox.Clear();
            UnitLaboratory_textBox.Clear();
            CreditUnits_textBox.Clear();
            Time_textBox.Clear();
            Day_textBox.Clear();

            // Set focus back to the start
            CourseCode_textBox.Focus();

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TotalOtherSchoolFees_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExamBooklet_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void CISCOLabFee_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void ComputerLaboratoryFee_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void TotalTuitionandFee_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void TotalNumberofUnits_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void TotalMiscellanousFee_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTuitionFee_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
