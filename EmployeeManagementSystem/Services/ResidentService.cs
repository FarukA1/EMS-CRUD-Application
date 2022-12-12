using System;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Data.Model;

namespace EmployeeManagementSystem.Services
{
	public class ResidentService
	{
        private readonly ApplicationDbContext _db;
        public ResidentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Resident>> GetResidentAsync()
        {
            return await _db.Residents.OrderBy(x => x.FirstName).ToListAsync();
        }

        public async Task<Resident> GetResidentDetailsAsync(int id)
        {
            return await _db.Residents.Where(x => x.ResidentID == id).FirstOrDefaultAsync();
        }

        public async Task<Resident> AddResident(Resident newResident)
        {
            _db.Residents.Add(newResident);
            await _db.SaveChangesAsync();
            return newResident; // Not used, just something to return for now
        }

        public async Task<Resident> DeleteResident(int Id)
        {
            var prov = await _db.Residents
                .Where(x => x.ResidentID == Id)
                .FirstOrDefaultAsync();
            _db.Residents.Remove(prov);
            await _db.SaveChangesAsync();
            return prov;
        }

        public async Task<Resident> UpdateResident(int Id, string firstName, string middleName, string lastName,
           int age, Gender gender, string condition)
        {
            var avail = await _db.Residents.Where(x => x.ResidentID == Id).FirstOrDefaultAsync();
            avail.FirstName = firstName;
            avail.MiddleName = middleName;
            avail.LastName = lastName;
            avail.Age = age;
            avail.Gender = gender;
            avail.Condition = condition;
            await _db.SaveChangesAsync();
            return avail;
        }

        public async Task UpdateDatabaseAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

