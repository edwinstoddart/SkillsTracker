using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        // GET: /skills/
        [HttpGet]
        public IActionResult Index()
        {
            string html = $"<h1>Skill Tracker</h1>" +
                "<h2>Coding Skills To Learn:</h2>" +
                "<ol>" +
                    "<li>JavaScript</li>" +
                    "<li>C#</li>" +
                    "<li>Ruby</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        // GET: /skills/form
        [HttpGet("form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='completedForm'>" +
                "<h2>Current Date:<input type='date' name='entryDate'></h2>" +
                "<h2><select name='javaScript'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select> JavaScript</h2>" +
                "<h2><select name='cSharp'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select> C#</h2>" +
                "<h2><select name='ruby'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select> Ruby</h2>" +
                "<input type='submit' value='Submit Form'/></form>";
            return Content(html, "text/html");
        }

        // POST: skills/completedForm
        [HttpGet("testForm/{entryDate?}/{javaScript?}/{cSharp?}/{ruby?}")]
        [HttpPost("completedForm")]
        public IActionResult CompleteForm(string entryDate = "Entry Date", string javaScript = "Beginner", string cSharp = "Beginner", string ruby = "Beginner")
        {
            string html = $"<h1>{entryDate}</h1>" +
                "<table><tr>" +
                    "<th>Skill Name &nbsp</th>" +
                    "<th>Skill Level</th>" +
                "</tr> <tr>" +
                    "<td>JavaScript</td>" +
                    $"<td>{javaScript}</td>" +
                "</tr> <tr>" +
                    "<td>C#</td>" +
                    $"<td>{cSharp}</td>" +
                "</tr> <tr>" +
                    "<td>Ruby</td>" +
                    $"<td>{ruby}</td>" +
                "</tr></table>";
            return Content(html, "text/html");
        }
    }
}
