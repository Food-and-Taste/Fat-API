using FatApi.DataAccess;
using FatApi.Services;
using FatApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using static FatApi.Helpers.SecretesHelper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var configuration = builder.Configuration;
configuration.AddUserSecrets<Program>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FatContext>(options =>
{
    options.UseMySQL(SecretsHelper.GetDatabaseConnectionString(builder));
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
        });
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

builder.Services.AddScoped<IRecipesServices, RecipesServices>();
builder.Services.AddScoped<ICategoriesServices, CategoriesServices>();
builder.Services.AddScoped<IDifficultiesServices, DifficultiesServices>();
builder.Services.AddScoped<IUsersServices, UsersServices>();
builder.Services.AddScoped<IListsServices, ListsServices>();
builder.Services.AddScoped<IRecipesListServices, RecipesListServices>();
builder.Services.AddScoped<IReviewsServices, ReviewsServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
