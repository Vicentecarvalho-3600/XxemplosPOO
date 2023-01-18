using System;
using ExemploPOO.Helper;
using ExemploPOO.models;

namespace ExemploPOO {

    class Program {

        static void Main(string[] args) {

            var caminho = "C:\\TrabalhandoComarquivos";
            var caminhoPathCombine = Path.Combine(caminho,"Pasta Teste3");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-text-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-text.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-text-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste2", "arquivo-text-stream.txt");
            var listaString = new List<string>{"linha1", "linha2", "Linha3"};
            var listaString2 = new List<string>{"linha4", "linha5", "Linha6"};
            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Ola mundo teste escrita de arquivo!");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaString2);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);


            // Calculadora calc = new Calculadora();

            

            // Console.WriteLine(calc.Somar(2, 3));


            // Computador comp = new Computador();


            // Console.WriteLine(comp.ToString());

            // Corrente conta = new Corrente();
            // conta.Creditar(100.00);

            // conta.ExibirSaldo();


            // Calculadora calc = new Calculadora();

            // Console.WriteLine("Resultado da soma: "+ calc.Somar(3, 4));



            // Professor p1 = new Professor();

            // p1.Salario = 2000.0;
            // p1.Nome = "Vicente";
            // p1.Idade = 28;
            // p1.Documento = "123456";
            // p1.Apresentar();

            // Aluno p2 = new Aluno();

            // p2.Nota = 10.0;
            // p2.Nome = "Vicente";
            // p2.Idade = 28;
            // p2.Documento = "123456";
            // p2.Apresentar();







            // Rentangulo r = new Rentangulo();
            // r.DefinirMedidas(30, 0);

            // Console.WriteLine($"Area: {r.ObterArea()}");

            // Pessoa p1 = new Pessoa();

            // p1.Nome = "vicente";
            // p1.Idade = 28;

            // p1.Apresentar();



        }
    }
}

