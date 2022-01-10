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
    public class EmployeeController : ApiController
    {
      Department DepartmentDB = new Department();
        // GET: api/Employee
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(DepartmentDB.Employee.ToList());
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

        // GET: api/Employee/5
        public IHttpActionResult Get(int id)
        {
         
            try
            {
                return Ok(DepartmentDB.Employee.First((item) => item.Id == id));
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

        // POST: api/Employee
        public IHttpActionResult Post([FromBody]Employee value)
        {
            try
            {
                DepartmentDB.Employee.Add(value);
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

        // PUT: api/Employee/5
        public IHttpActionResult Put(int id, [FromBody]Employee value)
        {
            try
            {

                Employee employeeFound = DepartmentDB.Employee.First((item) => item.Id == id);
                employeeFound.Id=value.Id;
                employeeFound.FullName=value.FullName;
                employeeFound.Age=value.Age;
                employeeFound.Salary=value.Salary;
                employeeFound.TypeOfDepartmentcs=value.TypeOfDepartmentcs;
                DepartmentDB.SaveChanges();
                return Ok("item was Update");


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

        // DELETE: api/Employee/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
              DepartmentDB.Employee.Remove(DepartmentDB.Employee.First((item)=>item.Id==id));
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
