namespace ClinicApp.DB;

public enum RequestStatus
{
    open,
    closed

}
public class ConsultationRequest
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int ClinicId { get; set; }
    public DateTime Date { get; set; }
    public string PatientName { get; set; }
    public string PatientProtocolNumber { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public RequestStatus Status { get; set; } = RequestStatus.open;
}