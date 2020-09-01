using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Premium.DatabaseAdapters.PgSql;
using System;

namespace Premium.Commons.PgSql
{
    public static class Extensions
    {
        private static DbContextOptionsBuilder dbContextOptionsBuilder;
        public static void AddPg<TContext>(this ContainerBuilder builder, string app_config_variable) where TContext : DbContext
        {


            builder.Register(c =>
            {
                var config = c.Resolve<IConfiguration>();
                var opt = new DbContextOptionsBuilder<TContext>();
                opt.UseNpgsql(config.GetSection(app_config_variable).Value);
                Console.WriteLine(config.GetSection(app_config_variable).Value);
                dbContextOptionsBuilder = opt;
                var instance = Activator.CreateInstance(typeof(TContext), opt.Options) as TContext;
                return instance;
            }).AsSelf().InstancePerLifetimeScope();


        }

        public static void AddPgRepository<TEntity>(this ContainerBuilder builder)
            where TEntity : class
            => builder.RegisterType<TEntity>().WithParameter("options", dbContextOptionsBuilder.Options).InstancePerLifetimeScope();
    }
}