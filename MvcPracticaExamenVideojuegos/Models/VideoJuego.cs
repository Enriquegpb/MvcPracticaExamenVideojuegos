using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPracticaExamenVideojuegos.Models
{
	[Table("VIDEOJUEGOS")]
	public class VideoJuego
	{
		[Key]
		[Column("IDVIDEOJUEGO")]
		public int IdVideojuego { get; set; }
		[Column("NOMBRE")]
		public string Nombre { get; set; }
		[Column("PRECIO")]
		public int Precio { get; set; }
		[Column("IMAGEN")]
		public string Imagen { get; set; }
	}
}
