using DepartmentWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DepartmentWebApplication.Controllers
{
    public class TypeOfDepartmentController : ApiController
    {
        Department DepartmentDB = new Department();
        // GET: api/TypeOfDepartment
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(DepartmentDB.TypeOfDepartmentcs.ToList());
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/TypeOfDepartment/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                return Ok(await DepartmentDB.TypeOfDepartmentcs.FindAsync(id));
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/TypeOfDepartment
        public async Task<IHttpActionResult> Post([FromBody] TypeOfDepartmentcs value)
        {
            try
            {
                DepartmentDB.TypeOfDepartmentcs.Add(value);
               await DepartmentDB.SaveChangesAsync();
                return Ok("item was ADD");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/TypeOfDepartment/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] TypeOfDepartmentcs value)
        {
            try
            {
                TypeOfDepartmentcs typeOfDepartmentcsFound = await DepartmentDB.TypeOfDepartmentcs.FindAsync(id);
                typeOfDepartmentcsFound.Id = value.Id;
                typeOfDepartmentcsFound.NameOfDepartment = value.NameOfDepartment;
                typeOfDepartmentcsFound.TypeOfWork = value.TypeOfWork;
                typeOfDepartmentcsFound.NumberOfEmployee = value.NumberOfEmployee;
                await DepartmentDB.SaveChangesAsync();
                return Ok("itam was update");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // DELETE: api/TypeOfDepartment/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                DepartmentDB.TypeOfDepartmentcs.Remove(await DepartmentDB.TypeOfDepartmentcs.FindAsync(id));
               
                return Ok("item was deleted");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
