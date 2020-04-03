namespace LocalBusinessAPI.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string BusinessName { get; set; }
    public string BusinessType { get; set; }
    public string BusinessAddress { get; set; }
    public string OpeningHour { get; set; }
    public string ClosingHour { get; set; }
  }
}