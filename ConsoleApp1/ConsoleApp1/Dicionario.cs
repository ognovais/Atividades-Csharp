namespace ConsoleApp1
{
    internal class Dicionario
    {
        static void Main(string[] args)
        {
            Palavra p1 = new("Camarada");
            Significado s1 = new Significado("Pessoa legal", p1);
            Significado s2 = new("Amigo", p1);
            Significado s3 = new("Parceiro", p1);
            p1.AdicionarSignificado(s1);
            p1.AdicionarSignificado(s2);
            p1.AdicionarSignificado(s3);

            p1.RecuperarSignificado();

            p1.RemoverSignificado(s3);

            p1.PesquisarSignificado(s1);
            p1.PesquisarSignificado(s2);

            Console.WriteLine(p1);

        }
    }
}
