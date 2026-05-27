namespace s33706cw8.DTOs;

public class PatientDTO
{
    public string Pesel { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int Age { get; set; }

    public bool Sex { get; set; }

    public virtual ICollection<AdmissionDTO> Admissions { get; set; } = new List<AdmissionDTO>();

    public virtual ICollection<BedAssignmentDTO> BedAssignments { get; set; } = new List<BedAssignmentDTO>();
}