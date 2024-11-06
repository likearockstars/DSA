using System;
using Abstract;
namespace AbstractData
{
    class AbstractData
    {
        public static void Main()
        {
            //Ao instanciarmos o objeto, percebemos que a classe Pokemon
            //é a abstracao para o usuario, ja que o usuario nao tem acesso
            //a como o a abstracao Pokemon foi feita/implantada.
            //Agora o Charmander é a utilização da classe, ou seja, a implementacao
            //dessa abstracao.
            Pokemon Charmander = new Pokemon();
        }
    }
}
