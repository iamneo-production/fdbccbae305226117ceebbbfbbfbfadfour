using System.ComponentModel.DataAnnotations;
namespace dotnetapp.Models{
public class Booking{
    public int BookingID {get;set;}
    public int DinningTableID {get;set;}
    public int CustomerID {get;set;}
     
    public DateTime Capacity {get;set;}
    public ICollection<Student> Students {get;set;}
}}