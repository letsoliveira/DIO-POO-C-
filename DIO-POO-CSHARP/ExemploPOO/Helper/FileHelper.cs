using System.IO;
using System.Collections.Generic;

//AULA MANIPULANDO ARQUIVOS - LISTAR DIRETÓRIOS
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }            
        }

        //AULA MANIPULANDO ARQUIVOS - CRIAR DIRETÓRIO
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        //AULA MANIPULANDO ARQUIVOS - APAGAR DIRETÓRIO E ARQUIVOS
        public void ApagarDiretorio(string caminho, bool ApagarArquivos)
        {
            Directory.Delete(caminho, ApagarArquivos);
        }
        //AULA MANIPULANDO ARQUIVOS - CRIAR ARQUIVO TEXTO
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
            File.WriteAllText(caminho, conteudo);
            }
        }
        //AULA MANIPULANDO ARQUIVOS - CRIAR ARQUIVO TEXTO COM STREAM
        public void CriarArquivoTextoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        //AULA MANIPULANDO ARQUIVOS - ADICIONAR NOVAS LINHAS EM UM ARQUIVO DE TEXTO
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }        
        //AULA MANIPULANDO ARQUIVOS - ADICIONAR NOVAS LINHAS DE TEXTO COM STREAM
        public void AdicionarTextoStream (string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        //AULA MANIPULANDO ARQUIVOS - LER ARQUIVOS        
        public void LerArquivo (string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream (string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }
        //AULA MANIPULANDO ARQUIVOS - MOVER ARQUIVOS             
        public void MoverArquivo (string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }
        //AULA MANIPULANDO ARQUIVOS - COPIAR ARQUIVOS         
        public void CopiarArquivo (string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }  
        //AULA MANIPULANDO ARQUIVOS - DELETAR ARQUIVOS    
        public void DeletarArquivo (string caminho)
        {
            File.Delete(caminho);
        }          
    }
}