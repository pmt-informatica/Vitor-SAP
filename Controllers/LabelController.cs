using System;
using Microsoft.AspNetCore.Mvc;
using Vitor;

namespace MyWinFormsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {

        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            Program.form.Invoke(new Action(() =>
            {

                Program.form._resultado = Convert.ToInt32(Program.form._resultado) + Convert.ToInt32(id);
                Program.form.lblLigado.Text = id;

            }));
            return Ok("O resultado neste momento é "+Program.form._resultado);
        }
    }
}