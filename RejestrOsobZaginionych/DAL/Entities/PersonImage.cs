namespace RejestrOsobZaginionych.DAL.Entities;

public class PersonImage
{
    public int Id { get; set; }
    public byte[] File { get; set; }
    public string Type { get; set; }
}