using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;


namespace ReadWriteXML
{
    public partial class EditXmlFile : Form
    {
        int cLeft = 1;
        int var = 1;
        string url;
        
        public EditXmlFile(string s)
        {
            int flag = 0;
            url = s;
            try
            {
                DataSet DS = new DataSet();
                string pat = @"^.*\.xml$";
                Regex r = new Regex(pat, RegexOptions.IgnoreCase);
                Match m = r.Match(url);
                if (m.Success)
                {
                    DS.WriteXml(url);
                    MessageBox.Show("Ready to create tags");
                }
                else
                {
                    MessageBox.Show("Incorrect File extension");
                    flag = 1;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
                flag = 1;
            }
            if (flag == 0)
            {
                InitializeComponent();
                button2.Enabled = false;
                button3.Enabled = false;
                DialogResult result = this.ShowDialog();
                
            }
            else {
                this.Close();
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
                {
                    AddNewTextBox();
                }
                button1.Enabled = false;
                textBox1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        
        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = cLeft + 80;
            txt.Left = 200;
            txt.Text = "TextBox" + var.ToString();

            cLeft = cLeft + 30;
            var += 1;
            return txt;
        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            button2.Enabled = false;
            this.Controls.Clear();
            this.InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            cLeft = 1;
            var = 1;
        }

        
        DataSet DS;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ss=new string[Convert.ToInt32(textBox1.Text)+1];
                DataTable DT = new DataTable();
                int i=0;
                foreach (Control ctr in this.Controls) {
                    if (ctr.GetType() == typeof(TextBox))
                    {
                        ss[i] = ctr.Text;
                        i += 1;
                    }       
                }
                for (int j = 1; j < i; j++) {
                    DT.Columns.Add(ss[j]);
                }
                


                object[] obj1=new object[Convert.ToInt32(textBox1.Text)];
                for(int j=0;j<Convert.ToInt32(textBox1.Text);j++)
                {
                    obj1[j] = "1";
                }
 
                
                
                DT.Rows.Add(obj1);
                //Create a dataset
                DS = new DataSet();

                //Add datatable to this dataset
                DS.Tables.Add(DT);

                //Write dataset to XML file
                DS.WriteXml(url);
                MessageBox.Show("XML data written successfully to " + url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

   

       
    }
}
