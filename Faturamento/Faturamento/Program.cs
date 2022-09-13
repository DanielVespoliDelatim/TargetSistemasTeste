using Faturamento.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;

namespace Faturamento
{
    class Program
    {
        static void Main(string[] args)
        {


            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");

            var dados = JsonConvert.DeserializeObject<List<Dados>>(json);



            double menorvalor = 99999999999;
            double maiorvalor = 0;
            int dia = 0;
            int diamenor = 30;
            int diasmensais = 0;
            double mediamensal = 0;
            double total = 0;
            int diasmensaisnumeros = 0;

            Console.WriteLine("Dias com salário maior que a média: ");
            for (var i = 0; i < 30; i++)
            {
                total += dados[i].valor;
                mediamensal = total / 30;

                if (dados[i].valor > mediamensal)
                {
                    diasmensais = dados[i].dia;
                    Console.WriteLine(diasmensais);
                    diasmensaisnumeros++;

                }


            }




            for (var i = 0; i < 30; i++)
            {
                if (dados[i].valor != 0)
                {
                    {
                        if (dados[i].valor < menorvalor)
                        {
                            menorvalor = dados[i].valor;
                            diamenor = dados[i].dia;
                        }

                    }
                }
            }



            for (var i = 0; i < 30; i++)
            {
                if (dados[i].valor > maiorvalor)
                {
                    maiorvalor = dados[i].valor;
                    dia = dados[i].dia;
                }


            }





            Console.WriteLine("Total de dias com salário maior que médio " + diasmensaisnumeros);
            Console.WriteLine("Maior valor =" + maiorvalor.ToString("C", CultureInfo.CurrentCulture) + " No dia " + dia);
            Console.WriteLine("Menor valor =" + menorvalor.ToString("C", CultureInfo.CurrentCulture) + " No dia " + diamenor);

            Console.WriteLine("Média mensal =" + mediamensal.ToString("C", CultureInfo.CurrentCulture));



        }

    }
}
