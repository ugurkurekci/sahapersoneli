using System.ComponentModel.DataAnnotations;

namespace Entity.Model;

public class Employee
{

    [Key]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int PositionId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string Address { get; set; }

    public DateTime HireDate { get; set; }  // İşe başlama tarihi

    public DateTime? FireDate { get; set; }  // İşten çıkış tarihi

    public DateTime? LastLogin { get; set; }

    public bool IsActive { get; set; }

}