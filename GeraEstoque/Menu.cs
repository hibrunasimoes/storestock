﻿
namespace GeraEstoque;

public static class Menu
{
    public static void Mostrar()
    {
        Console.Clear();
        Bordas();
        Opcoes();

        var opcoes = short.Parse(Console.ReadLine());
        switch (opcoes)
        {
            case 1: Cadastro.Start(); break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 0: Console.Clear(); break;
            default: break;
        }
    }

    public static void Bordas()
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        LinhaHoriziontal();
        for (int i = 0; i < 14; i++)
        {
            Console.Write("|");
            for (int line = 0; line <= 35; line++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
        }
        LinhaHoriziontal();
    }
    public static void LinhaHoriziontal()
    {
        Console.Write("+");
        for (int i = 0; i <= 35; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }

    static void Opcoes()
    {
        Console.SetCursorPosition(2, 1);
        System.Console.WriteLine("Seja bem vindo ao GeraEstoque v1.0");
        Console.SetCursorPosition(2, 2);
        System.Console.WriteLine("==================================");

        Console.SetCursorPosition(2, 4);
        System.Console.WriteLine("1 - Cadastrar Produto");

        Console.SetCursorPosition(2, 5);
        System.Console.WriteLine("2 - Consultar Produto");

        Console.SetCursorPosition(2, 6);
        System.Console.WriteLine("3 - Modificar Produto");

        Console.SetCursorPosition(2, 7);
        System.Console.WriteLine("4 - Excluir Produto");

        Console.SetCursorPosition(2, 8);
        System.Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(2, 10);
        System.Console.Write("Digite a opção: ");
    }
}