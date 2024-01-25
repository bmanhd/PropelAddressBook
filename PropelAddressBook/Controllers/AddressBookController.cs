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

        [HttpGet]
        public IActionResult GetContacts()
        {
            return Ok(_contactService.GetContacts());
        }

        [HttpPost]
        public IActionResult CreateContact([FromBody] ContactDto newContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var contact = _contactService.CreateContact(newContact);

            if (contact == null)
            {
                return BadRequest("Can not find this contact to create");
            }

            return Ok(contact);
        }

        [HttpPut]
        public IActionResult UpdateContact([FromBody] ContactDto updateContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var contact = _contactService.UpdateContact(updateContact);
            if (contact == null)
            {
                return BadRequest("Can not find this contact to update");
            }

            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var result = _contactService.DeleteContact(id);
            if (result == false)
            {
                return BadRequest("Can not find this contact to delete");
            }

            return Ok("The contact has been deleted");
        }
    }
}