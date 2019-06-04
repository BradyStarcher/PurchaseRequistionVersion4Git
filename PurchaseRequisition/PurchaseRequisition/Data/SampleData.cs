using Microsoft.AspNetCore.Identity;
using PurchaseRequisition.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseRequisition.Data
{
    public class SampleData
    {
        public static async Task Initialize(ApplicationDbContext context,
                             UserManager<User> userManager,
                             RoleManager<Role> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string role3 = "CFO";
            string desc3 = "This is the CFO role";

            string role4 = "Auditor";
            string desc4 = "This is the Auditor's role";

            string password = "Develop@90";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new Role(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new Role(role2, desc2, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role3) == null)
            {
                await roleManager.CreateAsync(new Role(role3, desc3, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role4) == null)
            {
                await roleManager.CreateAsync(new Role(role4, desc4, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("bill@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "bill@develop.com",
                    Email = "bill@develop.com",
                    FirstName = "Bill",
                    LastName = "Tech",
                    Division = "STEM",
                    Department = "Tech",
                    JobTitle = "IT",
                    StartDate = "January 10, 2010",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }
            if (await userManager.FindByNameAsync("jared@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "jared@develop.com",
                    Email = "jared@develop.com",
                    FirstName = "Jared",
                    LastName = "Gump",
                    Division = "STEM",
                    Department = "Science",
                    JobTitle = "STEM Divsion Head",
                    StartDate = "August 10, 2009",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
            if (await userManager.FindByNameAsync("charles@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "charles@develop.com",
                    Email = "charles@develop.com",
                    FirstName = "Charles",
                    LastName = "Almond",
                    Division = "STEM",
                    Department = "CS",
                    JobTitle = "Professor",
                    StartDate = "August 10, 2001",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
            if (await userManager.FindByNameAsync("donna@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "carrie@develop.com",
                    Email = "carrie@develop.com",
                    FirstName = "Carrie",
                    LastName = "Budget",
                    Division = "Budget",
                    Department = "Budget",
                    JobTitle = "CFO",
                    StartDate = "June 1, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
            }
            if (await userManager.FindByNameAsync("vicki@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "cheri@develop.com",
                    Email = "cheri@develop.com",
                    FirstName = "Cheri",
                    LastName = "Auditor",
                    Division = "Auditor",
                    Department = "Auditor",
                    JobTitle = "Auditor",
                    StartDate = "January 1, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("chris@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "chris@develop.com",
                    Email = "chri@develop.com",
                    FirstName = "Chris",
                    LastName = "Gilmer",
                    Division = "None",
                    Department = "None",
                    JobTitle = "President",
                    StartDate = "August 20, 2018",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("alice@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "alice@develop.com",
                    Email = "alice@develop.com",
                    FirstName = "Alice",
                    LastName = "Harris",
                    Division = "None",
                    Department = "None",
                    JobTitle = "CFO",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("alice@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "alice@develop.com",
                    Email = "alice@develop.com",
                    FirstName = "Alice",
                    LastName = "Harris",
                    Division = "None",
                    Department = "None",
                    JobTitle = "CFO",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("chad@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "chad@develop.com",
                    Email = "chad@develop.com",
                    FirstName = "Chad",
                    LastName = "VP",
                    Division = "None",
                    Department = "None",
                    JobTitle = "Academic Dean and Academic Vice President",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("tony@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "tony@develop.com",
                    Email = "tony@develop.com",
                    FirstName = "Tony",
                    LastName = "Dean",
                    Division = "None",
                    Department = "None",
                    JobTitle = "Student Dean",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("alice@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "alice@develop.com",
                    Email = "alice@develop.com",
                    FirstName = "Alice",
                    LastName = "Harris",
                    Division = "None",
                    Department = "None",
                    JobTitle = "CFO",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("steve@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "steve@develop.com",
                    Email = "steve@develop.com",
                    FirstName = "Steve",
                    LastName = "Computer",
                    Division = "STEM",
                    Department = "CS",
                    JobTitle = "Professor",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("dave@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "dave@develop.com",
                    Email = "dave@develop.com",
                    FirstName = "Dave",
                    LastName = "Maintence",
                    Division = "Administration",
                    Department = "Maintence",
                    JobTitle = "Head of Maintence",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            if (await userManager.FindByNameAsync("bob@develop.com") == null)
            {
                var user = new User
                {
                    UserName = "bob@develop.com",
                    Email = "bob@develop.com",
                    FirstName = "Bob",
                    LastName = "Janitor",
                    Division = "Administration",
                    Department = "Maintence",
                    JobTitle = "Janitor",
                    StartDate = "August 12, 1997",
                    EndDate = "N/A",
                    Campus = "Parkersburg"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
        }
    }
}
