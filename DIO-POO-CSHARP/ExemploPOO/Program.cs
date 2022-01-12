using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // var caminho = "C:\\workspace\\DIO-Arquivos";        
            // var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivotestebkp.txt");           
            // FileHelper helper = new FileHelper();
            // helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivoTeste = Path.Combine(caminho, "arquivoteste.txt");            
            // var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivotestebkp.txt");           
            // FileHelper helper = new FileHelper();
            // helper.CopiarArquivo(caminhoArquivoTeste,caminhoArquivoTesteCopia,false);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivo = Path.Combine(caminho, "arquivotestestream.txt");
            // var novoCaminhoArquivo = Path.Combine(caminho, "Teste2", "arquivotestestream.txt");           
            // FileHelper helper = new FileHelper();
            // helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo,false);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivo = Path.Combine(caminho, "arquivotestestream.txt");            
            // FileHelper helper = new FileHelper();
            // helper.LerArquivoStream(caminhoArquivo);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivo = Path.Combine(caminho, "arquivotestestream.txt");            
            // var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            // var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            // FileHelper helper = new FileHelper();
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivo = Path.Combine(caminho, "arquivotestestream.txt");            
            // var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            // FileHelper helper = new FileHelper();
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoArquivo = Path.Combine(caminho, "arquivoteste.txt");
            // FileHelper helper = new FileHelper();
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Teste1");
            // FileHelper helper = new FileHelper();
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // var caminhoPathCombine = Path.Combine(caminho, "Teste3", "SubpastaTeste3");
            // FileHelper helper = new FileHelper();
            // System.Console.WriteLine("Criando diretório: "+ caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // FileHelper helper = new FileHelper();
            // helper.ListarArquivosDiretorios(caminho);

            // var caminho = "C:\\workspace\\DIO-Arquivos";
            // FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
            
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));
            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Documento = "123456";
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Leo";
            // p2.Idade = 30;
            // p2.Documento = "789456";
            // p2.Salario = 2000;
            // p2.Apresentar();

            // //Valores validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
            
            // //Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
        }
    }
}
