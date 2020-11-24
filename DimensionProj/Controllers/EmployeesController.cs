using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DimensionProj.Data;
using DimensionProj.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DimensionProj.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ProjDBContext _context;

        public EmployeesController(ProjDBContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id==0)
                return View(new Employee());
            else
                return View(_context.Employees.Find(id));
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("EmployeeNumber,FullName,Age,Email,JobRole,Department")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                if(employee.EmployeeNumber == 0)
                    _context.Add(employee);
                else
                    _context.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public JsonResult DashBoardcount()
        {
            try 
            {
                string [] DashBoardcount = new string[2];

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(gender) as male ,(select count(gender) from EmployeeDetails where Gender = 'female') as female from EmployeeDetails where Gender  = 'male'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter cmd1 = new SqlDataAdapter(cmd)
;
                cmd1.fill(dt);
                if(dt.Rows.Coutn == 0)
                {
                    DashBoardcount[0] = "0";
                    DashBoardcount[1] = "0";
                }

                else
                {
                    DashBoardcount[0] = dt.rows[0]["male"].ToString();
                    DashBoardcount[1] = dt.rows[0]["female"].ToString();
                }
                return Json(new { DashBoardcount }, JsonRequestBehaviour.AllowGet);
               


            catch (Exception ex) 
            { 
                throw ex; 
            }
        }

        private JsonResult Json(object p, object allowGet)
        {
            throw new NotImplementedException();
        }
    }
}
