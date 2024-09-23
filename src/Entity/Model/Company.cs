using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Company
{

    [Key]
    public int Id { get; set; }

    public int CityId { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

}