class Program
{
    static void Main()
    {
        //IF
        double temperatura = 22.5;
        if (temperatura < 18.0)
        {
            Console.WriteLine("Está FRIO!");
        }
        else
        {
            Console.WriteLine("Está QUENTE!");
        }

        //notas
        int notas = 7;
        int faltas = 5;
        if (notas >= 6 && faltas < 10)
        {
            Console.WriteLine("APROVADO!");
        }
        else
        {
            Console.WriteLine("REPROVADO!");
            if (notas >= 6)
            {
                Console.WriteLine("por nota");
            }
            if (faltas >= 10)
            {
                Console.WriteLine("por faltas");
            }
        }

        /**
         * 6 RUIM
         * 6 - 7 REGULAR
         * 7 - 8 BOM
         * 8 - 9 ÓTIMO
         * 9 - 10 EXCELENTE
         */
        notas = 7;
        if (notas <= 6)
        {
            Console.WriteLine("RUIM");
        }
        else if (notas <= 7)
        {
            Console.WriteLine("BOM");
        }
        else if (notas <= 8)
        {
            Console.WriteLine("ÓTIMO");
        }
        else
        {
            Console.WriteLine("EXELENTE");
        }

        //SWITCH
        switch (notas)
        {
            case <= 6:
                Console.WriteLine("RUIM");
                break;
            case <= 7:
                Console.WriteLine("BOM");
                break;
            case <= 8:
                Console.WriteLine("ÓTIMO");
                break;
            default:
                Console.WriteLine("EXCELENTE");
                break;
        }

        //WHILE
        int x = 0;
        while (x <= 10)
        {
            Console.WriteLine(x + " - ");
            x++;
        }

        Console.WriteLine();

        //FOR
        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i + " = ");
        }

        //DO WHILE
        int y = 0;
        do
        {
            Console.WriteLine(y + " = ");
            y++;
        } while (y <= 10);

        //FOREACH
        var lista = new List<string> { "A", "B", "C", "D", "F" };
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i] + " - ");
        }

        Console.WriteLine();

        foreach (var conteudo in lista)
        {
            Console.Write(conteudo + " - ");
        }
    }
}