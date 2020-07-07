using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Entidades;


namespace Lab4
{
    public partial class GridSimpleLab : System.Web.UI.Page
    {
        GestionBD objBD;
        List<Farmacia> auxListado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                cargaDatosGrid();
            }

        }
        void cargaDatosGrid()
        {
            objBD = new GestionBD();
            auxListado = objBD.listadoFarmacia();
            gridFarmacia.DataSource = auxListado;
            gridFarmacia.DataBind();
        }

        protected void gridFarmacia_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridFarmacia, "Select$" + e.Row.RowIndex);
            }

        }

        protected void gridFarmacia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridFarmacia.Rows)
            {

                if (fila.RowIndex == gridFarmacia.SelectedIndex)
                {
                    TxtId.Text = fila.Cells[0].Text;
                    txtNumero.Text = fila.Cells[1].Text;
                    txtCodigo.Text = fila.Cells[2].Text; //obtengo el codigo de herramienta
                    txtdetalle.Text = fila.Cells[3].Text;
                    txtCantidad.Text = fila.Cells[4].Text;
                    txtCosto.Text = fila.Cells[5].Text;
                    txtTotal.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }

            }

            cargaDatosGrid();
        }
    }
}