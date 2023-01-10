using Microsoft.AspNetCore.Mvc;
using PersonalWebsite_v2.Contracts;
using PersonalWebsite_v2.Models;
using PersonalWebsite_v2.Models.ViewModels;

namespace PersonalWebsite_v2.Controllers
{
	public class AdminController : Controller
	{
		private readonly IRepositoryManager _repositoryManager;

		public AdminController(IWebHostEnvironment webHostEnvironment, IRepositoryManager repositoryManager)
		{
			_repositoryManager = repositoryManager;
		}


		public IActionResult Index()
		{
			return View();
		}

		#region " Informations "

		[HttpGet]
		public IActionResult Informations()
		{
			var myInfo = _repositoryManager.PersonalInfos.GetPersonalInfo(trackChanges: false);
			if (myInfo == null)
			{
				return View("Informations");
			}

			var vm = new PersonalInfo
			{
				Name = myInfo.Name,
				AboutMe = myInfo.AboutMe,
				Age = myInfo.Age,
				BirthDay = myInfo.BirthDay,
				CityOfResidence = myInfo.CityOfResidence,
				Degree = myInfo.Degree,
				Email = myInfo.Email,
				Github = myInfo.Github,
				Instagram = myInfo.Instagram,
				IsFreeLance = myInfo.IsFreeLance,
				Linkdin = myInfo.Linkdin,
				Phone = myInfo.Phone,
				Telegram = myInfo.Telegram,
				WhatsApp = myInfo.WhatsApp
			};

			return View("Informations", vm);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Informations(PersonalInfoVM info)
		{
			var myInfo = _repositoryManager.PersonalInfos.GetPersonalInfo(trackChanges: false);
			PersonalInfo model = new PersonalInfo
			{
				Id = myInfo.Id,
				AboutMe = info.AboutMe,
				Age = info.Age,
				BirthDay = info.BirthDay,
				CityOfResidence = info.CityOfResidence,
				Degree = info.Degree,
				Email = info.Email,
				Github = info.Github,
				Instagram = info.Instagram,
				IsFreeLance = info.IsFreeLance,
				Linkdin = info.Linkdin,
				Name = info.Name,
				Phone = info.Phone,
				Telegram = info.Telegram,
				WhatsApp = info.WhatsApp
			};
			_repositoryManager.PersonalInfos.UpdatePersonalInfo(model);
			_repositoryManager.Save();

			return RedirectToAction("Informations");

		}

		#endregion

		#region " Facts "

		[HttpGet]
		public IActionResult Facts()
		{
			var facts = _repositoryManager.Facts.GetFacts(trackChanges: false);

			var vm = new Fact
			{
				Awards = facts.Awards,
				HappyClient = facts.HappyClient,
				HoursOfSupport = facts.HoursOfSupport,
				Projects = facts.Projects
			};

			return View("Facts" , vm);
		}


		[HttpPost]
		public IActionResult Facts(FactVM fact)
		{
			var facts = _repositoryManager.Facts.GetFacts(trackChanges: false);

			var model = new Fact
			{
				Id = facts.Id,
				HappyClient = fact.HappyClient,
				HoursOfSupport = fact.HoursOfSupport,
				Projects = fact.Projects,
				Awards = fact.Awards
			};
			_repositoryManager.Facts.UpdateFacts(model);
			_repositoryManager.Save();

			return RedirectToAction("Facts");
		}

		#endregion

		#region " Skills "

		[HttpGet]
		public IActionResult Skills()
		{
			var skillList = _repositoryManager.Skills.GetSkills(trackChanges: false);

			var vm = new List<Skill>();
			foreach (var item in skillList)
			{
				Skill skill = new Skill();
				skill.Name = item.Name;
				skill.Percent = item.Percent;
				vm.Add(skill);
			}

			return View("Skills" , vm);
		}


		[HttpGet]
		public IActionResult Skill(Guid id)
		{
			var skill = _repositoryManager.Skills.GetSkills(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();

			if (skill != null)
			{
				var vm = new SkillVM
				{
					Name = skill.Name,
					Percent = skill.Percent,
				};
				return View("Skill", vm);
			}

			return RedirectToAction("Skills");
		}

		[HttpPost]
		public IActionResult Skill(SkillVM vm)
		{
			if (vm.Id == Guid.Empty)
			{
				Skill skill = new Skill
				{
					Name = vm.Name,
					Percent = vm.Percent,
				};
				_repositoryManager.Skills.AddSkill(skill);
				_repositoryManager.Save();
				return RedirectToAction("Skills");
			}
			else
			{
				var skill = _repositoryManager.Skills.GetSkills(trackChanges:false).Where(s => s.Id == vm.Id).SingleOrDefault();

				if (skill != null)
				{
					skill.Percent = vm.Percent;
					skill.Name = vm.Name;

					_repositoryManager.Skills.UpdateSkill(skill);
					_repositoryManager.Save();
					return RedirectToAction("Skills");
				}
				return View("Skill" ,vm);
			}
		}

		public IActionResult DeleteSkill(Guid id)
		{
			var skill = _repositoryManager.Skills.GetSkills(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();
			if (skill != null)
			{
				_repositoryManager.Skills.DeleteSkill(skill);
				_repositoryManager.Save();
			}		

			return RedirectToAction("Skills");
		}

		#endregion

		#region " Specialities "

		[HttpGet]
		public IActionResult Specialities()
		{
			var specialities = _repositoryManager.Specialities.GetSpecialities(trackChanges: false);

			return View("Specialities", specialities);
		}

		[HttpGet]
		public IActionResult Speciality(Guid id)
		{
			var speciality = _repositoryManager.Specialities.GetSpecialities(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();
			if (speciality != null)
			{
				return View("Speciality", speciality);
			}
			return RedirectToAction("Specialities");
		}

		[HttpPost]
		public IActionResult Speciality(SpecialityVM vm)
		{
			if (vm.Id == Guid.Empty)
			{
				Speciality speciality = new Speciality
				{
					Name = vm.Name
				};
				_repositoryManager.Specialities.AddSpecialty(speciality);
				_repositoryManager.Save();

				return RedirectToAction("Specialities");
			}
			else
			{
				var speciality = _repositoryManager.Specialities.GetSpecialities(trackChanges: false).Where(s => s.Id == vm.Id).SingleOrDefault();
				if (speciality != null)
				{
					speciality.Name = vm.Name;
					_repositoryManager.Specialities.UpdateSpecialty(speciality);
					_repositoryManager.Save();
					return RedirectToAction("Specialities");
				}
				return View("Speciality", vm);
			}
		}

		public IActionResult DeleteSpeciality(Guid id)
		{
			var speciality = _repositoryManager.Specialities.GetSpecialities(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();
			if (speciality != null)
			{
				_repositoryManager.Specialities.DeleteSpecialty(speciality);
				_repositoryManager.Save();
			}
			return RedirectToAction("Specialities");
		}

		#endregion

		#region " Musics "

		[HttpGet]
		public IActionResult Musics()
		{
			var musics = _repositoryManager.Musics.GetMusics(trackChanges: false);

			return View("Musics", musics);
		}

		[HttpGet]
		public IActionResult Music(Guid id)
		{
			var music = _repositoryManager.Musics.GetMusics(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();
			if (music != null)
			{
				return View("Music", music);
			}
			return RedirectToAction("Musics");
		}

		[HttpPost]
		public IActionResult Music(MusicVM vm)
		{
			if (vm.Id == Guid.Empty)
			{
				Music music = new Music
				{
					Link = vm.Link,
					Name = vm.Name
				};
				_repositoryManager.Musics.AddMusic(music);
				_repositoryManager.Save();

				return RedirectToAction("Musics");
			}
			else
			{
				var music = _repositoryManager.Musics.GetMusics(trackChanges: false).Where(s => s.Id == vm.Id).SingleOrDefault();
				if (music != null)
				{
					music.Name = vm.Name;
					music.Link = vm.Link;
					_repositoryManager.Musics.UpdateMusic(music);
					_repositoryManager.Save();

					return RedirectToAction("Musics");
				}

				return View("Music", vm);
			}
		}

		public IActionResult DeleteMusic(Guid id)
		{
			var music = _repositoryManager.Musics.GetMusics(trackChanges: false).Where(s => s.Id == id).SingleOrDefault();
			if (music != null)
			{
				_repositoryManager.Musics.DeleteMusic(music);
			}
			return RedirectToAction("Musics");
		}

		#endregion

	}
}
