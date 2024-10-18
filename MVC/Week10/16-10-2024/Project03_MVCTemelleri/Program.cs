var builder = WebApplication.CreateBuilder(args); //Bir Web Uygulaması Oluşturucu Nesne Yaratılıyor.

builder.Services.AddControllersWithViews(); //Bu uygulamanın bir MVC uygulaması olmasını sağlıyor.

var app = builder.Build(); //Web uyg oluşturuluyor.

//run yapılana kadar bulunan bu yapılara MiddleWare (Ara Yazılım) denir.

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //Oluşturulan web uygulamasını çalıştırıyor / ayağa kaldırıyor.




/*
    Bir MVC projesi oluşturduğumuzda aşağıdaki işlemleri yapalım.

    1) HomeController içinde sadece index ve privacy action metodları kalsın. geri kalan kısmı sil   

    2) Views/Shared klasöründe error.cshtml sil

    3) Models klasöründeki errorviewmodal sil

    4) HomeController ve Views/ViewImport.cshtml dosyasının içindeki "using.ProjeAdi.Models yazan satırı sil.
*/