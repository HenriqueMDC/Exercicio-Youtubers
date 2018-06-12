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
        List<Youtubers> youtuber = new List<Youtubers>();

        public YoutuberRepository()
        {
            if (File.Exists(CadastroYoutubers.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stram = File.OpenRead(CadastroYoutubers.NOME_ARQUIVO);
                youtuber = ((YoutuberRepository)binaryReader.Deserialize(stram)).ObterYoutubers();
            }
        }

        public void AdicionarYoutubers(Youtubers youtubers)
        {
            youtuber.Add(youtubers);

            EscreverNoArquivosDosYoutubers();
        }

        private void EscreverNoArquivosDosYoutubers()
        {
            BinaryFormatter binatyWrite = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutubers.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binatyWrite.Serialize(stream, this);
            stream.Close();
        }

        public List<Youtubers> ObterYoutubers()
        {
            return youtuber;
        }

        internal void ApagarYoutuber(string nomeCanal)
        {
            foreach (Youtubers youtubers in youtuber)
            {
                if (youtubers.GetNomeCanal() == nomeCanal)
                {
                    youtubers.Remove(youtubers);
                    EscreverNoArquivosDosYoutubers();
                    return;
                }
            }
        }

        internal void EditarYoutubers(Youtubers youtubers, int posicao)
        {
            youtuber[posicao] = youtubers;
            EscreverNoArquivosDosYoutubers();
        }
    }
}
