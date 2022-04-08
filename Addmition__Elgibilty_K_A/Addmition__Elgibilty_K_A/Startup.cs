using Addmition__Elgibilty_K_A.Model;
using Addmition__Elgibilty_K_A.Model.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Addmition__Elgibilty_K_A.Areas.Identity.Data;

namespace Addmition__Elgibilty_K_A
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;}

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddMvc(op => op.EnableEndpointRouting = false);//activate the MVC
            services.AddScoped<interface_of_crud_operations<Student>, Student_Repository>();
            services.AddScoped<interface_of_crud_operations<Emplolyee>, Employee_Repository>();
            services.AddScoped<interface_of_crud_operations<statues_of_student>, statues_of_student_Repository>();
          //  services.AddScoped<interface_of_crud_operations<Admin>, Admin_Repository>();
            services.AddScoped<interface_of_crud_operations<Faculty>, Fauclty_Repository>();
            services.AddScoped<interface_of_crud_operations<setting_of_specialties>, setting_of_specialties_Repository>();
            services.AddScoped<interface_of_crud_operations<Type_of_certificate>, Type_of_certificate_Repository>();
            services.AddScoped<interface_of_crud_operations<statues_of_admission_elgibilty>, setting_of_addmition_elgibilty_Repository>();
            services.AddScoped<interface_of_crud_operations<admission_eligibility_request>, Admission_Eligibility_request_Un_Repository>();
            services.AddScoped<interface_of_crud_operations<Wishess>,wish_Repository>();

            services.AddScoped<interface_of_crud_operations<statues_of_student>, statues_of_student_Repository>();
            services.AddScoped<interface_of_crud_operations<admission_ligibility_request_SY>, Admition_Eligibility_Request>();

            services.AddScoped<interface_of_crud_operations<Acceptaple_Config>, Acceptable__configurtaion_repository>();




            //  services.AddScoped<interface_of_crud_operations<Faculty>, faculty_Repository_forWishes>();


            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<DataBaseAE>(options=> { 
            
            options.UseSqlServer(Configuration.GetConnectionString("SqlCon1"));//this libray we used to make the database by it self 


            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMvcWithDefaultRoute();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
