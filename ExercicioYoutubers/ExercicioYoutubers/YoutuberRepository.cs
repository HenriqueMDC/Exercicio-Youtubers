using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioYoutubers
{
    [Serializable]
    class YoutuberRepository
    {
        List<Youtubers> youtubers = new List<Youtubers>();

        public YoutuberRepository()
        {
            if (File.Exists(CadastroYoutubers.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(CadastroYoutubers.NOME_ARQUIVO);
                youtubers = ((YoutuberRepository)binaryReader.Deserialize(stream)).ObterYoutubers();
                stream.Close();
            }
        }
        public void AdicionarYoutubers(Youtubers youtuber)
        {
            youtubers.Add(youtuber);

            EscreverNoArquivoDosYoutubers();
        }

        private void EscreverNoArquivoDosYoutubers()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutubers.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }

        public List<Youtubers> ObterYoutubers()
        {
            return youtubers;
        }

        internal void ApagarYoutuber(string nomeCanal)
        {
            foreach (Youtubers youtuber in youtubers)
            {
                if (youtuber.GetNomeCanal() == nomeCanal)
                {
                    youtubers.Remove(youtuber);
                    EscreverNoArquivoDosYoutubers();
                    return;
                }
            }
        }

        internal void EditarYoutubers(Youtubers youtuber, int posicao)
        {
            youtubers[posicao] = youtuber;
            EscreverNoArquivoDosYoutubers();
        }
    }
}
