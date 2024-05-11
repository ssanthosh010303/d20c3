/*
 * Author: Sakthi Santhosh
 * Created on: 17/04/2024
 */
#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Challenge1.Library.Models;

public class Doctor
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Specialization { get; set; }

    public List<Appointment> Appointments = [];
}
