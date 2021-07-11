using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginFlitzWeb
{
    public partial class Relatorios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carrega_CB_uf();
        }
        private void carrega_CB_uf()
        {
            List<ListItem> ListaUF = new List<ListItem>();
            ListaUF.Add(new ListItem() { Text = "AC", Value = "0" });
            ListaUF.Add(new ListItem() { Text = "AL", Value = "1" });
            ListaUF.Add(new ListItem() { Text = "AP", Value = "2" });
            ListaUF.Add(new ListItem() { Text = "AM", Value = "3" });
            ListaUF.Add(new ListItem() { Text = "BA", Value = "4" });
            ListaUF.Add(new ListItem() { Text = "CE", Value = "5" });
            ListaUF.Add(new ListItem() { Text = "DF", Value = "6" });
            ListaUF.Add(new ListItem() { Text = "ES", Value = "7" });
            ListaUF.Add(new ListItem() { Text = "GO", Value = "8" });
            ListaUF.Add(new ListItem() { Text = "MA", Value = "9" });
            ListaUF.Add(new ListItem() { Text = "MT", Value = "10" });
            ListaUF.Add(new ListItem() { Text = "MS", Value = "11" });
            ListaUF.Add(new ListItem() { Text = "MG", Value = "12" });
            ListaUF.Add(new ListItem() { Text = "PA", Value = "13" });
            ListaUF.Add(new ListItem() { Text = "PB", Value = "14" });
            ListaUF.Add(new ListItem() { Text = "PR", Value = "15" });
            ListaUF.Add(new ListItem() { Text = "PE", Value = "16" });
            ListaUF.Add(new ListItem() { Text = "PI", Value = "17" });
            ListaUF.Add(new ListItem() { Text = "RJ", Value = "18" });
            ListaUF.Add(new ListItem() { Text = "RN", Value = "19" });
            ListaUF.Add(new ListItem() { Text = "RS", Value = "20" });
            ListaUF.Add(new ListItem() { Text = "RO", Value = "21" });
            ListaUF.Add(new ListItem() { Text = "RR", Value = "22" });
            ListaUF.Add(new ListItem() { Text = "SC", Value = "23" });
            ListaUF.Add(new ListItem() { Text = "SP", Value = "24" });
            ListaUF.Add(new ListItem() { Text = "SE", Value = "25" });
            ListaUF.Add(new ListItem() { Text = "TO", Value = "26" });
            ListaUF.Add(new ListItem() { Text = "TODOS", Value = "27" });
            CB_uf.DataSource = ListaUF;
            CB_uf.DataBind();
        }
    }
}