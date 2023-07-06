using Microsoft.AspNetCore.Mvc;
using Ejemplo.Modelos;

namespace Ejemplo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public string mensaje([FromBody] Mensaje mensaje)
        {
            Mensaje algo = new Mensaje(mensaje.Nombre, mensaje.Edad);

            Persona persona = new Persona()
            {
                Edad = 18,
                Nombre = "Uriel",
                Direccion = "Calle de la amargura"

            };
            var uno = persona.GetEdadMeses;
            var dos = persona.Direccion;

            PersonaPuesto personaPuesto = new PersonaPuesto();

            personaPuesto.GetEdadMeses();
            var tres = personaPuesto.Sueldo;

            return String.Format($"Hola mi nombre es {mensaje.Nombre} y tengo {mensaje.Edad} años");

            Animal animal = new Animal()
            {
                Especie = "Mamífero",
                Habitat = "Hogares comunes"
            };

            Perro perro = new Perro()
            {
                Raza = "Labrador"
            };

            var especieAnimal = animal.Especie;
            var habitatAnimal = animal.Habitat;
            var raza = perro.Raza;

            return $"Es un {especieAnimal} y vive en el hábitat {habitatAnimal}. Su raza es {raza}.";

        }
    }
}