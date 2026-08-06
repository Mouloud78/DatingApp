namespace API.Entities;

public class AppUser
{
  public string Id { get; set; } = Guid.NewGuid().ToString();
  public required string DisplaName { get; set; }
  public required string Email { get; set; }
}
