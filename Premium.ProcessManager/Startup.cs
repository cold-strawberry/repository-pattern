using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Autofac;
using Premium.Commons;
using System.Reflection;
using Autofac.Extensions.DependencyInjection;
using Premium.Commons.PgSql;
using Premium.DatabaseAdapters.PgSql;
using Premium.Commons.Dispatchers;
using Premium.ProcessManager.Repositories;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using IApplicationLifetime = Microsoft.AspNetCore.Hosting.IApplicationLifetime;
using Microsoft.EntityFrameworkCore;
using Premium.DatabaseAdapters.postgresql.models;

namespace Premium.ProcessManager
{
    public class Startup
    {
        

        public IConfiguration Configuration { get; }
        public IContainer Container { get; private set; } 

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCustomMvc();

            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly())
                .AsImplementedInterfaces();
            builder.Populate(services);
            builder.AddDispatchers();
            //builder.Register(c =>
            //{
            //    var config = c.Resolve<IConfiguration>();
            //    var opt = new DbContextOptionsBuilder<PremiumDbContext>();
            //    opt.UseNpgsql(config.GetSection("Connection-Strings:Databases:Premium-Db").Value);
            //    return new PremiumDbContext(opt.Options);
            //}).AsSelf().InstancePerLifetimeScope();

            
            builder.AddPg<PremiumDbContext>("Connection-Strings:Databases:Premium-Db");
            builder.AddPgRepository<Connection>();
            builder.AddPgRepository<Platform>();

            Container = builder.Build();
            return new AutofacServiceProvider(Container);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime applicationLifeTime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();

            applicationLifeTime.ApplicationStopped.Register(() => Container.Dispose());

  
        }
    }
}
