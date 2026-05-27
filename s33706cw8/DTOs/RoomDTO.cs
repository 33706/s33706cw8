namespace s33706cw8.DTOs;

public class RoomDTO
{
    public string Id { get; set; } = null!;

    public int WardId { get; set; }

    public bool HasTv { get; set; }

    public virtual ICollection<BedDTO> Beds { get; set; } = new List<BedDTO>();

    public virtual WardDTO Ward { get; set; } = null!;
}