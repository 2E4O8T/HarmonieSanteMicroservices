namespace RendezvousService.Models
{
    public class Rendezvous
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int PraticienId { get; set; }
        public DateTime DateRendezvous { get; set; }
    }
}
