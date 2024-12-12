using DBModel;
using DBModel.Model;
using Microsoft.AspNetCore.Mvc;

namespace Sec21_Proj.Controllers
{
    [Controller]
    [Route("proprietari")]
    public class ControllerProprietari : Controller
    {
        private readonly ILogger<ControllerProprietari> _logger;

        public ControllerProprietari(ILogger<ControllerProprietari> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Proprietario>> GetAll()
        {
            DBRepository repository = new DBRepository();
            return Ok(repository.GetProprietari());
        }

        [HttpPost]
        public ActionResult<bool> Load([FromBody]byte[] file)
        {
            DBRepository repository = new DBRepository();
            return Ok(repository.LoadFile<Proprietario>(file));
        }
    }
}
