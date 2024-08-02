using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_
{
    public static class TipoPrimitivo
    {
        public static void ImprimirTipos()
        {
            //Tipo inteiro de 8 Bits com sinal
            sbyte SByte = -128; //Valores variam de -128 a 127
            Console.WriteLine($"sbyte:{SByte}");

            //Tipo inteiro de 8 Bits com sinal
            byte variavelByte = 255; //Valores variam de 0 a 255
            Console.WriteLine($"byte:{variavelByte}");

            //Tipo inteiro de 8 Bits com sinal
            short variavelShort = -32768; //Valores variam de -32768 a 32768
            Console.WriteLine($"short:{variavelShort}");

            //Tipo inteiro de 8 Bits com sinal
            ushort variavelUShort = 65535;
            Console.WriteLine($"ushort:{variavelUShort}");

            //Tipo inteiro de 8 Bits com sinal
            int variavelInt = -2147483648;
            Console.WriteLine($"int:{variavelInt}");

            //Tipo inteiro de 8 Bits com sinal
            uint variavelUint = 3294972295;
            Console.WriteLine($"uint:{variavelUint}");

            //Tipo inteiro de 8 Bits com sinal
            long variavelLong = 3294972295;
            Console.WriteLine($"long:{variavelLong}");

            //Tipo inteiro de 8 Bits com sinal
            ulong variavelULong = 3294972295;
            Console.WriteLine($"Ulong:{variavelULong}");

            //Tipo inteiro de 8 Bits com sinal
            float variavelFloat = 3.14f;
            Console.WriteLine($"Float:{variavelFloat}");

            //Tipo inteiro de 8 Bits com sinal
            double variavelDouble = 3.14f;
            Console.WriteLine($"Float:{variavelDouble}");

            //Tipo inteiro de 8 Bits com sinal
            decimal variavelDecimal = 73409534095483509345098M;
            Console.WriteLine($"Decimal:{variavelDecimal}");

            //Tipo inteiro de 8 Bits com sinal
            char variavelChar = 'A';
            Console.WriteLine($"Char:{variavelChar}");

            //Tipo inteiro de 8 Bits com sinal
            bool variavelBool = true;
            Console.WriteLine($"Bool:{variavelBool}");

            //Tipo inteiro de 8 Bits com sinal
            object variavelObject = null;
            Console.WriteLine($"Object:{variavelObject}");

            //Tipo inteiro de 8 Bits com sinal
            string variavelString = "Olá, Mundo!";
            Console.WriteLine($"String:{variavelString}");


        }
    }
}
