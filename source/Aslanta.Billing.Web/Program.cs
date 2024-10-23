using Aslanta.Billing.Web.Components;
using Aslanta.Billing.Web.BillInsurance;
using Aslanta.Billing.Web.BillInsurance.Models;
using Aslanta.Billing.Web.BillInsurance.Implementations;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;

// Add services to the container.
services.AddRazorComponents()
    .AddInteractiveServerComponents();

services.AddRadzenComponents();

services.AddScoped<IItemCollection<Order>, ItemCollection<Order>>();
services.AddScoped<IItemCollection<InvoiceItem>, ItemCollection<InvoiceItem>>();
services.AddScoped<IInvoiceCreationState, InvoiceCreationState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
