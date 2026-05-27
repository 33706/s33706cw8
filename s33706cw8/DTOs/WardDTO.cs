namespace s33706cw8.DTOs;

public class WardDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<AdmissionDTO> Admissions { get; set; } = new List<AdmissionDTO>();

    public virtual ICollection<RoomDTO> Rooms { get; set; } = new List<RoomDTO>();
}