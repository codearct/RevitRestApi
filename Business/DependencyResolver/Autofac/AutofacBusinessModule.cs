using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.Mapper;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule:Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomManager>().As<IRoomService>().SingleInstance();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>().SingleInstance();

            builder.RegisterType<AreaManager>().As<IAreaService>().SingleInstance();
            builder.RegisterType<EfAreaDal>().As<IAreaDal>().SingleInstance();

            builder.RegisterType<ProjectManager>().As<IProjectService>().SingleInstance();



            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            })).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);
            })
            .As<IMapper>()
            .SingleInstance();

        }
    }
}
