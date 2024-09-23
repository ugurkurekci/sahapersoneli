using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Position
{

    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

}