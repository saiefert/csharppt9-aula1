using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComString = "456,78945.50,Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComString);


                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWriter()
        {
            var caminhoDoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("Linha 0");

                for (int i = 0; i < 10; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); // Despeja o buffer para o stream

                    Console.WriteLine($"Linha {i} escrita. Tecle enter para adicionar mais uma linha");
                    Console.ReadLine();
                }                
            }
        }
    }
}
