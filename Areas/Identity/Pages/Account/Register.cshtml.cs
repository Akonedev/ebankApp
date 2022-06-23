// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using ebankApp.Models;

namespace ebankApp.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserStore<AppUser> _userStore;
        private readonly IUserEmailStore<AppUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<AppUser> userManager,
            IUserStore<AppUser> userStore,
            SignInManager<AppUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

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
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

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
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }








            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Genre")]
            public string Gender { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "First name")]
            public string FirstName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Nick name")]
            public string NickName { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Phone")]
            public string PhoneNumber { get; set; }


            [Required]
            [DataType(DataType.Date)]
            [Display(Name = "Birth Date")]
            public DateTime DateOfBirth { get; set; }


            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Addr Street Number")]
            public int Addr_Street_Number { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Address Street Name")]
            public string Addr_Street_Name { get; set; }

            [DataType(DataType.Text)]
            [Display(Name = "Address Other Precision")]
            public string Addr_Other_Precision { get; set; }

            [Required]
            [DataType(DataType.PostalCode)]
            [Display(Name = "Postal Code")]
            public int Addr_PostalCode { get; set; }


            [DataType(DataType.Text)]
            [Display(Name = "City")]
            public string Addr_City { get; set; }

            [Required]
            [DataType(DataType.Text)]
            [Display(Name = "Country")]
            public string Addr_Country { get; set; }



            /*
                        

                        [DataType(DataType.Text)]
                        [Display(Name = "Full name")]
                        public string FullName { get; set; }


                        [DataType(DataType.Text)]
                        [Display(Name = "Address line1")]
                        public string Addr_line1 { get; set; }


                        [DataType(DataType.Text)]
                        [Display(Name = "Address line2")]
                        public string Addr_line2 { get; set; }

                        [DataType(DataType.Text)]
                        [Display(Name = "Address line3")]
                        public string Addr_line3 { get; set; }


                       

                        [DataType(DataType.Text)]
                        [Display(Name = "Departement")]
                        public string Addr_Departement { get; set; }

                        [DataType(DataType.Text)]
                        [Display(Name = "Commune")]
                        public string Addr_Commune { get; set; }


                        [DataType(DataType.Text)]
                        [Display(Name = "Region")]
                        public string Addr_Region { get; set; }


                        [Required]
                        [DataType(DataType.Text)]
                        [Display(Name = "Province")]
                        public string Addr_Province { get; set; }

                       



                        [DataType(DataType.Text)]
                        [Display(Name = "Address Longitude")]
                        public int Addr_long { get; set; }

                        [DataType(DataType.Text)]
                        [Display(Name = "Address Lattitude")]
                        public int Addr_lat { get; set; }
            */
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                user.Gender = Input.Gender;
                user.FirstName = Input.FirstName;
                user.LastName = Input.LastName;
                 user.NickName = Input.NickName;

              /* user.PhoneNumber = Input.PhoneNumber;
               user.FullName = Input.FullName;*/

                user.DateOfBirth = Input.DateOfBirth;

                user.Addr_Street_Number = Input.Addr_Street_Number;
                user.Addr_Street_Name = Input.Addr_Street_Name;

                user.Addr_Other_Precision = Input.Addr_Other_Precision;
                user.Addr_PostalCode = Input.Addr_PostalCode;
                user.Addr_City = Input.Addr_City;
                user.Addr_Country = Input.Addr_Country;

                /*
                user.Addr_line1 = Input.Addr_line1;
                user.Addr_line2 = Input.Addr_line2;
                user.Addr_line3 = Input.Addr_line3;


                user.Addr_Departement = Input.Addr_Departement;
                user.Addr_Region = Input.Addr_Region;
                user.Addr_Commune = Input.Addr_Commune;
                user.Addr_Province = Input.Addr_Province;
                user.Addr_long = Input.Addr_long;
                 user.Addr_lat = Input.Addr_lat;
                */



                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private AppUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AppUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(AppUser)}'. " +
                    $"Ensure that '{nameof(AppUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<AppUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<AppUser>)_userStore;
        }
    }
}
