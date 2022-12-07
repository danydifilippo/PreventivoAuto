using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PreventivoAuto
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Configurazione.Visible= false;
        }

        protected void DropDownAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AutoScelta = DropDownAuto.SelectedItem.Text;
            Double Prezzo = Convert.ToDouble(DropDownAuto.SelectedItem.Value);

            if (AutoScelta == "Fiat 500 ELETTRICA 70 KW (95CV)")
            {
                Image1.ImageUrl = "/img/fiat500.png";
                lblDescrAuto.Text = $"Stai per configurare una {AutoScelta}";
                PrezzoBase.Text = $"Prezzo di partenza: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Jeep Renegade 1.0 GSE T3 120CV FWD")
            {
                Image1.ImageUrl = "/img/jeepRenegade.png";
                lblDescrAuto.Text = $"Stai per configurare una: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di partenza: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Fiat 500X 1.3 MULTIJET 95 CV")
            {
                Image1.ImageUrl = "/img/fiat500x.png";
                lblDescrAuto.Text = $"Stai per configurare una: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di partenza: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Alfa Romeo Tonale Ed. Speciale PLUG-IN HYBRID Q4")
            {
                Image1.ImageUrl = "/img/tonale.png";
                lblDescrAuto.Text = $"Stai per configurare una: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di partenza: {Prezzo.ToString("c2")}";
            }
            else if (AutoScelta == "Fiat Panda Garmin 1.0 HYBRID 70 CV")
            {
                Image1.ImageUrl = "/img/fiatpanda.png";
                lblDescrAuto.Text = $"Stai per configurare una: <br /> {AutoScelta} <br />";
                PrezzoBase.Text = $"Prezzo di partenza: {Prezzo.ToString("c2")}";
            }


        }


    }
}