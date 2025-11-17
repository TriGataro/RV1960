namespace RV1960;
public record LifeBread
{
    /// <summary>
    /// Nro. de versículo
    /// </summary>
    public int Index { get; set; }
    /// <summary>
    /// Nombre de libro 
    /// </summary>
    public string Book { get; set; }
    /// <summary>
    /// Indica si es nuevo o antiguo testamento
    /// </summary>
    public string Testament { get; set; }
    /// <summary>
    /// Nro. de libro
    /// </summary>
    public int BoookNumber { get; set; }
    /// <summary>
    /// Nro. del versículo dentro del libro
    /// </summary>
    public int Verse { get; set; }
    /// <summary>
    /// Nro. de capitulo
    /// </summary>
    public int Chapter { get; set; }
    /// <summary>
    /// texto biblico
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Titulo del capitulo
    /// </summary>
    public string Title { get; set; }     
}
