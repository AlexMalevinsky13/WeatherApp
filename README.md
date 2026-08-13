# WeatherApp

Веб-приложение для отображения текущей погоды и прогноза погоды в Москве.

Приложение получает данные из WeatherAPI и отображает:

- текущую температуру и погодные условия;
- ощущаемую температуру;
- влажность, атмосферное давление и ветер;
- оставшиеся часы текущего дня;
- почасовой прогноз на следующий день;
- прогноз погоды на 3 дня;
- состояние загрузки;
- обработку ошибок с возможностью повторного запроса.

## Технологии

- .NET 10
- ASP.NET Core
- Blazor Server (Interactive Server)
- MediatR
- System.Text.Json
- WeatherAPI

## Структура решения

Решение состоит из трех проектов:

### WeatherApp.Web

Пользовательский интерфейс приложения на Blazor Server.

Отвечает за отображение погоды, состояния загрузки, ошибок и повторный запрос данных.

### WeatherApp.Application

Прикладной слой приложения.

Содержит:

- модели приложения;
- MediatR queries и handlers;
- абстракции для получения данных о погоде.

### WeatherApp.Infrastructure

Инфраструктурный слой.

Содержит:

- интеграцию с WeatherAPI;
- HTTP-клиент;
- модели ответа WeatherAPI;
- преобразование данных внешнего API в модели приложения;
- регистрацию инфраструктурных зависимостей.

## Получение данных

Для получения данных используется WeatherAPI:

`forecast.json?days=3`

Один запрос содержит текущую погоду, почасовой прогноз и прогноз на три дня.

Город Москва задается фиксированными координатами в конфигурации приложения.

## Запуск

Требуется .NET 10 SDK.

1. Клонировать репозиторий.
2. Открыть `WeatherApp.sln`.
3. Установить `WeatherApp.Web` в качестве startup project.
4. Запустить приложение.

---

# WeatherApp — English

A web application that displays current weather conditions and a weather forecast for Moscow.

The application retrieves data from WeatherAPI and displays:

- current temperature and weather conditions;
- feels-like temperature;
- humidity, atmospheric pressure and wind;
- remaining hours of the current day;
- hourly forecast for the next day;
- 3-day weather forecast;
- loading state;
- error handling with the ability to retry the request.

## Technologies

- .NET 10
- ASP.NET Core
- Blazor Server (Interactive Server)
- MediatR
- System.Text.Json
- WeatherAPI

## Solution Structure

The solution consists of three projects:

### WeatherApp.Web

The Blazor Server user interface.

Responsible for displaying weather data, loading and error states, and retrying failed requests.

### WeatherApp.Application

Application layer.

Contains:

- application models;
- MediatR queries and handlers;
- abstractions for retrieving weather data.

### WeatherApp.Infrastructure

Infrastructure layer.

Contains:

- WeatherAPI integration;
- HTTP client;
- WeatherAPI response models;
- mapping of external API data to application models;
- infrastructure dependency registration.

## Weather Data

Weather data is retrieved from WeatherAPI using:

`forecast.json?days=3`

A single request provides current weather conditions, hourly forecast data, and the three-day forecast.

Moscow is configured using fixed coordinates in the application configuration.

## Running the Application

.NET 10 SDK is required.

1. Clone the repository.
2. Open `WeatherApp.sln`.
3. Set `WeatherApp.Web` as the startup project.
4. Run the application.
