using Microsoft.AspNetCore.Mvc;

namespace PropelAddressBook.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        public ContactsController()
        {
           
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return Ok();
        }
    }
}