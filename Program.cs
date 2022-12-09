
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServerConnStr")));




builder.Services.AddControllers();



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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();






















/*builder.Services.AddCors(o =>
   o.AddPolicy("corspolicy", builder =>
   {
       builder.AllowAnyOrigin()
       .AllowAnyMethod()
       .AllowAnyHeader();
   }));



builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IAuthRepo, AuthRepo>();



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"]))
    };
});





builder.Services.AddControllers();
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
//app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseCors("corspolicy");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();



app.Run();*/