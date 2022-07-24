using EmployeeManagementWebApi.Middleware;
using EmployeeManagementWebApi.Repository;
using EmployeeManagementWebApi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddTransient<ContentCheckMiddleware>();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration);

var app = builder.Build();
app.UseMiddleware<ContentCheckMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();


//https://login.microsoftonline.com/f6a10498-fea6-41df-bdd2-230df4814731/oauth2/authorize?client_id=d99722a4-9ad3-48f7-a85d-69bc2c263ad7&response_type=token&redirect_uri=http%3A%2F%2Flocalhost%2F&response_mode=fragment&resource=d99722a4-9ad3-48f7-a85d-69bc2c263ad7&state=12345&nonce=S256

//
// https://login.microsoftonline.com/f6a10498-fea6-41df-bdd2-230df4814731/oauth2/authorize?client_id=d99722a4-9ad3-48f7-a85d-69bc2c263ad7&response_type=token&response_mode=fragment&resource=d99722a4-9ad3-48f7-a85d-69bc2c263ad7&state=12345&nonce=S256


https://localhost:7151/swagger/index.html#
      //access_token=
      // eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IjJaUXBKM1VwYmpBWVhZR2FYRUpsOGxWMFRPSSIsImtpZCI6IjJaUXBKM1VwYmpBWVhZR2FYRUpsOGxWMFRPSSJ9.eyJhdWQiOiJkOTk3MjJhNC05YWQzLTQ4ZjctYTg1ZC02OWJjMmMyNjNhZDciLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC9mNmExMDQ5OC1mZWE2LTQxZGYtYmRkMi0yMzBkZjQ4MTQ3MzEvIiwiaWF0IjoxNjU4NjYxNjg2LCJuYmYiOjE2NTg2NjE2ODYsImV4cCI6MTY1ODY2NjcxMiwiYWNyIjoiMSIsImFpbyI6IkFWUUFxLzhUQUFBQTlsMFBqVjJMOGdPVGp0RUtsYjZwZ1NiNlowOStUZmlOZW5jc0Z3RlcvdFZiZUV3SUtKVUJ5QjVoM2ZyQlBRVHpRYTFOUHVvZHkySnRDMnA2WDNXbUQ1eVZiSzZHRTVPNUhUZWwrWGNxL0RVPSIsImFtciI6WyJwd2QiXSwiYXBwaWQiOiJkOTk3MjJhNC05YWQzLTQ4ZjctYTg1ZC02OWJjMmMyNjNhZDciLCJhcHBpZGFjciI6IjAiLCJlbWFpbCI6InBhcmFtc2F1dG9tYXRpb25AZ21haWwuY29tIiwiZmFtaWx5X25hbWUiOiJQYW53YXIiLCJnaXZlbl9uYW1lIjoiUGFyYW12ZWVyIiwiaWRwIjoibGl2ZS5jb20iLCJpcGFkZHIiOiIxMDQuMjguMjAwLjk3IiwibmFtZSI6IlBhcmFtdmVlciBQYW53YXIiLCJvaWQiOiIwYWUwZjkzZS0wMzc3LTQzZDAtYjA2My00NGY3ZTQ5MTA5Y2IiLCJyaCI6IjAuQVZVQW1BU2g5cWItMzBHOTBpTU45SUZITWFRaWw5blRtdmRJcUYxcHZDd21PdGVJQUljLiIsInNjcCI6IlVzZXIuUmVhZCIsInN1YiI6IlFZYmNZSnktRnd5N0FaSGtXdll5b1lvUEtwVE5FTFNycTR1YUREYzZ4TmMiLCJ0aWQiOiJmNmExMDQ5OC1mZWE2LTQxZGYtYmRkMi0yMzBkZjQ4MTQ3MzEiLCJ1bmlxdWVfbmFtZSI6ImxpdmUuY29tI3BhcmFtc2F1dG9tYXRpb25AZ21haWwuY29tIiwidXRpIjoiQTg0Z1FUVHVlMENvalZLSVZhWlpBUSIsInZlciI6IjEuMCJ9.ZazUs2oRORk7QtzbGc8oegzTqMVlBsrnvUm4XHqpkkPn2ui6sQLYLlqLzejCp78P7D5RMURmKzPZSRdbRutmSdyx0I8AtobEeWeVj4nThI9hQqMFJBIC52vHlBE4uty4a7nPjPMbPunwk7sBSdEzctxLn0BEX0KqRarhiAj3mLLmLkiaRYggVTBGXSGHzSxF9QUA-MIZFbhyj22XU3tGXQp1X_H844v6i7zWXPiBsqWl2idjyJjm-4Uom5z7ywo-NjrVd0ACP5tQHOqz6Q6cObKNEK75l7by4nr5pC6q9BAkV31SX2Uu_gwGXaGhRc0SXpxqVHMVYehG4WR5OyCSug
      //&token_type=
      //Bearer&expires_in=4725&state=12345&session_state=d24bc190-8445-48e5-a30d-44e64928bcd0



app.Use(async (context, next) =>
{
    if (!context.User.Identity?.IsAuthenticated ?? false)
    {
        context.Response.StatusCode = 401;
       await context.Response.WriteAsJsonAsync("Not Authenticated");
    }
    else
    {
        await next();
    }
});

app.MapControllers();

app.Run();
