using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportAPI.Application.Repositories;
using SportAPI.Application.ViewModels.Users;
using SportAPI.Domain.Entities;
using System.Net;

namespace SportAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly private IUserReadRepository _userReadRepository;
        readonly private IUserWriteRepository _userWriteRepository;
        readonly private ICategoryWriteRepository _categoryWriteRepository;

        public UserController(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, ICategoryWriteRepository categoryWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
            _categoryWriteRepository = categoryWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_userReadRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userReadRepository.GetByIdAsync(id,false));
        }
        [HttpPost]
        public async Task<IActionResult> Create(VM_Create_User model)
        {
            await _userWriteRepository.AddAsync(new()
            {
                Name=model.Name,
                Surname=model.Surname,
                UserName=model.UserName,
                Email=model.Email,
                Password=model.Password,
                PhoneNumber=model.PhoneNumber,
                IsApproved=false
            });
            await _userWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpPut]
        public async Task<IActionResult> Update(VM_Update_User model)
        {
            User user = await _userReadRepository.GetByIdAsync(model.Id);
            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            user.UserName=model.UserName;
            await _userWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userWriteRepository.RemoveAsync(id);
            await _userWriteRepository.SaveAsync();
            return Ok();
        }
    }
}
