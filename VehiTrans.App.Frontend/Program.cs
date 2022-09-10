using VehiTrans.App.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton <IRepositorioAuxiliar, RepositorioAuxiliar>();
builder.Services.AddSingleton <IRepositorioConductor, RepositorioConductor>();
builder.Services.AddSingleton <IRepositorioJefeOperaciones, RepositorioJefeOperaciones>();
builder.Services.AddSingleton <IRepositorioMecanico, RepositorioMecanico>();
builder.Services.AddSingleton <IRepositorioPropietario, RepositorioPropietario>();
builder.Services.AddSingleton <IRepositorioTipoSeguro, RepositorioTipoSeguro>();
//builder.Services.AddSingleton <IRepositorioVehiculoTipo, RepositorioVehiculoTipo>();
builder.Services.AddSingleton <IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddSingleton <IRepositorioSeguro, RepositorioSeguro>();
//builder.Services.AddSingleton <IRepositorioRevision, RepositorioRevision>();
builder.Services.AddSingleton <IRepositorioComprarRepuestos, RepositorioCompraRepuestos>();
builder.Services.AddSingleton <IRepositorioRepuestos, RepositorioRepuestos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//dsdfd
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
