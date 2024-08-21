internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA (LIST)
        List<string> frutas = new List<string>();

        // Adicionar itens na Lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        // Imprimir os itens da lista
        Console.WriteLine("Minha Lista de frutas");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* inserir um elemento na posição especifico */
        frutas.Insert(1, "Maracujá");

        // imprimindo a lista novamente 
        Console.WriteLine("Minha Lista de frutas");// pula linha em branco

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        //alterar um elemento no indice especifico
        frutas[4] = "Pêra";
        Console.WriteLine("Minha Lista de frutas");// pula linha em branco

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        // remover elementos da lista no indice especifico
        frutas.RemoveAt(3);
        //remover elementos pelo valor do conteudo
        frutas.Remove("Morango");

        // imprimindo a lista novamente
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("Minha Lista de frutas");// pula linha em branco
        frutas.ForEach(Console.WriteLine);
        {

        }

        //apagar todos os elementos da lista
        frutas.Clear();

        //TRABALHANDO COM DICIONARIO ( DICTIONARY)

        /* criando um dicionario de dados */
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* adicionar dados a um dicionario */
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");


        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco

        Console.WriteLine("Meu dicionario de carros:");
        /* imprimir um dicionario de dados*/
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");


        }

    }
}










