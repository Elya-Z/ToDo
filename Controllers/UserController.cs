using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

public class UserController : ApiController
{
    private readonly MyDbContext _context;
    public UserController(MyDbContext context)
    {
        _context = context;
    }

    [System.Web.Http.HttpPost]
    public IHttpActionResult SaveUserData(UserData userData)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // ������� ������ ������������
            var user = new User
            {
                UserName = userData.Name, // ������������ � �����
                Password = userData.Password,
                Gender = userData.Gender
            };

            // ��������� ������������ � ��
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok();
        }
        catch (System.Exception ex)
        {
            return InternalServerError(ex);
        }
    }
}

public class UserData
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Gender { get; set; }
}
