using Microsoft.AspNetCore.Mvc;
using s33706cw8.Context;
using s33706cw8.DTOs;
using s33706cw8.Entities;

namespace s33706cw8.Services;

public class DbService :  IDbService
{
    private readonly MyDbContext _context;

    public DbService(MyDbContext context)
    {
        _context = context;
    }

    public async Task<object> GetPatients()
    {
        var query = _context.Patients
            .Select(p => new
            {
                pesel = p.Pesel,
                firstName = p.FirstName,
                lastName = p.LastName,
                age = p.Age,
                sex = p.Sex,
                admissions = p.Admissions.Select(a => new
                    {
                        id = a.Id,
                        admissionDate = a.AdmissionDate,
                        dischargeDate = a.DischargeDate,
                        ward = new
                        {
                            id = a.Ward.Id,
                            name = a.Ward.Name,
                            description = a.Ward.Description
                        }
                    }
                ),
                BedAssignments = p.BedAssignments.Select(ba => new
                {
                    id = ba.Id,
                    from = ba.From,
                    to = ba.To,
                    bed = new
                    {
                        id = ba.Bed.Id,
                        bedType = new
                        {
                            id = ba.Bed.BedType.Id,
                            name = ba.Bed.BedType.Name,
                            description = ba.Bed.BedType.Description
                        },
                        room = new {
                            id = ba.Bed.Room.Id,
                            hasTv = ba.Bed.Room.HasTv,
                            ward = new
                            {
                                id = ba.Bed.Room.Ward.Id,
                                name = ba.Bed.Room.Ward.Name,
                                description = ba.Bed.Room.Ward.Description
                            }
                    }
                }
            })
            }).ToList();
        return query;
    }
}