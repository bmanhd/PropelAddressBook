using Microsoft.AspNetCore.Mvc;
using PropelAddressBook.Dtos;
using PropelAddressBook.Services;

namespace PropelAddressBook.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ContactsController(IContactService contactService) : ControllerBase
    {
        public readonly IContactService _contactService = contactService;

        [HttpGet("{id}")]
        public IActionResult ContactById(int id)
        {
            var contact = _contactService.GetContactById(id);

            if (contact == null)
                return BadRequest("Cannot find this contact");

            return Ok(contact);
        }
    }
}