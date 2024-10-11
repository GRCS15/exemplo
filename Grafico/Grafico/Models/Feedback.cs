using System.ComponentModel.DataAnnotations;

namespace Grafico.Models
{
    public class Feedback
    {
        [Key]
        public Guid Feedback_Id { get; set; }
        public string Comentario { get; set; }
        [Range (1, 5)]
        public int Nota { get; set; }
        public DateTime Data { get; set; }
    }
}
