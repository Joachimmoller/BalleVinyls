namespace BalleVinyls.Models;

public class Artist
{
    [Key] public int id { get; set; }
    [StringLength(50)] public string name { get; set; }
    public DateTime formed { get; set; }
    public DateTime? ended { get; set; }
    public ICollection<Album> Albums { get; set; }
}