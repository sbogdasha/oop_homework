using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab2_Stukalo
{
    class Dom : iStrategy
    {

        private string GetFilterString(Wardrobe wardrobe)
        {
            string filter = "//Wardrobe";
            bool f1 = false;

            if (wardrobe.Brand != "" || wardrobe.Type != "" || wardrobe.Fabric != "" || wardrobe.Color != "" || wardrobe.Season != "")
            {
                filter += "[";



                if (wardrobe.Brand != "")
                {
                    filter += @"@Brand=""" + wardrobe.Brand + @"""";
                    f1 = true;
                }
                if ((f1) && (wardrobe.Type != "" || wardrobe.Fabric != "" || wardrobe.Color != "" || wardrobe.Season != ""))
                {
                    filter += " and ";
                    f1 = false;
                }
                if(wardrobe.Fabric != "")
                {
                    filter += @"@Fabric=""" + wardrobe.Fabric + @"""";
                    f1 = true;
                }

                if ((f1) && (wardrobe.Type != "" || wardrobe.Color != "" || wardrobe.Season != ""))
                {
                    filter += " and ";
                    f1 = false;
                }
                if (wardrobe.Type != "")
                {
                    filter += @"@Type=""" + wardrobe.Type + @"""";
                    f1 = true;
                }

                if ((f1) && (wardrobe.Color != "" || wardrobe.Season != ""))
                {
                    filter += " and ";
                    f1 = false;
                }
                if(wardrobe.Color != "")
                {
                    filter += @"@Color=""" + wardrobe.Color + @"""";
                    f1 = true;
                }

                if ((f1) && wardrobe.Season != "")
                {
                    filter += " and ";
                    f1 = false;
                }
                if (wardrobe.Season != "")
                {
                    filter += @"@Season=""" + wardrobe.Season + @"""";
                }
                filter += "]";
            }

            return filter;
        }




        List<Wardrobe> iStrategy.Algorithm(Wardrobe wardrobe, string path)
        {
            List<Wardrobe> MyWardobe = new List<Wardrobe>();
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(path);
                string filter = GetFilterString(wardrobe);

                XmlNodeList nodes = document.SelectNodes(filter);

                foreach (XmlNode n in nodes)
                {
                    Wardrobe wr = new Wardrobe();

                    wr.Brand = n.Attributes.GetNamedItem("Brand").InnerText;
                    wr.Type = n.Attributes.GetNamedItem("Type").InnerText;
                    wr.Fabric = n.Attributes.GetNamedItem("Fabric").InnerText;
                    wr.Color = n.Attributes.GetNamedItem("Color").InnerText;
                    wr.Season = n.Attributes.GetNamedItem("Season").InnerText;

                    MyWardobe.Add(wr);
                }
            }

            catch (SystemException)
            {
                string message = "File error!";
                MessageBox.Show(message);
            }

            return MyWardobe;
        }
    }

}
