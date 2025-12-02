# Biblia Reina-Valera 1960

[NuGet](https://www.nuget.org/packages/RV1960/) de la biblia desde el Génesis hasta el Apocalipsis con 31002 versículos, en español.

## Método `Get` de clase `Bible`

Ejemplo en `C#` del método `Get` que devuelve una lista `List<LifeBread>`. Para su uso es necesario usar `Linq` .

### Ejemplo de uso

```csharp

using System.Linq;
using RV1960;

var bibliaRV1960 = Bible.Get(); // Lista completa de versículos

var libros = bibliaRV1960.GroupBy(x => x.Book).Select(g => new { Libro = g.Key }).ToList();

//Lista de libros de la Biblia
foreach (var item in libros)
{
    Console.WriteLine(item.Libro);
}

//Búsqueda de un versículo específico
var verso = bibliaRV1960.Where(s => s.Book == "Juan"
                                    && s.Chapter == 3
                                    && s.Verse == 16).First();

Console.WriteLine($"\n{verso.Text}\n{verso.Footer}\n");


//Lista de versículos de un capítulo específico
foreach (var item in bibliaRV1960.Where(s => s.Book == "Salmos" && s.Chapter == 23))
{
    Console.WriteLine($"{item.Text}");
}

//Lista de 10 versículos aleatorios
Random random = new Random();
var randomVerses = bibliaRV1960.OrderBy(v => random.Next()).Take(10);

foreach (var item in randomVerses)
{
    Console.WriteLine($"\n{item.Text}\n{item.Footer} " );
}

```
Espero que esta librería sea de edificación y de bendición para ustedes.
Gracia y Paz a vosotros.

