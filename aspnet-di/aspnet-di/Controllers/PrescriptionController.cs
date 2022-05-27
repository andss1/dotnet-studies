using aspnet_di.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_di.Controllers
{
    [Route("api/[controller]")]
    public class PrescriptionController : Controller
    {
        private readonly IPrescription _prescription;

        public PrescriptionController(IPrescription prescription)
        {
            _prescription = prescription;

        }

        [HttpGet]
        public ActionResult Get()
        {
            var prescriptions = _prescription.GetAll();
            if( prescriptions == null )
            {
                return NotFound();
            }
            return Ok(prescriptions);
        }
    }
}
