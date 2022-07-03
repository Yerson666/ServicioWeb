using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using WebAPI.Entities;



namespace WebAPI.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;



        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            var appSettingsSection = Configuration.GetSection("AppSettings");
            var appSettings = appSettingsSection.Get<AppSettings>();
            string bd = appSettings.BaseDatosSeguridad;
            options.UseSqlServer(Desencriptar(bd));
        }


        //Desencripta lo que encriptamos en web
        public static string Desencriptar(string pTexto)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(pTexto);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }



        public DbSet<Usuario> Usuario { get; set; }
    }
}
