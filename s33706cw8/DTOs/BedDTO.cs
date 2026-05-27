namespace s33706cw8.DTOs;

public class BedDTO
{
    public int Id { get; set; }

    public string RoomId { get; set; } = null!;

    public int BedTypeId { get; set; }

    public virtual ICollection<BedAssignmentDTO> BedAssignments { get; set; } = new List<BedAssignmentDTO>();

    public virtual BedTypeDTO BedType { get; set; } = null!;

    public virtual RoomDTO Room { get; set; } = null!;
}