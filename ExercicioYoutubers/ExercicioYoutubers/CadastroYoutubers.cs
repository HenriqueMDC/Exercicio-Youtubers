using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioYoutubers
{
    public partial class CadastroYoutubers : Form
    {
        private Youtubers youtubers;
        private int codigo;
        public int posicao = -1;
        public static string NOME_ARQUIVO = "Personagens.bin";

        public CadastroYoutubers()
        {
            InitializeComponent();
        }

        public CadastroYoutubers(int codigo)
        {
            // TODO: Complete member initialization
            this.codigo = codigo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Youtubers youtubers = new Youtubers();
            try
            {
                youtubers.SetNomePessoal(txtNomePessoal.Text);
                txtNomePessoal.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetNomeCanal(txtNomeCanal.Text);
                txtNomeCanal.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetInscritos(Convert.ToDouble(txtQuantidadeInscritos.Text));
                txtQuantidadeInscritos.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetVisualizacao(Convert.ToDouble(txtVisualizacao.Text));
                txtVisualizacao.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetQuantidadeDeVideos(Convert.ToInt32(txtQuantidadeVideos.Text));
                txtQuantidadeVideos.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            youtubers.SetAnuncio(cbAnuncio.SelectedItem.ToString());

            try
            {
                youtubers.SetLikes(Convert.ToDouble(txtQuantidadeLikes.Text));
                txtQuantidadeLikes.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetDescricao(txtDescricao.Text);
                txtDescricao.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetNacionalidade(txtNacionalidade.Text);
                txtNacionalidade.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetDescricao(txtDescricao.Text);
                txtDescricao.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            youtubers.SetPatrocinador(cbPatrocinador.SelectedItem.ToString());

            try
            {
                youtubers.SetStrikes(Convert.ToInt32(txtQuantidadesStrikes.Text));
                txtQuantidadesStrikes.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            youtubers.SetPlataforma(cbPlataforma.SelectedItem.ToString());

            youtubers.SetStreamer(cbStreamers.SelectedItem.ToString());

            try
            {
                youtubers.SetApelido(txtApelido.Text);
                txtApelido.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                youtubers.SetRenda(Convert.ToDouble(txtRenda.Text));
                txtRenda.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            YoutuberRepository tudo = new YoutuberRepository();
            if (posicao == -1)
            {
                tudo.AdicionarYoutubers(youtubers);
                MessageBox.Show("Youtuber cadastrado com sucesso");
            }

            else
            {
                tudo.EditarYoutubers(youtubers, posicao);
                MessageBox.Show("Youtuber editado com sucesso");
            }
            AtualizarListaYoutubers();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomePessoal.Text = "";
            txtNomeCanal.Text = "";
            txtQuantidadeInscritos.Text = "";
            txtVisualizacao.Text = "";
            txtQuantidadeVideos.Text = "";
            txtCategoria.Text = "";
            cbAnuncio.SelectedIndex = -1;
            txtQuantidadeLikes.Text = "";
            txtDescricao.Text = "";
            txtNacionalidade.Text = "";
            cbPatrocinador.SelectedIndex = -1;
            txtQuantidadesStrikes.Text = "";
            cbPlataforma.SelectedIndex = -1;
            cbStreamers.SelectedIndex = -1;
            txtApelido.Text = "";
            txtRenda.Text = "";
        }

        private void AtualizarListaYoutubers()
        {
            YoutuberRepository tudo = new YoutuberRepository();
            dataGridView1.Rows.Clear();

            foreach (Youtubers youtubers in tudo.ObterYoutubers())
            {
                dataGridView1.Rows.Add(new Object[]
                {
                    youtubers.GetNomeCanal(),
                    youtubers.GetNomePessoal(),
                    youtubers.GetInscritos(),
                    youtubers.GetQuantidadeDeVideos(),
                    youtubers.GetLikes(),
                    youtubers.GetVisualizacao(),
                    youtubers.GetRenda()
                });
            }
        }

        private void CadastroYoutubers_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutubers();
        }

        private void CadastroYoutubers_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.E))
            {
                EditarYoutubers();
            }
            else if (e.KeyCode == Keys.F2)
            {
                ApagarYoutuber();
            }
        }

        private void EditarYoutubers()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            YoutuberRepository repositorio = new YoutuberRepository();

            int quantidade = 0;
            foreach (Youtubers personagem in repositorio.ObterYoutubers())
            {
                if (personagem.GetNomeCanal() == nome)
                {
                    youtubers.GetNomeCanal();
                    youtubers.GetNomePessoal();
                    youtubers.GetInscritos();
                    youtubers.GetQuantidadeDeVideos();
                    youtubers.GetLikes();
                    youtubers.GetVisualizacao();
                    youtubers.GetRenda();
                    posicao = quantidade;
                    return;
                }
                quantidade++;
            }
        }
            private void ApagarYoutuber()
            {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo neste grid");
                return;
            }

                string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                YoutuberRepository repositorio = new YoutuberRepository();
                repositorio.ApagarYoutuber(nome);
                MessageBox.Show(nome + " apagado com sucesso.");
                LimparCampos();
            }
    }
}
