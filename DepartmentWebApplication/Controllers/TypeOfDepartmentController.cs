using DepartmentWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(DepartmentDB.TypeOfDepartmentcs.First((item) => item.Id == id));
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
        public IHttpActionResult Post([FromBody] TypeOfDepartmentcs value)
        {
            try
            {
                DepartmentDB.TypeOfDepartmentcs.Add(value);
                DepartmentDB.SaveChanges();
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
        public IHttpActionResult Put(int id, [FromBody] TypeOfDepartmentcs value)
        {
            try
            {
                TypeOfDepartmentcs typeOfDepartmentcsFound = DepartmentDB.TypeOfDepartmentcs.First(item => item.Id == id);
                typeOfDepartmentcsFound.Id = value.Id;
                typeOfDepartmentcsFound.NameOfDepartment = value.NameOfDepartment;
                typeOfDepartmentcsFound.TypeOfWork = value.TypeOfWork;
                typeOfDepartmentcsFound.NumberOfEmployee = value.NumberOfEmployee;
                DepartmentDB.SaveChanges();
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
        public IHttpActionResult Delete(int id)
        {
            try
            {
                DepartmentDB.TypeOfDepartmentcs.Remove(DepartmentDB.TypeOfDepartmentcs.First((item) => item.Id == id));

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
