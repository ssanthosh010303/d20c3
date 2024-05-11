/*
 * Author: Sakthi Santhosh
 * Created on: 10/05/2024
 */
using Microsoft.EntityFrameworkCore;

using Challenge1.Library.Models;

namespace Challenge1.Library.Repositories;

public class ApplicationDbContext : DbContext
{
    private const string _connectionString = "Server=mysql;User ID=sakthi;Password=z7qvt172;Database=sakthi";

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            _connectionString,
            ServerVersion.AutoDetect(_connectionString)
        );
    }
}
