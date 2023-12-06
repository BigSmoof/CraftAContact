using CraftAContact.Data;
using CraftAContact.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Correctly retrieve the API key
builder.Services.AddSingleton<IEmailSender, EmailSender>(serviceProvider =>
{
    var logger = serviceProvider.GetRequiredService<ILogger<EmailSender>>();
    return new EmailSender(builder.Configuration["SendGrid:SendGridKey"], logger);
});


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();



builder.Services.AddDefaultIdentity<IdentityUser>(options => 
{ 
    options.User.RequireUniqueEmail = true; //Added this to require unique email
    options.SignIn.RequireConfirmedAccount = true; //Disable in case of testing without the need to verify email
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
