using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2_Stukalo
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Bogdan\Desktop\Lab2_Stukalo\Lab2_Stukalo\WardrobeXML.xml";
        string pathxslt = @"C:\Users\Bogdan\Desktop\Lab2_Stukalo\Lab2_Stukalo\XSLTFile1.xslt";
        string pathHTML = (@"C:\Users\Bogdan\Desktop\Lab2_Stukalo\Lab2_Stukalo\FileWardrobe.html");
        string Err_msg = "File error!";
        string Err_msg2 = "Can not transform to HTML!";
        string transform = "Transformed to HTML!";
        List<Wardrobe> final = new List<Wardrobe>();
        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            FillBrandsComboBox();
            FillTypesComboBox();
            FillFabricsComboBox();
            FillColorsComboBox();
            FillSeasonsComboBox();
        }

       private void FillBrandsComboBox()
        {
            try
            {
                var document = XDocument.Load(path);
            
                var Brands = (from obj in document.Descendants("Wardrobe")
                              select new
                              {
                                  Brand = (string)obj.Attribute("Brand").Value
                              }).Distinct().ToList();

                foreach (var a in Brands)
                {
                    cBoxBrand.Items.Add(a.Brand);
                }
                cBoxBrand.SelectedIndex = 0;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg);
            }

        }



        private void FillTypesComboBox()
        {
            try
            {
                var document = XDocument.Load(path);
            
                var Types = (from obj in document.Descendants("Wardrobe")
                             select new
                             {
                                 Type = (string)obj.Attribute("Type").Value
                             }).Distinct().ToList();

                foreach (var a in Types)
                {
                    cBoxType.Items.Add(a.Type);
                }
                cBoxType.SelectedIndex = 0;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg);
            }
        }


        private void FillFabricsComboBox()
        {
            try
            {
                var document = XDocument.Load(path);
            
                var Fabrics = (from obj in document.Descendants("Wardrobe")
                               select new
                               {
                                   Fabric = (string)obj.Attribute("Fabric").Value
                               }).Distinct().ToList();

                foreach (var a in Fabrics)
                {
                    cBoxFabric.Items.Add(a.Fabric);
                }
                cBoxFabric.SelectedIndex = 0;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg);
            }
        }



        private void FillColorsComboBox()
        {
            try
            {
                var document = XDocument.Load(path);
          
                var Colors = (from obj in document.Descendants("Wardrobe")
                              select new
                              {
                                  Color = (string)obj.Attribute("Color").Value
                              }).Distinct().ToList();

                foreach (var a in Colors)
                {
                    cBoxColor.Items.Add(a.Color);
                }
                cBoxColor.SelectedIndex = 0;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg);
            }
        }


        private void FillSeasonsComboBox()
        {
            try
            {
                var document = XDocument.Load(path);
         
                var Seasons = (from obj in document.Descendants("Wardrobe")
                               select new
                               {
                                   Season = (string)obj.Attribute("Season").Value
                               }).Distinct().ToList();

                foreach (var a in Seasons)
                {
                    cBoxSeason.Items.Add(a.Season);
                }
                cBoxSeason.SelectedIndex = 0;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg);
            }
        }


        private void PrintWardrobeList(List<Wardrobe> war)
        {
            richTextBox1.Clear();
            string text = "";
            foreach(var t in war)
            {
                text += t.Brand;
                text += "\n";
                text += "\t" + t.Type;
                text += "\n";
                text += "\t" + t.Fabric;
                text += "\n";
                text += "\t" + t.Color;
                text += "\n";
                text += "\t" + t.Season;
                text += "\n";
                text += "\n";
            }
            richTextBox1.Text = text;
        }

        private void SearchWardrobe()
        {
            iStrategy clothing;
            Wardrobe war = new Wardrobe();
            List<Wardrobe> wr = new List<Wardrobe>();

            if (checkBoxBrand.Checked)
            {
                war.Brand = cBoxBrand.Text;
            }

            if (checkBoxType.Checked)
            {
                war.Type = cBoxType.Text;
            }

            if (checkBoxFabric.Checked)
            {
                war.Fabric = cBoxFabric.Text;
            }

            if (checkBoxColor.Checked)
            {
                war.Color = cBoxColor.Text;
            }

            if (checkBoxSeason.Checked)
            {
                war.Season = cBoxSeason.Text;
            }

            if (radioButtonDom.Checked)
            {
                clothing = new Dom();
                wr = clothing.Algorithm(war,path);
            }

            else
            {
                if (radioButtonSax.Checked)
                {
                    clothing = new Sax();
                    wr = clothing.Algorithm(war, path);
                }
                else if(radioButtonLinq.Checked) 
                {
                    clothing = new Linq();
                    wr = clothing.Algorithm(war, path);
                }
            }

            PrintWardrobeList(wr);

        }


        private bool Transform()
        {
            bool flag = false;
            try
            {
                XslCompiledTransform xsl = new XslCompiledTransform();
                xsl.Load(pathxslt);
                xsl.Transform(path, pathHTML);
                flag = true;
            }
            catch (SystemException ex1)
            {
                MessageBox.Show(Err_msg2);
            }
            return flag;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Transform())
            {
                MessageBox.Show(transform);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchWardrobe();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

