using System;
using System.Collections.Generic;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Controller

 
namespace backend.Controllers
{
    
	[ApiController]
    [Route("api/[controller]")]
    public class TestValueController : ControllerBase
    {
    static List<TestValue> testValues = new List<TestValue>();
    BackendRepository repo = new BackendRepository();

    [HttpGet("values")]
    public ActionResult<List<TestValue>> GetAll()
    //public List<TestValue> GetAll()
    {
        //return testValues;
        return repo.GetAllValues();
    }
    
    [HttpPost("value")]
    public int Post([FromBody] TestValue newValue)
    {
    if (newValue != null)
    {
    return repo.AddValue(newValue);
    }
    return -1;
    }
    
    [HttpPut("{id}")]
    public int Put(int id, [FromBody] TestValue valueToUpdate)
    {
    return repo.UpdateValue(id, valueToUpdate);
    }
    
    [HttpDelete("{id}")]
    public bool Delete(int id)
    {
    bool isDeleteSuccessful = false;
    try
    {
    repo.DeleteValue(id);
    isDeleteSuccessful = true;
    }
    catch (System.Exception ex)
    {
    Console.WriteLine(ex);
    }
    return isDeleteSuccessful;
    }
    }
}