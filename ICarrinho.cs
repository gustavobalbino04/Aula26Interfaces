namespace Aula26Interfaces
{
    public interface ICarrinho
    {
        //a interface e como uma regra de  negócio,facilitando na programação 
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int _codigo,Produto produto);
         void Deletar(Produto produto);
    }
}