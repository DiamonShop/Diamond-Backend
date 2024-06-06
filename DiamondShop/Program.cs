using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json", optional: false);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"{token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    });
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

//Connect to database
// Configure CORS
builder.Services.AddCors(options => options.AddPolicy("AllowSpecificOrigin", policy =>
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

// Configure DbContext
builder.Services.AddDbContext<DiamondDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

//Add CORS to allow two different origin(IP:Port) connect together
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowSpecificOrigin",
	builder =>
	{
		builder.WithOrigins("http://localhost:3000")
	.AllowAnyHeader()
	.AllowAnyMethod();
	});
});

// Configure JwtSettings
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));

// Configure JWT Authentication
var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtSettings>();
var key = Encoding.ASCII.GetBytes(jwtSettings.SecretKey);
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});
//gg
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme; // Set default challenge scheme to Google
})
.AddCookie()
.AddGoogle(options =>
{
    options.ClientId = "993387960773-r3cldf382hbgjghab16alb7qodolqumr.apps.googleusercontent.com";
    options.ClientSecret = "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";
});



//JWT SETTING
// up JWT
//var jwtSettings = new JwtSettings();
builder.Configuration.Bind("Jwt", jwtSettings);


// Configure Authentication

// Build the app
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Use CORS
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
