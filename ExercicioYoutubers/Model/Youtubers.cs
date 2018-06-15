using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]

    public class Youtubers
    {
        private static int UltimoCodigo;
        private int Codigo;
        public string NomeCanal;
        public string NomePessoal;
        public double Inscritos;
        public double Visualizacao;
        public int QuantidadeDeVideos;
        public string Categoria;
        public string Anuncio;
        public double Likes;
        public string Descricao;
        public string Nacionalidade;
        public string Patrocinador;
        public int Strikes;
        public string Plataforma;
        public string Streamer;
        public string Apelido;
        public double Renda;


        public Youtubers()
        {
            Codigo = ++UltimoCodigo;
        }

        public void SetNomeCanal(string nomeCanal)
        {
            this.NomeCanal = nomeCanal;
        }

        public void SetNomePessoal(string nomePessoal)
        {
            this.NomePessoal = nomePessoal;
        }

        public void SetInscritos(double inscritos)
        {
            this.Inscritos = inscritos;
        }

        public void SetVisualizacao(double visualizacao)
        {
            this.Visualizacao = visualizacao;
        }

        public void SetQuantidadeDeVideos(int quantidadeDeVideos)
        {
            this.QuantidadeDeVideos = quantidadeDeVideos;
        }

        public void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }

        public void SetAnuncio(string anuncio)
        {
            this.Anuncio = anuncio;
        }

        public void SetLikes(double likes)
        {
            this.Likes = likes;
        }

        public void SetDescricao(string descricao)
        {
            this.Descricao = descricao;
        }

        public void SetNacionalidade(string nacionalidade)
        {
            this.Nacionalidade = nacionalidade;
        }

        public void SetPatrocinador(string patrocinador)
        {
            this.Patrocinador = patrocinador;
        }

        public void SetStrikes(int strikes)
        {
            this.Strikes = strikes;
        }

        public void SetPlataforma(string plataforma)
        {
            this.Plataforma = plataforma;
        }

        public void SetStreamer(string streamer)
        {
            this.Streamer = streamer;
        }

        public void SetApelido(string apelido)
        {
            this.Apelido = apelido;
        }

        public void SetRenda(double renda)
        {
            this.Renda = renda;
        }

        public void SetCodigo()
        {
            
        }

        public void Remove(Youtubers youtubers)
        {
            throw new NotImplementedException();
        }

        public string GetNomePessoal() { return NomePessoal; }

        public string GetNomeCanal() { return NomeCanal; }

        public double GetInscritos() { return Inscritos; }

        public double GetVisualizacao() { return Visualizacao; }

        public int GetQuantidadeDeVideos() { return QuantidadeDeVideos; }

        public string GetCategoria() { return Categoria; }

        public string GetAnuncio() { return Anuncio; }

        public double GetLikes() { return Likes; }

        public string GetDescricao() { return Descricao; }

        public string GetNacionalidade() { return Nacionalidade; }

        public string GetPatrocinador() { return Patrocinador; }

        public int GetStrikes() { return Strikes; }

        public string GetPlataforma() { return Plataforma; }

        public string GetStreamer() { return Streamer; }

        public string GetApelido() { return Apelido; }

        public double GetRenda() { return Renda; }

        public int GetCodigo() { return UltimoCodigo; }
    }
}
