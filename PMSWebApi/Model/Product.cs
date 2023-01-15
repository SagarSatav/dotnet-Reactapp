namespace PMSWebApi.Model;
using System;
using System.ComponentModel.DataAnnotations;

public class Product{
    public int pid {get;set;}

    [Required]
    public string pname {get;set;}

     [Required]
    public string purchasedate {get;set;}
    
}