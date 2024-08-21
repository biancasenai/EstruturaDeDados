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

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco

        //TRABALHANDO COM FILA
        /* criar uma fila (queue ) */
        Queue<string> filaBanco = new Queue<string>();

        /* adicionar elementos em uma fila */
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco
        foreach (var fila in filaBanco)
        {
            Console.WriteLine(fila);
        }
        bool achou = filaBanco.Contains("Manoel");

        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa NÃo está na fila");
        }

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco



        //TRABALHANDO COM PILA(STACH)
        /*criando uma pilha*/
        Stack<string> Livros = new Stack<string>();

        /*adicionando elementos em uma pila*/
        Livros.Push("Chapéuzinho vermelho");
        Livros.Push("Branca de neve e os setes anões");
        Livros.Push("Princesa e o sapo");

        foreach (var livros in Livros)
        {
            Console.WriteLine(livros);
        }
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco

        /* remove o primeiro elememto da pilha */
        Livros.Pop();
        foreach (var livro in Livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine(); //pula linha em branco
    }
}










