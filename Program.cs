using andar_e_pular_console;

Player player = new Player("p","q");
Cenario cenario = new Cenario("_", 100);
ConsoleKey tecla;

cenario.Imprime(player);

do {
    tecla = Console.ReadKey().Key;

    switch( tecla )
    {
        case ConsoleKey.A:
            player.Anda(false, cenario.Tamanho);
            cenario.Imprime(player);
            break;
        case ConsoleKey.D:
            player.Anda(true, cenario.Tamanho);
            cenario.Imprime(player);
            break;
        case ConsoleKey.W:
            player.Pulando = true;
            cenario.Imprime(player);
            player.Pula();
            player.Pulando = false;
            cenario.Imprime(player);
            break;
        default:
            cenario.Imprime(player);
            break;
    }
}while(tecla != ConsoleKey.Escape);
