using Microsoft.EntityFrameworkCore;
using MvcPracticaExamenVideojuegos.Models;

namespace MvcPracticaExamenVideojuegos.Data
{
	public class VideoJuegosContext: DbContext
	{
		public VideoJuegosContext(DbContextOptions<VideoJuegosContext>options) : base(options) { }
		public DbSet<VideoJuego> VideoJuegos { get; set; }
	}
}
