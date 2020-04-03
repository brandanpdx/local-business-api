using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessAPI.Models;

namespace LocalBusinessAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private LocalBusinessAPIContext _db;

    public BusinessesController(LocalBusinessAPIContext db)
    {
      _db = db;
    }

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get()
    {
      return _db.Businesses.ToList();
    }

    // POST api/businesses
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/businesses/1
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }
  }
}