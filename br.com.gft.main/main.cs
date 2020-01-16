using System;
using System.Collections.Generic;
using System.Text;
using Prova01.br.com.gft.model;

namespace Prova01.br.com.gft.main
{
    class main
    {
        public static void Main(String[] args)
        {

            Pessoa joao = new Pessoa("Joao", 15);
            Pessoa leandro = new Pessoa("Leandro", 21);
            Pessoa paulo = new Pessoa("Paulo", 17);
            Pessoa jessica = new Pessoa("Jessica", 18);

            List<Pessoa> Pessoa = new List<Pessoa>
            {
                joao,
                leandro,
                paulo,
                jessica
            };

            int maiorId = 0;

            for (int i = 0; i < Pessoa.Count; i++)
            {
                if (Pessoa[i].idade > maiorId)
                {
                    maiorId = Pessoa[i].idade;

                }
                                                                      
            }
            Console.WriteLine("A Idade da pessoa mais velha é de: " + maiorId + " Anos");
            Console.ReadLine();
        }




    }
}
