var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var currentDate = DateTime.Now;
app.MapGet("/", () => string.Format("Текущая дата: {0}\nДо Нового Года осталось: {1}",
    currentDate,
    (new DateTime(currentDate.Year + 1, 1, 1)- currentDate).Days));
app.Run();