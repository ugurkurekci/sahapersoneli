namespace Services.Dto;

public class CompanyDto
{

    public int Id { get; set; }

    public int CityId { get; set; }

    public int CategoryId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

}