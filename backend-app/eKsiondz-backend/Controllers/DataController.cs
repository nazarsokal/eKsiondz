using System.Text.Json;
using eKsiondz_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace eKsiondz_backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataController : Controller
{
    [HttpGet] // type of http request to handle
    public IActionResult GetData() => Ok(new { Message = $"Hello from the server!"});
    
    [HttpGet("person/{id}")]
    public IActionResult GetPersonId(int id)
    {
        Dictionary<int, Person> people = new Dictionary<int, Person>();
        people.Add(1, new Person() {Name = "John Doe", Age = 10, Gender = "Male"});
        people.Add(2, new Person() {Name = "Slavko", Age = 20, Gender = "Female"});
        people.Add(3, new Person() {Name = "Golyb", Age = 30, Gender = "Non-binary"});
        people.Add(4, new Person() {Name = "Artemko", Age = 15, Gender = "Male"});
        people.Add(5, new Person() {Name = "Vorona", Age = 24, Gender = "Female"});
        
        var personSelected = people.Where(p => p.Key == id).Select(p => p.Value);
        var json = JsonSerializer.Serialize(personSelected);
        
        return StatusCode(201, json);
    }
}