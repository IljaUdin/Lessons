using Cinema.API;
using Cinema.Services;
using Cinema.Services.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureDbConnection(builder.Configuration);
builder.Services.AddSingleton<IFilmMapper, FilmMapper>();
builder.Services.AddTransient<IFilmService, FilmService>();

builder.Services.AddSingleton<IFilmMapper, SubscriptionMapper>();
builder.Services.AddTransient<ISubscriptionService, SubscriptionService>();

builder.Services.AddSingleton<IFilmMapper, CountryMapper>();
builder.Services.AddTransient<ICountryService, CountryService>();

builder.Services.AddSingleton<IFilmMapper, CompanyMapper>();
builder.Services.AddTransient<ICompanyService, CompanyService>();

builder.Services.AddSingleton<IFilmMapper, SerialMapper>();
builder.Services.AddTransient<ISerialService, SerialService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

app.MapControllers();

//app.MapRazorPages();

app.Run();
