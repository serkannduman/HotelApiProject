using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;

namespace HotelProject.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<Context>();
            builder.Services.AddScoped<IStaffDal,EfStaffDal>(); // IStaffDal g�r�nce EfStaffDal'� kullan dedik.
            builder.Services.AddScoped<IStaffService,StaffManager>(); //IStaffService g�r�nce StaffManager kullan dedik.

            builder.Services.AddScoped<IServicesDal, EfServiceDal>(); 
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IRoomDal, EfRoomDal>(); 
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>(); 
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>(); 
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}