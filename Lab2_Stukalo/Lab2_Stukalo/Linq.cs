using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2_Stukalo
{

     class Linq : iStrategy
    {

        List<Wardrobe> iStrategy.Algorithm(Wardrobe wardrobe, string path)
        {
            List<Wardrobe> MyWardobe = new List<Wardrobe>();
            var document = XDocument.Load(path);
            try
            {
                var result = from obj in document.Descendants("Wardrobe")
                             where
                             (
                             (obj.Attribute("Brand").Value.Equals(wardrobe.Brand) || wardrobe.Brand.Equals(String.Empty)) &&
                              (obj.Attribute("Type").Value.Equals(wardrobe.Type) || wardrobe.Type.Equals(String.Empty)) &&
                               (obj.Attribute("Fabric").Value.Equals(wardrobe.Fabric) || wardrobe.Fabric.Equals(String.Empty)) &&
                                (obj.Attribute("Color").Value.Equals(wardrobe.Color) || wardrobe.Color.Equals(String.Empty)) &&
                                 (obj.Attribute("Season").Value.Equals(wardrobe.Season) || wardrobe.Season.Equals(String.Empty))
                             )
                             select new
                             {
                                 Brand = (string)obj.Attribute("Brand").Value,
                                 Type = (string)obj.Attribute("Type").Value,
                                 Fabric = (string)obj.Attribute("Fabric").Value,
                                 Color = (string)obj.Attribute("Color").Value,
                                 Season = (string)obj.Attribute("Season").Value,

                             };
                foreach (var i in result)
                {
                    Wardrobe NewWardrobe = new Wardrobe();
                    NewWardrobe.Brand = i.Brand;
                    NewWardrobe.Type = i.Type;
                    NewWardrobe.Fabric = i.Fabric;
                    NewWardrobe.Color = i.Color;
                    NewWardrobe.Season = i.Season;

                    MyWardobe.Add(NewWardrobe);
                }

            }

            catch (SystemException ex)
            {
                string message = "File error!";
                MessageBox.Show(message);
            }

            return MyWardobe;
        }
    }

}
