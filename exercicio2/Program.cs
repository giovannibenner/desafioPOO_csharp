using System.Collections.Generic;
using exercicio2;

Autor a = new Autor();
a.Nome = "Giovanni";
Autor b = new Autor();
b.Nome = "Mateus";
Autor c = new Autor();
c.Nome = "Andre";

Livro l = new Livro();
l.autores.Add(a);
l.autores.Add(b);
l.autores.Add(c);

foreach(var autor in l.autores)
    Console.WriteLine(autor.Nome);