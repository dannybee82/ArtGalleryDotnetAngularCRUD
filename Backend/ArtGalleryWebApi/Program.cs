using FileSignatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RepositoryLayer;
using RepositoryLayer.Repository;
using ServiceLayer.Services;
using ServiceLayer.Settings;

var builder = WebApplication.CreateBuilder(args);

//For PostgreSQL Databases and DateTime.
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Add DbContext.
var dbConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MainDbContext>(options => options.UseNpgsql(dbConnectionString));

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArtGalleryWebApi", Version = "v1" });
});

// Enable CORS - Cross Origin Resource Sharing
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
        builder.WithOrigins("http://localhost:4200", "https://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod()
    );
});

// Set allowed File Types. See: FileSignatures.Formats for available formats.
//Also see: https://github.com/neilharvey/FileSignatures/
var allowedFileList = new AllowedFileFormatList()
{
    AllowedFileList = new List<AllowedFileFormat>()
    {
        new AllowedFileFormat()
        {
            Extension = "jpg",
            FileFormat = FileFormatLocator.GetFormats().OfType<FileSignatures.Formats.Jpeg>()
        },
        new AllowedFileFormat()
        {
            Extension = "png",
            FileFormat = FileFormatLocator.GetFormats().OfType<FileSignatures.Formats.Png>()
        },
        new AllowedFileFormat()
        {
            Extension = "gif",
            FileFormat = FileFormatLocator.GetFormats().OfType<FileSignatures.Formats.Gif>()
        }
    }
};

// Register database-layers (repositories).
builder.Services.AddScoped<IArtistRepository, ArtistRepository>();
builder.Services.AddScoped<IStyleRepository, StyleRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IThumbnailRepository, ThumbnailRepository>();
builder.Services.AddScoped<IPaintingRepository, PaintingRepository>();

// Register services.
builder.Services.AddScoped<IPaintingService, PaintingService>();
builder.Services.AddScoped<IArtistService, ArtistService>();
builder.Services.AddScoped<IStyleService, StyleService>();
builder.Services.AddScoped<IThumbnailService, ThumbnailService>();
builder.Services.AddScoped<IUploadFileService, UploadFileService>();
builder.Services.AddScoped<IAvailableFilterService, AvailableFilterService>();

builder.Services.AddSingleton<IAllowedFileFormatList, AllowedFileFormatList>((IServiceProvider sp) => allowedFileList);
builder.Services.AddSingleton<IFileFormatInspector>(new FileFormatInspector());

//App
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();
