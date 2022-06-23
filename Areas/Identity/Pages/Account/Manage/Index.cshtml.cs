// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ebankApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ebankApp.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public IndexModel(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }



        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            //[Required]
            [DataType(DataType.Text)]
            //[Display(Name = "Gender")]
            public string Gender { get; set; }

            //[Required]
            [DataType(DataType.Text)]
            //[Display(Name = "Last name")]
            public string LastName { get; set; }

            //[Required]
            [DataType(DataType.Text)]
            //[Display(Name = "First name")]
            public string FirstName { get; set; }



            [DataType(DataType.Text)]
           // [Display(Name = "NickName")]
            public string NickName { get; set; }

            [DataType(DataType.Text)]
           // [Display(Name = "FullName")]
            public string FullName { get; set; }

           /* [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }*/


            [DataType(DataType.Text)]
           // [Display(Name = "Status")]
            public string Status { get; set; }


            //[Required]
           // [Display(Name = "Birth Date")]
            [DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; }


            //[Required]
            [DataType(DataType.Text)]
            [Display(Name = "Addr Number")]
            public int? Addr_Street_Number { get; set; }


            //[Required]
            [DataType(DataType.Text)]
        //    [Display(Name = "Addr Street Name")]
            public string Addr_Street_Name { get; set; }


            [DataType(DataType.Text)]
         //   [Display(Name = "Addr line 1")]
            public string Addr_line1 { get; set; }


            [DataType(DataType.Text)]
          //  [Display(Name = "Addr line2")]
            public string Addr_line2 { get; set; }


            [DataType(DataType.Text)]
       //     [Display(Name = "Addr line3")]
            public string Addr_line3 { get; set; }


            //[Required]
            [DataType(DataType.Text)]
         //   [Display(Name = "Postal Code")]
            public int? Addr_PostalCode { get; set; }

            //[Required]
            [DataType(DataType.Text)]
       //     [Display(Name = "Ville")]
            public string Addr_City { get; set; }



            [DataType(DataType.Text)]
          //  [Display(Name = "Departement")]
            public string Addr_Departement { get; set; }


            [DataType(DataType.Text)]
    //        [Display(Name = "Commune")]
            public string Addr_Commune { get; set; }

            [DataType(DataType.Text)]
      //      [Display(Name = "Province")]
            public string Addr_Province { get; set; }


            [DataType(DataType.Text)]
      //      [Display(Name = "Region")]
            public string Addr_Region { get; set; }

            //[Required]
            [DataType(DataType.Text)]
     //       [Display(Name = "Country")]
            public string Addr_Country { get; set; }


            [DataType(DataType.Text)]
     //       [Display(Name = "Other Precision For Address")]
            public string Addr_Other_Precision { get; set; }


            [DataType(DataType.Text)]
     //       [Display(Name = "Addr Longitude")]
            public int? Addr_long { get; set; }


            [DataType(DataType.Text)]
     //       [Display(Name = "Addr Lattitude")]
            public int? Addr_lat { get; set; }


        }

        private async Task LoadAsync(AppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Gender = user.Gender,
                LastName = user.LastName,
                FirstName = user.FirstName,
                NickName = user.NickName,
                Status = user.Status,
                DateOfBirth = user.DateOfBirth,
                Addr_Street_Number = user.Addr_Street_Number,
                Addr_Street_Name = user.Addr_Street_Name,
                Addr_line1 = user.Addr_line1,
                Addr_line2 = user.Addr_line2,
                Addr_line3 = user.Addr_line3,
                Addr_PostalCode = user.Addr_PostalCode,
                Addr_City = user.Addr_City,

                Addr_Departement = user.Addr_Departement,
                Addr_Commune = user.Addr_Commune,
                Addr_Region = user.Addr_Region,
                Addr_Province = user.Addr_Province,
                Addr_Country = user.Addr_Country,
                Addr_Other_Precision = user.Addr_Other_Precision,
                Addr_long = user.Addr_long,
                Addr_lat = user.Addr_lat
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.Gender != user.Gender)
            {
                user.Gender = Input.Gender;
            }

            if (Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
            }

            if (Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
            }

            if (Input.NickName != user.NickName)
            {
                user.NickName = Input.NickName;
            }

            if (Input.Status != user.Status)
            {
                user.Status = Input.Status;
            }

            if (Input.DateOfBirth != user.DateOfBirth)
            {
                user.DateOfBirth = Input.DateOfBirth;
            }

            if (Input.Addr_Street_Number != user.Addr_Street_Number)
            {
                user.Addr_Street_Number = Input.Addr_Street_Number;
            }

            if (Input.Addr_Street_Name != user.Addr_Street_Name)
            {
                user.Addr_Street_Name = Input.Addr_Street_Name;
            }

           
            if (Input.Addr_line1 != user.Addr_line1)
            {
                user.Addr_line1 = Input.Addr_line1;
            }
            if (Input.Addr_line2 != user.Addr_line2)
            {
                user.Addr_line2 = Input.Addr_line2;
            }

            if (Input.Addr_line3 != user.Addr_line3)
            {
                user.Addr_line3 = Input.Addr_line3;
            }

            if (Input.Addr_Other_Precision != user.Addr_Other_Precision)
            {
                user.Addr_Other_Precision = Input.Addr_Other_Precision;
            }

            if (Input.Addr_PostalCode != user.Addr_PostalCode)
            {
                user.Addr_PostalCode = Input.Addr_PostalCode;
            }

            if (Input.Addr_City != user.Addr_City)
            {
                user.Addr_City = Input.Addr_City;
            }

            if (Input.Addr_Departement != user.Addr_Departement)
            {
                user.Addr_Departement = Input.Addr_Departement;
            }


            if (Input.Addr_Commune != user.Addr_Commune)
            {
                user.Addr_Commune = Input.Addr_Commune;
            }


            if (Input.Addr_Region != user.Addr_Region)
            {
                user.Addr_Region = Input.Addr_Region;
            }

            if (Input.Addr_Province != user.Addr_Province)
            {
                user.Addr_Province = Input.Addr_Province;
            }

            

            if (Input.Addr_Country != user.Addr_Country)
            {
                user.Addr_Country = Input.Addr_Country;
            }

            if (Input.Addr_lat != user.Addr_lat)
            {
                user.Addr_lat = Input.Addr_lat;
            }

            await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
