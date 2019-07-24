using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace Desafio_sexta_26_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // console que faça a leitura de um json
            //mapeia os objetos e imprime na tela       
            // 
            //apos a leitura dos dados o app devera dar as seguintes opções para o usuario
            //remover um registro
            //salvar alteração em um novo arquivo json e manter o original intacto
            //
            Pessoas p = new Pessoas();
            

            string path = @"C:\Users\Treinamento 4\Desktop\exercicio_estudo\Trabalho.json";
            var file = File.ReadAllText(path);
            var lstResults = JsonConvert.DeserializeObject<List<Pessoas>>(file);


           // p.ImprimePessoas(p);

            foreach (var printf in lstResults)
            {
                Console.WriteLine(printf.ToString());
                Console.WriteLine();
            }

        }
    }
}
