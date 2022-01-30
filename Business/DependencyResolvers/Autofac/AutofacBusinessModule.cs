using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Cocrete;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilites.Helper.FileHelper;
using Core.Utilites.İntercaptors;
using Core.Utilites.Security.JWT;
using DataAccess.Cocrete.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccsess.Abstract;
using DataAccsess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();


            builder.RegisterType<CarimgManager>().As<ICarimgService>().SingleInstance();
            builder.RegisterType<EfCarimgDal>().As<ICarimgDal>().SingleInstance();

            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

            builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<EfRental>().As<IRentalDal>().SingleInstance();

            

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<CarimgManager>().As<ICarimgService>().SingleInstance();
            builder.RegisterType<EfCarimgDal>().As<ICarimgDal>().SingleInstance();

            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>().SingleInstance();


    

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
