using System;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Data.Model;

namespace EmployeeManagementSystem.Services
{
	public class HomeService
	{
        private readonly ApplicationDbContext _db;
        public HomeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Home>> GetHomeAsync()
        {
            return await _db.Homes.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Home> GetHomeDetailsAsync(int id)
        {
            return await _db.Homes
                .Include(x => x.Residents)
                .Where(x => x.HomeID == id).FirstOrDefaultAsync();
        }

        public async Task<Home> AddHome(Home newHome)
        {
            _db.Homes.Add(newHome);
            await _db.SaveChangesAsync();
            return newHome; // Not used, just something to return for now
        }

        public async Task<Home> DeleteHome(int Id)
        {
            var prov = await _db.Homes
                .Include(x => x.Residents)
                .Where(x => x.HomeID == Id)
                .FirstOrDefaultAsync();
            _db.Homes.Remove(prov);
            await _db.SaveChangesAsync();
            return prov;
        }

        //public async Task<Employee> UpdateEmployee(int Id, string firstName, string lastName,
        //   int age, string email, string phone, DateTime createDate, DateTime hireDate, DateTime terminationDate, string employementStatus)
        //{
        //    var avail = await _db.Employees.Where(x => x.EmpID == Id).FirstOrDefaultAsync();
        //    avail.FirstName = firstName;
        //    avail.LastName = lastName;
        //    avail.Age = age;
        //    avail.Email = email;
        //    avail.Phone = phone;
        //    avail.CreateDate = createDate;
        //    avail.HireDate = hireDate;
        //    avail.TerminationDate = terminationDate;
        //    avail.EmploymentStatus = employementStatus;
        //    await _db.SaveChangesAsync();
        //    return avail;
        //}

        public async Task UpdateDatabaseAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

