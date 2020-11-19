using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab2_Stukalo
{
    class Sax : iStrategy
    {
        List<Wardrobe> iStrategy.Algorithm(Wardrobe wardrobe, string path)
        {
            List<Wardrobe> MyWardobe = new List<Wardrobe>();
            var xmlReader = new XmlTextReader(path);

            try
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.HasAttributes)
                    {
                        while (xmlReader.MoveToNextAttribute())
                        {
                            string Brand = "";
                            string Type = "";
                            string Fabric = "";
                            string Color = "";
                            string Season = "";

                            if (xmlReader.Name.Equals("Brand") && (xmlReader.Value.Equals(wardrobe.Brand) || wardrobe.Brand.Equals(String.Empty)))
                            {
                                Brand = xmlReader.Value;

                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("Type") && (xmlReader.Value.Equals(wardrobe.Type) || wardrobe.Type.Equals(String.Empty)))
                                {
                                    Type = xmlReader.Value;

                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("Fabric") && (xmlReader.Value.Equals(wardrobe.Fabric) || wardrobe.Fabric.Equals(String.Empty)))
                                    {
                                        Fabric = xmlReader.Value;

                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("Color") && (xmlReader.Value.Equals(wardrobe.Color) || wardrobe.Color.Equals(String.Empty)))
                                        {
                                            Color = xmlReader.Value;

                                            xmlReader.MoveToNextAttribute();

                                            if (xmlReader.Name.Equals("Season") && (xmlReader.Value.Equals(wardrobe.Season) || wardrobe.Season.Equals(String.Empty)))
                                            {
                                                Season = xmlReader.Value;

                                                xmlReader.MoveToNextAttribute();


                                            }
                                        }
                                    }

                                }
                            }

                            if (Brand != "" && Type != "" && Fabric != "" && Color != "" && Season != "")
                            {
                                Wardrobe myWardrobe = new Wardrobe();
                                myWardrobe.Brand = Brand;
                                myWardrobe.Type = Type;
                                myWardrobe.Fabric = Fabric;
                                myWardrobe.Color = Color;
                                myWardrobe.Season = Season;

                                MyWardobe.Add(myWardrobe);
                            }
                        }

                    }
                }
            }

            catch (SystemException ex)
            {
                string message = "File error!";
                MessageBox.Show(message);
            }

            xmlReader.Close();
            return MyWardobe;
        }

    }
}
            
        
    
