using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class TaskEmployee
{

    [Key]
    public int Id { get; set; }

    public int TaskId { get; set; }

    public int UserId { get; set; }

}