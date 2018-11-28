using Bhopal2.DAO;
using Bhopal2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bhopal2
{
    public partial class CadastroDeFornecedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var param = Request.QueryString["Id"];
                if (param != null)
                {
                    long id;
                    var i = long.TryParse(param, out id);
                    if (i)
                    {
                        AtualizaFormulario(id);
                    }
                }
            }
        }

        void AtualizaFormulario(long Id)
        {
            var i = new FornecedorDAO().ObterPeloId(Id);

            txtId.Text = i.Id.ToString();
            txtFornecedor.Text = i.Nome;
            txtContato.Text = i.Contato;
            txtTelefone.Text = i.Contatos[0] != null ? i.Contatos[0].Telefone : string.Empty;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor f = new Fornecedor();
            Contato c = new Contato();
            var dao = new FornecedorDAO();

            if (txtId.Text != string.Empty)
            {
                f = dao.ObterPeloId(long.Parse(txtId.Text));
            }

            f.Nome = txtFornecedor.Text.ToString();
            c.Nome = txtContato.Text.ToString();
            c.Telefone = txtTelefone.Text.ToString();

            IList<Contato> contatos = new List<Contato>();
            contatos.Add(c);
            f.Contatos = contatos;

            ContatoDAO contato = new ContatoDAO();
            dao.Adicionar(f);
            //contato.AdicionaContato(c);

            //Response.Write("Cadastro realizado com sucesso");
            Response.Redirect("/Fornecedores.aspx");
        }
    }
}