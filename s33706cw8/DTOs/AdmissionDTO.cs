namespace s33706cw8.DTOs;

public class AdmissionDTO
{
    public int Id { get; set; }

    public DateTime AdmissionDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string PatientPesel { get; set; } = null!;

    public int WardId { get; set; }

    public virtual PatientDTO PatientPeselNavigation { get; set; } = null!;

    public virtual WardDTO Ward { get; set; } = null!;
}