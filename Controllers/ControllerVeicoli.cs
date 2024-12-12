using DBModel.Model;
using DBModel;
using Microsoft.AspNetCore.Mvc;

namespace Sec21_Proj.Controllers
{
    [Controller]
    [Route("veicoli")]
    public class ControllerVeicoli : Controller
    {
        private readonly ILogger<ControllerVeicoli> _logger;

        public ControllerVeicoli(ILogger<ControllerVeicoli> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Veicolo>> GetAll()
        {
            DBRepository repository = new DBRepository();
            return Ok(repository.GetVeicoli());
        }

        [HttpPost]
        public ActionResult<bool> Load(byte[] file)
        {
            DBRepository repository = new DBRepository();
            return Ok(repository.LoadFile<Veicolo>(file));
        }
    }
}
