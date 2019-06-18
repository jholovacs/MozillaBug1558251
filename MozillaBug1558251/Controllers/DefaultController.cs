using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MozillaBug1558251.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet("~/")]
		public IActionResult GetTheFile()
		{
			var file = System.IO.File.OpenRead("Content/1558251.xlsx");
			return File(file, "application/vnd.ms-excel.sheet.macroenabled.12", "MyFile.xlsx");
		}
	}
}
