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
            Configurazione.Visible = false;
        }

        Auto vettura = new Auto();
       
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

            vettura.Modello = Prezzo;

            AggiungiOptional();

        }

        public void AggiungiOptional()
        {
            string optional = "";
            decimal TotOptional = 0;


            foreach (ListItem opt in cblOptional.Items)
            {
                if (opt.Selected)
                {
                    optional += $" - {opt.Text} ";
                    TotOptional += Convert.ToInt32(opt.Value);
                }
            }
            
           vettura.Optional = Convert.ToDouble(TotOptional);

        }

        protected void Calcola_Click(object sender, EventArgs e)
        {
            Configurazione.Visible = true;
           
            vettura.Garanzia = ddlGaranzia.SelectedItem.Text;


            ListaConfig.Text = $"Totale Modello: {(vettura.Modello).ToString("c2")}<br />Totale Optional: {(vettura.Optional).ToString("c2")}<br />Totale Garanzia: {vettura.Garanzia}<br />";

            TotConfig.Text = $"Totale Complessivo: {(vettura.CostoPreventivo()).ToString("c2")}";
        }
        public class Auto
        {
            private double _modello;
            public double Modello { get { return _modello}; set { _modello = value; } }

            private double _optional;
            public double Optional { get { return _optional}; set { _optional = value; } }
            public string Garanzia { get; set; }
            
            public double CostoPreventivo() {
                return Modello + Optional;
            }

        }
    }
   }
