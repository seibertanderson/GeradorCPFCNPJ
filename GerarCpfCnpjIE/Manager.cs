using System;
using System.Net;
using System.Net.Mail;

namespace GerarCpfCnpjIE
{
    public class Manager
    {
        public int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;
        public int cpf, cpf2;
        public int cnpj, cnpj2;
        Random ran = new Random();
        public string GerarCpf(bool gerarComPontos)
        {
            n1 = ran.Next(0, 9);
            n2 = ran.Next(0, 9);
            n3 = ran.Next(0, 9);
            n4 = ran.Next(0, 9);
            n5 = ran.Next(0, 9);
            n6 = ran.Next(0, 9);
            n7 = ran.Next(0, 9);
            n8 = ran.Next(0, 9);
            n9 = ran.Next(0, 9);
            cpf = n9 * 2 + n8 * 3 + n7 * 4 + n6 * 5 + n5 * 6 + n4 * 7 + n3 * 8 + n2 * 9 + n1 * 10;
            cpf = 11 - ((cpf - ((cpf / 11) * 11)));
            if (cpf >= 10)
                cpf = 0;

            cpf2 = cpf * 2 + n9 * 3 + n8 * 4 + n7 * 5 + n6 * 6 + n5 * 7 + n4 * 8 + n3 * 9 + n2 * 10 + n1 * 11;
            cpf2 = 11 - ((cpf2 - ((cpf2 / 11) * 11)));
            if (cpf2 >= 10)
                cpf2 = 0;

            string retorno = "";
            if (gerarComPontos)
            {
                retorno = n1 + "" + n2 + "" + n3 + "." + n4 + "" + n5 + "" + n6 + "." + n7 + "" + n8 + "" + n9 + "-" + cpf + "" + cpf2;
            }
            else
            {
                retorno = n1 + "" + n2 + "" + n3 + n4 + "" + n5 + "" + n6 + n7 + "" + n8 + "" + n9 + cpf + "" + cpf2;
            }
            return retorno;
        }

        public string GerarCnpj(bool gerarComPontos)
        {
            n1 = ran.Next(0, 9);
            n2 = ran.Next(0, 9);
            n3 = ran.Next(0, 9);
            n4 = ran.Next(0, 9);
            n5 = ran.Next(0, 9);
            n6 = ran.Next(0, 9);
            n7 = ran.Next(0, 9);
            n8 = ran.Next(0, 9);
            n9 = 0;
            n10 = 0;
            n11 = 0;
            n12 = 1;

            cnpj = n12 * 2 + n11 * 3 + n10 * 4 + n9 * 5 + n8 * 6 + n7 * 7 + n6 * 8 + n5 * 9 + n4 * 2 + n3 * 3 + n2 * 4 + n1 * 5;
            cnpj = 11 - ((cnpj - ((cnpj / 11) * 11)));
            if (cnpj >= 10)
            {
                cnpj = 0;
            }

            cnpj2 = cnpj * 2 + n12 * 3 + n11 * 4 + n10 * 5 + n9 * 6 + n8 * 7 + n7 * 8 + n6 * 9 + n5 * 2 + n4 * 3 + n3 * 4 + n2 * 5 + n1 * 6;
            cnpj2 = 11 - ((cnpj2 - ((cnpj2 / 11) * 11)));
            if (cnpj2 >= 10)
            {
                cnpj2 = 0;
            }
            string retorno = "";

            if (gerarComPontos)
            {
                retorno = n1 + "" + n2 + "." + n3 + "" + n4 + "" + n5 + "." + n6 + "" + n7 + "" + n8 + "/" + n9 + "" + n10 + "" + n11 + "" + n12 + "-" + cnpj + "" + cnpj2;
            }
            else
            {
                retorno = n1 + "" + n2 + "" + n3 + "" + n4 + "" + n5 + "" + n6 + "" + n7 + "" + n8 + "" + n9 + "" + n10 + "" + n11 + "" + n12 + "" + cnpj + "" + cnpj2;
            }

            return retorno;
        }
    }
}
