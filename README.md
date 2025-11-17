
## Método `Get` de clase `Bible`

Ejemplo en `C#` del método `Get` que devuelve una lista `List<LifeBread>`. Para su uso es necesario usar `Linq` .

### Ejemplo de uso

```csharp

using System.Linq;

var bibliaRV1960= RV1960.Bible.Get(); // Lista completa

string verso = bibliaRV1960.Where(s => s.Book == "Juan" 
                                    && s.Chapter==3
                                    && s.Verse==16).First().Text;

Console.WriteLine($"{verso}");



foreach (var item in bibliaRV1960.Where(s => s.Book == "Salmos" && s.Chapter == 23))
{
    Console.WriteLine($"{item.Text}");
}

```


