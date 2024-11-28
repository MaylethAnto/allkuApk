using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllkuApi.Models
{
    public class Paseador
    {
        [Key]
        [Column("cedula_paseador")]
        public string CedulaPaseador { get; set; } = string.Empty;

        [Column("nombre_paseador")]
        public string NombrePaseador { get; set; } = string.Empty;

        [Column("apellido_paseador")]
        public string ApellidoPaseador { get; set; } = string.Empty;

        [Column("direccion_paseador")]
        public string DireccionPaseador { get; set; } = string.Empty;

        [Column("celular_paseador")]
        public string CelularPaseador { get; set; } = string.Empty;

        [Column("correo_paseador")]
        public string CorreoPaseador { get; set; } = string.Empty;

        [ForeignKey("Canino")]
        [Column("id_canino")]
        public int? IdCanino { get; set; }

    }
}