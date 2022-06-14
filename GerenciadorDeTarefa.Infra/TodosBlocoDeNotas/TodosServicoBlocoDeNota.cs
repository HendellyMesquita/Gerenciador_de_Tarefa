using System;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Infra.TodosBlocoDeNotas
{
    public static class TodosServicoBlocoDeNota
    {
        public static void EscreverArquivo(string path, string text)
        {
            try
            {
                File.WriteAllText(path, text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {path}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public static string LerArquivo(string path)
        {
            if (!File.Exists(path))
                return null;

            return File.ReadAllText(path);
        }
        public static string ObterNomeArquivo(string path)
        {
            var parts = path.Split('\\');
            Console.WriteLine(parts);

            var nomeEstencao = parts[parts.Length - 1].Split('.');
            Console.WriteLine(nomeEstencao);
            Console.WriteLine(nomeEstencao[0]);

            return nomeEstencao[0];
        }
    }

}
