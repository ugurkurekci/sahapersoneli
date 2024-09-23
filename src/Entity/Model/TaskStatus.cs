using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class TaskStatus
{

    [Key]
    public int Id { get; set; }

    public string Description { get; set; }

}