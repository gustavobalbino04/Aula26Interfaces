using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1,"PS2", 275.50f);
            Produto p2 = new Produto(2,"PS3",850.99f);
            Produto p3 = new Produto(3,"PS4",1999.90f);
            Produto p4 = new Produto(4,"PS5",50000f);

            Carrinho carrinho = new Carrinho();
            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Cadastrar(p4);

            carrinho.Deletar(p4);

            

            carrinho.Listar();



        }
    }
}
