using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Task
{

    [Key]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public int StatusId { get; set; }

}