using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        // enum: enumeraciones
        enum Days { Dom, Lun, Mar, Mier, Vier, Sab };

        static void Main(string[] args)
        {
            // int: tipo entero, valor numérico de -2000000000 a 2000000000, de 32bits
            //Declaración
            int age;
            //Inicialización
            age = 18;
            //Declaración con inicialización
            int year = 2017;
            // instancia
            int number = new int();

            // bool: valor tipo booleano, almacena true o false
            bool active = false;

            // byte: número de 0 a 255, 8bits
            byte position = 1;

            // char: caracter U+0000 a U+FFFF, unicode de 16bits
            char type = 'a';

            // decimal: -7.9x10^28 a 7.9x10^28, 29 números después del punto (.)
            decimal pi = 3.14m;

            // double: -5x10^-324 a 5x10^308, 16 dígitos
            double distance = 100.5;

            // float: número -3.4x10^38 a 3.4x10^38, 7 dígitos de largo
            float x = 3.5f;

            // long: -9,000,000,000,000,000,000 a 9,000,000,000,000,000,000, 64bits
            long code = 648576473568456743;

            // sbyte: -127 a 127, 8bits
            sbyte status = -127;

            // short: -32,000 a 32,000, 16bits
            short pbi = 3279;

            // uint: 0 a 4,000,000,000 32bits unsigned
            uint myUnit = 767777888;

            // ulong: -9,000,000,000,000,000,000 a 9,000,000,000,000,000,000, 64bits, unsigned
            ulong alocation = 648576473568456743;

            // ushort: -32,000 a 32,000, 16bits, unsigned
            ushort pbi = 3279;
        }
    }

    struct Book
    {
        decimal price;
        string name;
        int code;
    }
}
