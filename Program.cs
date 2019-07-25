using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Desafio_sexta_26_07.Entities;

namespace Desafio_sexta_26_07
{
    class Program
    {
        public static string IndextoRemove { get; private set; }

        static void Main(string[] args)
        {
            // console que faça a leitura de um json
            //mapeia os objetos e imprime na tela       
            // 
            //apos a leitura dos dados o app devera dar as seguintes opções para o usuario
            //remover um registro
            //salvar alteração em um novo arquivo json e manter o original intacto
            //

            Metodos m = new Metodos();

              string path = @"C:\Users\Treinamento 4\Desktop\exercicio_estudo\Trabalho.json";
              var file = File.ReadAllText(path);
              var lstResults = JsonConvert.DeserializeObject<List<Pessoas>>(file);
             

            // p.ImprimePessoas(p);

              foreach (var printf in lstResults)
              {
                  Console.WriteLine(printf.ToString());
                  Console.WriteLine();
              }


                Console.WriteLine("DESEJA REMOVER ALGUM REGISTRO ? SIM OU NÃO");
                string decisao = Console.ReadLine().ToUpper();


                while (decisao != "SIM")
                {
                    Console.WriteLine("OPÇÃO INVALIDA! DIGITE SIM OU NÃO");
                    decisao = Console.ReadLine().ToUpper();

                }

                //


               //

                if (decisao == "SIM")
                {
                    Console.WriteLine("QUANTOS REGISTROS DESEJA REMOVER ?");
                    Int32.TryParse(Console.ReadLine(), out int  decisaotwo);

                   while (decisaotwo > 14 || decisaotwo <1)
                   {
                       Console.WriteLine("DIGITE UM NUMERO VALIDO");
                      Int32.TryParse(Console.ReadLine(), out decisaotwo);
                   }
                  


                    for (int i = 1; i <= decisaotwo; i++)
                    {
                        Console.WriteLine("QUAL NUMERO DO INDEX QUE DESEJA REMOVER?");
                        string IndextoRemove = Console.ReadLine();
                   // Int32.TryParse(Console.ReadLine(), out int IndextoRemove);

                    m.RemoveToList(lstResults, IndextoRemove);

                        Console.WriteLine();
                        Console.WriteLine("REGISTROS REMOVIDOS COM SUCESSO !");
                        Console.WriteLine();
                       
                    }
                      m.Attlist(lstResults);
                }
                
                
                // teste remove
            //} while

            //  Console.WriteLine("teste");
            //var itemToRemove = resultlist.SingleOrDefault(r => r.Id == 2);
            //if (itemToRemove != null)
            //    resultList.Remove(itemToRemove);




        }
    }


}
