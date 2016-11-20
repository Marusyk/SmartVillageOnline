# SmartVillage-Online <br>
:warning::warning::warning: **Currently working solution is [SmartVillageOnline-1.0](https://github.com/Marusyk/SmartVillageOnline-1.0)**:warning::warning::warning:

test deploy on http://deploy-test.apphb.com/ <br>
Build status: [![Build status](https://ci.appveyor.com/api/projects/status/77fhs311rehg19jo?svg=true)](https://ci.appveyor.com/project/Marusyk/smartvillageonline)<br><br>
**І. What is Smart Village?** <br>
Система «Розумне село» є єдиною, здатною до масштабування та  адаптації, інформаційною системою, що призначена для автоматизації  діяльності   сільських  і  селищних  рад  по  веденню погосподарських книг,  статистичного  обліку  землі, нерухомості, транспорту,  свійських  тварин  і  худоби  у  відповідності  до норм  законодавства України, а саме [Наказу Держкомстату від 08.12.10 р. № 491 про затвердження нової Інструкції з ведення погосподарського обліку в сільських, селищних та міських радах.](http://zakon.rada.gov.ua/cgi-bin/laws/main.cgi?nreg=z0009-11) <br>
Більше інофрмації на офсайті: http://sisoftware.biz/products/smart-village/

**II. What is Smart Village - Online?** <br>

Система “SmartVillage-Online” є [веб-додатком](https://en.wikipedia.org/wiki/Web_application) який побудований на основі нових технологій за концепцією [SaaS](https://en.wikipedia.org/wiki/Software_as_a_service) і є аналогом desktop-версії програми Smart Village 

**IIІ. Аrchitecture** <br>
В загальному архітектура має такий вигляд:
![Image of Yaktocat](https://docs.google.com/drawings/d/1i3Zimnpw-2yp8Fp4jmmnpJ0tq0B24lFB1a2GAw0fhAg/pub?w=1210&h=758)

Більш детальна схема архітектури

![Image of Yaktocat](https://lh3.googleusercontent.com/-cdJauQt-5z8/Vli6oN7yksI/AAAAAAAAJfg/0mGkJ7evY8M/w530-d-h308-p-rw/WebApi%2Barchitecture.PNG)

**IV. Instruments** <br>
Перелік інструментів які використовуються:
- [Microsoft Visual Studio 2015](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx) 
- [Microsoft SQL Server 2014](https://www.microsoft.com/ru-ru/download/details.aspx?id=42299)
- [.NET Framework 4.6](http://blogs.msdn.com/b/dotnet/p/dotnet_sdks.aspx#)
- [Microsoft Build Tools 2015 RC](https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs)
- [Entity Framework 6](https://msdn.microsoft.com/ru-ru/data/ef.aspx)
- [ASP.NET 4](http://www.asp.net/)
- [IIS 7.0](https://en.wikipedia.org/wiki/Internet_Information_Services)
- [IB Expert](http://www.ibexpert.net/ibe/)
- [GIT](https://git-scm.com/)
- [Fiddler](http://www.telerik.com/fiddler)
- Delphi 7 and Components
- [Firebird server](http://www.firebirdsql.org/)
- SmartVillage source code

**UPDATE** <br>
З 12.2015 проект повністю перенесено на нову платформу .NET 4.6 де використовується новий компілятор [Roslyn](https://roslyn.codeplex.com/) і синтаксис [C# 6.0](https://msdn.microsoft.com/en-us/magazine/dn683793.aspx)

.....

**VI. UnitTests**<br>
Проект призначений для створення [юніт-тестів](https://en.wikipedia.org/wiki/Unit_testing). Ми збираємося слідувати підходу [Test-driven development (TDD).](https://en.wikipedia.org/wiki/Test-driven_development)
<br>
Для створення тестів за технологією TDD слід дотримуватися таких пунктів:
* Визначаємо, що нам потрібно додати нову функцію або метод в додаток.
* Пишемо тест, який буде перевіряти поведінку нової функції, до того як вона буде написана.
* Запускаємо тест і отримуємо негативний результат.
* Пишемо код, який реалізує функцію.
* Знову запускаємо тест і коригуємо код, поки тест не виконається успішно.
* Якщо потрібно, оптимізуємо код (проводимо рефакторинг), наприклад, реорганізація виразів, перейменування змінних і так далі.
* Запускаємо тест, щоб підтвердити, що зміни не вплинули на поведінку доповнень
<br>
В методах модульного тестування потрібно дотримуватися патерну [arrange/act/assert(A/A/A)](http://www.arrangeactassert.com/why-and-what-is-arrange-act-assert/)<br>
Одним з хороших підходів полягає в використанні [mock-об’єктів](https://en.wikipedia.org/wiki/Mock_object), які симулюють
функціональність реальних об’єктів проекту. Mock-об’єкти дозволяють звузити фокус тестів, так щоб можна було перевірити тільки той функціонал в якому ми зацікавлені.

 ![Image of Yaktocat](https://lh4.googleusercontent.com/-cHg67Nmwse8/VZIyqYisEZI/AAAAAAAAIxg/_OoZoiJv5A0/w260-h541-no/sss.PNG)

**VII. WebUI** <br>
WebUI - є проектом [ASP.NET MVC.](http://www.asp.net/mvc)<br>

 ![Image of Yaktocat](https://lh4.googleusercontent.com/-TMI5OTmsToA/VZIyptvmrUI/AAAAAAAAIxo/wcMIXv_d81k/w763-h134-no/22.PNG)
 
 Але в першу чергу реалізує програмний інтерфейс [WebAPI](https://en.wikipedia.org/wiki/Web_API), який дозволяє легко створювати служби [HTTP](https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol) для широкого діапазону клієнтів, включаючи браузери і мобільні пристрої. WebUI - є [RESTful](https://en.wikipedia.org/wiki/Representational_state_transfer) додатком на платформі [.NET Framework](https://en.wikipedia.org/wiki/.NET_Framework).
 <br>
 Реалізація клієнтської частини:
 
  ![Image of Yaktocat](https://lh6.googleusercontent.com/-rvgDUMBCNiY/VZIyqHPdiKI/AAAAAAAAIxQ/VByecfOFi8o/w141-h387-no/ef31.png)
  
Додаткові інструменти:
* [Ninject - DI(Dependency Injection)](https://en.wikipedia.org/wiki/Dependency_injection) контейнер для побудови слабо-зв’язаних компонентів
* [Moq](https://en.wikipedia.org/wiki/Mock_object) - фреймворк для модульного тестування. Це набір мокінг інструментів
* [Twitter Bootstrap](http://getbootstrap.com/)(+/-)
* [jQuery](https://jquery.com/)
* [knockoutjs](http://knockoutjs.com/)
* [Microsoft OData](https://msdn.microsoft.com/en-us/data/hh237663.aspx)

