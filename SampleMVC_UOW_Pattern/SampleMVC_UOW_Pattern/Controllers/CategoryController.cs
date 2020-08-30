using SampleMVC_UOW_Pattern.Models;
using SampleMVC_UOW_Pattern.Service.Repository;
using System.Web.Mvc;

namespace SampleMVC_UOW_Pattern.Controllers
{
    public class CategoryController : Controller
    {
        IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index(int page, int pageSize)
        {
            int total = 0;
            var ls = _unitOfWork.CategoryRepository.GetAllData(page, pageSize, ref total);
            return View(ls);
        }

        [HttpPost]
        public ActionResult CreateUpdate(CategoryViewModel model)
        {

            //Automapper convert CategoryViewModel -> Category
            //_unitOfWork.CategoryRepository.CreateUpdate(obj);

            return View();
        }
    }
}