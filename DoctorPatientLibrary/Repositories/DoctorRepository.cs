/*
 * Author: Sakthi Santhosh
 * Created on: 17/04/2024
 */
using Challenge1.Library.Exceptions;
using Challenge1.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Challenge1.Library.Repositories;

public interface IDoctorRepository
{
    List<Doctor> GetAll();
    void Add(int id, string name, string specialization);
    void Update(Doctor item);
    void Delete(Doctor id);
}

public class DoctorRepository : IDoctorRepository
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<Doctor> _entities;

    public DoctorRepository(ApplicationDbContext databaseContext)
    {
        _dbContext = databaseContext;
        _entities = _dbContext.Set<Doctor>();
    }

    public List<Doctor> GetAll()
    {
        return [.. _entities];
    }

    public void Add(int id, string name, string specialization)
    {
        if (!_entities.Any(doctor => doctor.Id == id))
        {
            _entities.Add(new Doctor { Id = id, Name = name, Specialization = specialization });
            _dbContext.SaveChanges();
        }
        else
        {
            throw new DoctorAlreadyExistsException(id);
        }
    }

    public void Update(Doctor item)
    {
        _entities.Update(item);
        _dbContext.SaveChanges();
    }

    public void Delete(Doctor key)
    {
        var doctor = _entities.Find(key) ?? throw new ArgumentNullException(nameof(key));

        _entities.Remove(doctor);
        _dbContext.SaveChanges();
    }
}
