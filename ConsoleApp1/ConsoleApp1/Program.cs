using ConsoleApp1;

clsRepositorioEventHandler repo = new clsRepositorioEventHandler();
repo.LeeLinea += (object? _, Argumentos e) => { Console.Write(e.valor.ToString() + " "); };

void MuestraAvance(object? sender, Argumentos e)
{
    Console.Write(e.valor.ToString() + " ");
}

repo.ObtenTodos();
