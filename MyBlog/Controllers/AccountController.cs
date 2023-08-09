using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController
{
    [HttpGet]
    public IActionResult Get()
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    public ActionResult<UserModel> Create(UserModel model)
    {
        throw new NotImplementedException();
    }
    
    [HttpPatch]
    public ActionResult<UserModel> Update(UserModel model)
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete]
    public IActionResult Delete()
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    public ActionResult<AuthToken> GetToken(int id)
    {
        throw new NotImplementedException();
    }
}