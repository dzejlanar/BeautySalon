using AutoMapper;
using BeautySalon.Filters;
using BeautySalon.Security;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;
using BeautySalon.Services.Mapper;
using BeautySalon.Services.Services;
using BeautySalon.Services.ServiceStateMachine;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(x =>
{
    x.Filters.Add<ErrorFilter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddDbContext<BeautySalonContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IServiceCategoryService, ServiceCategoryService>();
builder.Services.AddTransient<IServiceService, ServiceService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserServiceRatingService, UserServiceRatingService>();
builder.Services.AddTransient<IRecommendationService, RecommendationService>();
builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<BaseServiceState>();
builder.Services.AddTransient<InitialServiceState>();
builder.Services.AddTransient<DraftServiceState>();
builder.Services.AddTransient<ActiveServiceState>();
builder.Services.AddTransient<HiddenServiceState>();

var configuration = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
var mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
