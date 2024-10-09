using DevJobs.API.Entities;
using DevJobs.API.Models;
using DevJobs.API.Persistence;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DevJobs.API.Controllers
{
    [Route("api/job-vacancies/{id}/applications")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private readonly DevJobsContext _context;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="context"></param>
        public JobApplicationsController(DevJobsContext context)
            => _context = context;

        // POST: api/job-vacancies/{id}/applications
        /// <summary>
        /// Cadastro do Candidato
        /// </summary>
        /// <remarks>
        /// Requisição:
        /// {
        ///     "applicantName": "Samuel",
        ///     "applicantEmail": "samuel@teste",
        ///     "idJobVacancy": 1
        /// }
        /// </remarks>
        /// <param name="id">ID da Vaga</param>
        /// <param name="model">Dados do Candidato</param>
        /// <response code="204">Sucesso</response>
        /// <response code="400">Dados inválidos</response>
        /// <response code="404">Não encontrado</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Post(int id, AddJobApplicationInputModel model)
        {
            Log.Information("Endpoint - POST: api/job-vacancies/{id}/applications");

            var jobVacancy = _context.JobVacancies.SingleOrDefault(jv => jv.Id == id);

            if (jobVacancy == null)
                return NotFound();

            var application = new JobApplication(model.ApplicantName, model.ApplicantEmail, id);

            _context.JobApplications.Add(application);
            _context.SaveChanges();

            return NoContent();
        }
    }
}