using Microsoft.AspNetCore.Mvc;
using MvcPracticaExamenVideojuegos.Models;
using MvcPracticaExamenVideojuegos.Repositories;

namespace MvcPracticaExamenVideojuegos.Controllers
{
	public class VideoJuegosController : Controller
	{
		private RepositoryVideoJuegos repo;
		public VideoJuegosController(RepositoryVideoJuegos repo)
		{
			this.repo = repo;
		}

		public async Task<IActionResult> Index()
		{
			List<VideoJuego> videoJuegos = await this.repo.GetVideoJuegosAsync();
			return View(videoJuegos);
		}
		public async Task<IActionResult> Detalles(int idvideojuego)
		{
			VideoJuego videoJuego = await this.repo.FindVideoJuegoAsync(idvideojuego);
			return View(videoJuego);
		}
		public IActionResult CreateVideojuego()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateVideojuego(VideoJuego videoJuego)
		{
			await this.repo.CreateVideoJuegoAsync(videoJuego.IdVideojuego, videoJuego.Nombre, videoJuego.Precio, videoJuego.Imagen);
			return View();
		}
		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> EditVideojuego(VideoJuego videoJuego)
		{
			await this.repo.CreateVideoJuegoAsync(videoJuego.IdVideojuego, videoJuego.Nombre, videoJuego.Precio, videoJuego.Imagen);
			return View();
		}
		public async Task<IActionResult> DeleteVideojuego(int idvideojuego)
		{
			await this.repo.DeleteVideoJuegoAsync(idvideojuego);
			return View();
		}
	}
}
