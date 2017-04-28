﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace FinalGroupProjectTeam8.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    public enum UserTypeEnum { Customer, Employee, Manager }

    public class AppUser : IdentityUser
    {

        // Bank user scalar and navigational properties
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required.")]
        public String FName { get; set; }

        [Display(Name = "Middle Initial")]
        [Required(ErrorMessage = "Middle initial is required.")]
        public String MiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LName { get; set; }

        [Display(Name = "Birthday")]
        [Required(ErrorMessage = "Birthday is required.")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Street is required.")]
        public String Street { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required.")]
        public String City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required.")]
        public String State { get; set; }

        [Display(Name = "Zipcode")]
        [Required(ErrorMessage = "Zipcode is required.")]
        public String Zip { get; set; }

        public UserTypeEnum UserType { get; set; }

        public virtual List<CheckingAccount> CheckingAccounts { get; set; }

        public virtual List<SavingsAccount> SavingsAccounts { get; set; }

        public virtual IRA IRA { get; set; }
        public virtual StockPortfolio StockPortfolio { get; set; }

        //This method allows you to create a new user
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //TODO: Here's your db context for the project.  All of your db sets should go in here
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        //TODO:  Add dbsets here, for instance there's one for books
        //Remember, Identity adds a db set for users, so you shouldn't add that one - you will get an error
        //public DbSet<Book> Books { get; set; }

        //TODO: Make sure that your connection string name is correct here.
        public AppDbContext()
            : base("MyDBConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        public DbSet<AppRole> AppRoles { get; set; }
    }
}