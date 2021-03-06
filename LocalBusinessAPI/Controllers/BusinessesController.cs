using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessAPI.Models;
using Microsoft.EntityFrameworkCore;

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
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get(string businessname, string businesstype, string openinghour, string closinghour)
    {
      var query = _db.Businesses.AsQueryable();

      if (businessname != null)
      {
        query = query.Where(entry => entry.BusinessName == businessname);
      }

      if (businesstype != null)
      {
        query = query.Where(entry => entry.BusinessType == businesstype);
      }

      if (openinghour != null)
      {
        query = query.Where(entry => entry.OpeningHour == openinghour);
      }

      if (closinghour != null)
      {
        query = query.Where(entry => entry.ClosingHour == closinghour);
      }

      return query.ToList();
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

    // PUT api/businesses/2
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
      business.BusinessId = id;
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/businesses/2
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}