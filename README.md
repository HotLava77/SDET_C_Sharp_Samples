# SDET_C_Sharp_Samples
This project showcases my SDET skills using C# and Selenium. It automates login testing with NUnit, structured test setup/teardown, and ChromeDriver integration. Designed for real-world QA scenarios.

# Selenium Login Automation with C# and NUnit

This project is a simple yet professional **login test automation** script built in **C# using Selenium WebDriver and NUnit**.  
It simulates a valid login on [SauceDemo.com](https://www.saucedemo.com/v1/) to demonstrate automated browser interaction.

---

## Tech Stack

- **Language:** C#
- **Testing Framework:** NUnit
- **Automation Library:** Selenium WebDriver
- **Browser Driver:** ChromeDriver
- **IDE:** Visual Studio 2022

---

## Test Covered

- Launch browser and navigate to login page
- Input valid credentials
- Submit the login form
- Assert login success by verifying presence of `"Products"` text

---

## Project Structure

LoginAutomationTest/
|--LoginTest.cs          // Main test class
  |--LoginAutomationTest.csproj
  |--.sln file             // Visual Studio solution file
  |--README.md             // This file

