using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Desafio_sexta_26_07.Entities
{
    public class Metodos
    {
        //REMOVENDO REGISTRO 
        public void RemoveToList(List<Pessoas> file2,string removeatolst)
        {
            var itemToRemove = file2.Single(r => r.Index == removeatolst);
            file2.Remove(itemToRemove);


        }

        // SERIALIZANDO O ARQUIVO ATUALIZADO
        public  void Attlist(List<Pessoas> file1)
        {

            Guid filenew;
            filenew = Guid.NewGuid();
            string path = $@"C:\Users\Treinamento 4\Desktop\exercicio_estudo\Trabalho.{filenew}";
            StreamWriter save = new StreamWriter(path);
            string r1 = JsonConvert.SerializeObject(file1);
            save.WriteLine(r1);
            save.Close();
            



        }
    }
}