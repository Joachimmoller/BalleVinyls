namespace BalleVinyls.Models;

public class Album
{
    [Key] public int id { get; set; }
    [StringLength(50)] public string title { get; set; }
    public ICollection<Artist> Artists { get; set; }
}
