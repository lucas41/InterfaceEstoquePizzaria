using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Threading;

namespace InterfaceEstoque
{
    public partial class FormAdicionarIngrediente : Form
    {
        Thread nt;
        private int id;
        public FormAdicionarIngrediente(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FormAdicionarIngrediente_Load(object sender, EventArgs e)
        {
            using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
            {

                Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();

               
                labelNameIngrediente.Text = a.nome;
                labelQuantMax.Text = a.quant_max.ToString();

                numericUpDownIngrediente.Value = (decimal)a.quant_atual;
            }
        }

        private void proximaGerenciarEstoque(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }

        private void buttonAdicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (EstoquePizzariaEntities ctx = new EstoquePizzariaEntities())
                {
                    Ingrediente a = ctx.Ingrediente.Where(x => x.id_ingrediente == this.id).SingleOrDefault();
                    a.quant_atual = (int)numericUpDownIngrediente.Value;

                    if (a.quant_atual > a.quant_max)
                    {
                        MessageBox.Show("Valor não pode execeder a quantidade máxima do ingrediente no estoque");
                        return;
                    }

                    ctx.SaveChanges();
                    MessageBox.Show("Adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar!\n" + ex);
                throw;
            }

            this.Close();
            nt = new Thread(proximaGerenciarEstoque);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(voltarPagina);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void voltarPagina(object obj)
        {
            Application.Run(new FormGerenciarEstoque());
        }
    }
}
