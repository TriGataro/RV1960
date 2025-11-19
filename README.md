# Biblia Reina-Valera 1960

[NuGet](https://www.nuget.org/packages/RV1960/) de la biblia desde el Génesis hasta el Apocalipsis con 31002 versículos, en español.

## Método `Get` de clase `Bible`

Ejemplo en `C#` del método `Get` que devuelve una lista `List<LifeBread>`. Para su uso es necesario usar `Linq` .

### Ejemplo de uso

```csharp

using System.Linq;

var bibliaRV1960 = RV1960.Bible.Get(); // Lista completa de versículos

var libros = bibliaRV1960.GroupBy(x => x.Book).Select(g => new { Libro = g.Key }).ToList();

foreach (var item in libros)
{
    Console.WriteLine(item.Libro);
}

string verso = bibliaRV1960.Where(s => s.Book == "Juan"
                                    && s.Chapter == 3
                                    && s.Verse == 16).First().Text;

Console.WriteLine($"\n{verso}\n");


foreach (var item in bibliaRV1960.Where(s => s.Book == "Salmos" && s.Chapter == 23))
{
    Console.WriteLine($"{item.Text}");
}

```


