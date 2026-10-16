# WebDriver POM Example

A C# UI test automation project demonstrating the **Page Object Model (POM)** design pattern using Selenium WebDriver and NUnit.

The tests interact with a sample Students Registry web application and verify its navigation, page content and student registration functionality.

## Technologies

- C# / .NET 5
- Selenium WebDriver 4
- NUnit 3
- ChromeDriver

## Test Coverage

The project includes automated tests for:

- **Home Page:** Page title, heading, navigation and student count.
- **Add Student:** Page details, valid student registration and required-field validation.
- **View Students:** Page title, heading and basic verification of displayed student records.

## Project Structure

- `Pages/` — Page Object classes containing page elements and interaction methods.
- `Tests/` — NUnit test classes and shared browser setup/teardown.
- `WebDriver_POM_Example.sln` — Visual Studio solution.

## Running the Tests

1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Ensure Google Chrome and a compatible ChromeDriver are available.
4. Run the tests through Test Explorer.

**Note:** This is an educational project from 2022. The tests depend on an external sample Students Registry application, whose original URL may no longer be available. The project also uses older .NET and Selenium dependencies, so updates may be required before the tests can run successfully.

## Purpose

This project demonstrates foundational UI automation skills, including Page Object Model organisation, browser interactions, assertions and reusable test setup.
