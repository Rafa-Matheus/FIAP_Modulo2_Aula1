using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Modulo2_Aula1
{
    public class Livro
    {
        public string Nome;
        public string Resumo;
        public double Valor;
        public int Paginas;
        public string Autor;

        public void ExibirDados()
        {
            String Titulo = "DETALHES DO LIVRO";
            Console.WriteLine(Titulo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Resumo: " + Resumo);
            Console.WriteLine($"Valor: R$ {Valor.ToString("F2")}");
            Console.WriteLine("Páginas: " + Paginas);
        }
    }
}
