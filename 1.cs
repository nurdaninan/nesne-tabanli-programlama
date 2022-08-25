using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    yeniEntities newDB = new yeniEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        //  veri ekleme
        Veriler ekleme = new Veriler();
        ekleme.l = "Nurdan";
        ekleme.n = "İnan";
        newDB.Veriler.Add(ekleme);
        newDB.SaveChanges();
        //cekme
        /

        string name = "", location = "";
        using (XmlReader reader = XmlReader.Create(@"C:\Users\Nurdan.inan\Documents\products.xml"))
        {
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    return only when you have START tag
                    switch (reader.Name.ToString())
                    {
                        case "Name":
                            name = reader.ReadString();
                            Label2.Text += "Your Name is:" + name;
                            break;
                        case "Location":
                            location = reader.ReadString();
                            Label2.Text += "Your Location is:" + location;
                            break;
                    }
                }

                {

                }
            }

        }


        while (true)
        {
            string xmldengelenveri = "asdasd";
            yoksaKaydet(xmldengelenveri);
        }






    }


    void veriKaydet(string ilkVeri = "", string ikinciVeri = "")
    {
        Veriler ekleme = new Veriler();
        ekleme.n = ilkVeri;
        ekleme.l = ikinciVeri;
        newDB.Veriler.Add(ekleme);
        newDB.SaveChanges();
    }

    void yoksaKaydet(string xmldenGelen = "", string ikinciVeri = "")
    {
        //string xmldenGelen = "yeniVeri";

        var gelenVeriler = newDB.Veriler.SqlQuery("SELECT * FROM Veriler WHERE n LIKE '%" + xmldenGelen + "%'").ToList();
        if (gelenVeriler.Count == 0)
        {
            veriKaydet(xmldenGelen, ikinciVeri);
            Label1.Text = "Kaydedildi";

        }
        else
        {
            Label1.Text = "Daha Önceden Kaydedilmiş";
        }
    }
