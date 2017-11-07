using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml;

namespace ReadWriteXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet DS;
        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            EditXmlFile edit = new EditXmlFile(txtXMLFilePath.Text);
            //DialogResult result = edit.ShowDialog();

        }

        private void btnReadXML_Click(object sender, EventArgs e)
        {
            try
            {
                //Initialize new Dataset
                DS = new DataSet();

                //Read XML data from file
                DS.ReadXml(txtXMLFilePath.Text);

                //Fill grid with XML data
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Refresh();

                MessageBox.Show("XML data read successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            try
            {
                //Write dataset to XML file
                DS.WriteXml(txtXMLFilePath.Text);
                MessageBox.Show("XML data saved successfully to " + txtXMLFilePath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            //Clear Grid
            dataGridView1.DataSource = null;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DS.ReadXml(txtXMLFilePath.Text);
            string s1 = searchbox.Text;
            XmlReader reader= XmlReader.Create(@""+txtXMLFilePath.Text);
            int present = 0;
            while (reader.Read()) {
                if (reader.IsStartElement())
                {
                    if (reader.Name.ToString() == s1)
                    {
                        present = 1;
                        MessageBox.Show("" + s1 + " is present as a tag in XML file");
                        //MessageBox.Show("" + s1 + " is present as a tag in XML file");
                    }
                }
            }
            if (present == 0) {
                MessageBox.Show("No such tag in XML file");
            }
        }
    }
}
