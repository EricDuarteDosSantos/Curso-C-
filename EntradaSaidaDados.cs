﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class EntradaSaidaDados
    {
        public static void LerArmazenar()
        {
            string nome;
            Console.WriteLine("Digite o seu Nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"O nome digitado é:{nome}");
        }

    }
}