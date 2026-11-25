var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
    <!doctype html>
    <html lang="ru">
    <head>
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <title>Unlimited Parts</title>
      <style>body{font:16px system-ui;max-width:720px;margin:4rem auto;padding:0 1rem;color:#243447}h1{color:#146c94}li{margin:.5rem 0}</style>
    </head>
    <body>
      <h1>Unlimited Parts</h1>
      <p>Каталог запасных частей и учебный пример CI/CD.</p>
      <h2>Популярные категории</h2>
      <ul><li>Двигатель</li><li>Тормозная система</li><li>Электроника</li></ul>
    </body>
    </html>
    """, "text/html; charset=utf-8"));
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.Run();
