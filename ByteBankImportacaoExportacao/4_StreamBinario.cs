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
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(423); //numero agencia
                escritor.Write(123123); //numero da conta
                escritor.Write(4000.50); //saldo
                escritor.Write("Gustavo Braga"); //nome
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Agencia: {agencia}, conta: {conta}, saldo: {saldo}, titular: {titular}");
            }
        }
    }
}
