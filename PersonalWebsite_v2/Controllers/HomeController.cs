using Microsoft.AspNetCore.Mvc;
using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Models.ViewModels;
using System.Diagnostics;

namespace PersonalWebsite_v2.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IRepositoryManager _repository;
		public HomeController(ILogger<HomeController> logger, IRepositoryManager repository)
		{
			_logger = logger;
			_repository = repository;
		}

		public IActionResult Index()
		{
			var personalInfo = _repository.PersonalInfos.GetPersonalInfo(trackChanges: false);
			var specialities = _repository.Specialities.GetSpecialities(trackChanges: false);
			var fact = _repository.Facts.GetFacts(trackChanges: false);
			var skills = _repository.Skills.GetSkills(trackChanges: false);
			var musics = _repository.Musics.GetMusics(trackChanges: false);

			
			var vm = new IndexVM
			{
				PersonalInfo = new PersonalInfo
				{
					AboutMe = personalInfo.AboutMe,
					Age = personalInfo.Age,
					BirthDay = personalInfo.BirthDay,
					CityOfResidence = personalInfo.CityOfResidence,
					Degree = personalInfo.Degree,
					Email = personalInfo.Email,
					Github = personalInfo.Github,
					Instagram = personalInfo.Instagram,
					IsFreeLance = personalInfo.IsFreeLance,
					Linkdin = personalInfo.Linkdin,
					Name = personalInfo.Name,
					Phone = personalInfo.Phone,
					Telegram = personalInfo.Telegram,
					WhatsApp = personalInfo.WhatsApp
				},
				Specialties = specialities,
				Fact = new Fact
				{
					HappyClient = fact.HappyClient,
					Awards = fact.Awards,
					HoursOfSupport = fact.HoursOfSupport,
					Projects = fact.Projects
				},
				Skills = skills,
				Musics = musics
			};

			return View(vm);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}