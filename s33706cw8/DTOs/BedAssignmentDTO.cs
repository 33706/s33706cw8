namespace s33706cw8.DTOs;

public class BedAssignmentDTO
{
    public int Id { get; set; }

    public string PatientPesel { get; set; } = null!;

    public int BedId { get; set; }

    public DateTime From { get; set; }

    public DateTime? To { get; set; }

    public virtual BedDTO Bed { get; set; } = null!;

    public virtual PatientDTO PatientPeselNavigation { get; set; } = null!;
}