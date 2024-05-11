/*
 * Author: Sakthi Santhosh
 * Created on: 17/04/2024
 */
#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Challenge1.Library.Models;

public class Patient
{
    [Key]
    public int Id;

    public string Name { get; set; }
    public string ContactNumber { get; set; }
}
