using AllkuApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AllkuApi.Models
{
    public class Receta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_receta { get; set; }
        public string? nombre_receta { get; set; }
        public string? descripcion_receta { get; set; }
        public byte[]? foto_receta { get; set; }
        public int? id_canino { get; set; }

        [ForeignKey("id_canino")]
        public virtual Canino? Canino { get; set; }
    }
}