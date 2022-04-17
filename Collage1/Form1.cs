using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Collage1
{
    public partial class Form1 : Form
    {
        public Form1()
        
        {

            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMANT' table. You can move, or remove it, as needed.
            this.dEPARTMANTTableAdapter.Fill(this.dataSet1.DEPARTMANT);
            // TODO: This line of code loads data into the 'dataSet1.COURSE' table. You can move, or remove it, as needed.
            this.cOURSETableAdapter.Fill(this.dataSet1.COURSE);
            // TODO: This line of code loads data into the 'dataSet1.PROFF' table. You can move, or remove it, as needed.
            this.pROFFTableAdapter.Fill(this.dataSet1.PROFF);
            // TODO: This line of code loads data into the 'dataSet1.ENROLL' table. You can move, or remove it, as needed.
            this.eNROLLTableAdapter.Fill(this.dataSet1.ENROLL);
            // TODO: This line of code loads data into the 'dataSet1.CLASS_1' table. You can move, or remove it, as needed.
            this.cLASS_1TableAdapter.Fill(this.dataSet1.CLASS_1);
            // TODO: This line of code loads data into the 'dataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dataSet1.STUDENT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            this.sTUDENTTableAdapter.Fill(this.dataSet1.STUDENT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sTUDENTTableAdapter.DeleteQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            this.sTUDENTTableAdapter.Fill(this.dataSet1.STUDENT);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.eNROLLTableAdapter.InsertQuery(textBox5.Text, textBox6.Text, textBox7.Text);
            this.eNROLLTableAdapter.Fill(this.dataSet1.ENROLL);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.eNROLLTableAdapter.DeleteQuery(textBox5.Text, textBox6.Text, textBox7.Text);
            this.eNROLLTableAdapter.Fill(this.dataSet1.ENROLL);
        }


        private void button5_Click(object sender, EventArgs e)
        {

            this.cLASS_1TableAdapter.InsertQuery(textBox8.Text, textBox9.Text, textBox10.Text);
            this.cLASS_1TableAdapter.Fill(this.dataSet1.CLASS_1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.cLASS_1TableAdapter.DeleteQuery(textBox8.Text, textBox9.Text, textBox10.Text);
            this.cLASS_1TableAdapter.Fill(this.dataSet1.CLASS_1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.pROFFTableAdapter.InsertQuery(textBox11.Text, textBox12.Text, textBox13.Text);
            this.pROFFTableAdapter.Fill(this.dataSet1.PROFF);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.pROFFTableAdapter.DeleteQuery(textBox11.Text, textBox12.Text, textBox13.Text);
            this.pROFFTableAdapter.Fill(this.dataSet1.PROFF);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.cOURSETableAdapter.InsertQuery(textBox14.Text, textBox15.Text, textBox16.Text, textBox22.Text);
            this.cOURSETableAdapter.Fill(this.dataSet1.COURSE);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.cOURSETableAdapter.DeleteQuery(textBox14.Text, textBox15.Text, textBox16.Text, textBox22.Text);
            this.cOURSETableAdapter.Fill(this.dataSet1.COURSE);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.dEPARTMANTTableAdapter.InsertQuery(textBox17.Text, textBox18.Text, textBox19.Text);
            this.dEPARTMANTTableAdapter.Fill(this.dataSet1.DEPARTMANT);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.dEPARTMANTTableAdapter.DeleteQuery(textBox17.Text, textBox18.Text, textBox19.Text);
            this.dEPARTMANTTableAdapter.Fill(this.dataSet1.DEPARTMANT);
        }

        
    }
}
