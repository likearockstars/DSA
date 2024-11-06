using System;
using System.Runtime.InteropServices;

namespace Abstract
{
    class Pokemon
    {
        //Aqui nos encontramos os atributos de uma classe, que nesse caso
        //em estrutura, chamamos de dados da classe
        public string Name;
        public int Exp;

        //Aqui temos os metoso de uma classe, que alteram os dados da classe,
        //tambem podemos chamar de operacoes
        public bool IsPokemon()
        {
            return true;
        }
    }
}