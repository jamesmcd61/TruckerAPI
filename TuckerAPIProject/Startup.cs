using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TuckerAPIProject.Profiles;

namespace TuckerAPIProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            var mapperConfig = new MapperConfiguration(profile =>
            {
                profile.AddProfile(new AccountProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton<IMapper>(mapper);

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var dbConnection = Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnectionSql").Value;
            services.AddDbContext<TuckerAPIProject.Data.DbContext>(_ => _.UseSqlServer(dbConnection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowSpecificOrigin");
            app.UseDefaultFiles();
            app.UseHttpsRedirection();
            app.UseHttpMethodOverride();
            app.UseAuthorization();
        }
    }
}
