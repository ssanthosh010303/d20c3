/*
 * Author: Sakthi Santhosh
 * Created on: 17/04/2024
 */
#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge1.Library.Models;

public class Appointment
{
    [Key]
    public int Id { get; set; }

    public int DoctorId { get; set; }
    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; }

    public int PatientId { get; set; }
    [ForeignKey("PatientId")]
    public Patient Patient;
}
