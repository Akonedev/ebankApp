using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ebankApp.Models;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{

    [PersonalData]
    public string? Gender { get; set; }


    [PersonalData]
    public string? LastName { get; set; }


    [PersonalData]
    public string? FirstName { get; set; }


    [PersonalData]
    public string? NickName { get; set; }

    [PersonalData]
    public string? FullName { get; set; }


    [PersonalData]
    public string? Status { get; set; }


    [PersonalData]
    public DateTime DateOfBirth { get; set; }


    [PersonalData]
    public int? Addr_Street_Number { get; set; }


    [PersonalData]
    public string? Addr_Street_Name { get; set; }


    [PersonalData]
    public string? Addr_line1 { get; set; }


    [PersonalData]
    public string? Addr_line2 { get; set; }


    [PersonalData]
    public string? Addr_line3 { get; set; }


    [PersonalData]
    public int? Addr_PostalCode { get; set; }


    [PersonalData]
    public string? Addr_City { get; set; }


    [PersonalData]
    public string? Addr_Departement { get; set; }


    [PersonalData]
    public string? Addr_Commune { get; set; }

    [PersonalData]
    public string? Addr_Region { get; set; }


    [PersonalData]
    public string? Addr_Province { get; set; }


    [PersonalData]
    public string? Addr_Country { get; set; }


    [PersonalData]
    public string? Addr_Other_Precision { get; set; }


    [PersonalData]
    public int? Addr_long { get; set; }


    [PersonalData]
    public int? Addr_lat { get; set; }
}

