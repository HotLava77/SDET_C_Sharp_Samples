# SDET_C_Sharp_Samples

This project showcases my SDET skills using C# and Selenium. It automates login testing with NUnit, structured test setup/teardown, and ChromeDriver integration. Designed for real-world QA scenarios.

# Selenium Login Automation with C# and NUnit

This project is a simple yet professional **login test automation** script built in **C# using Selenium WebDriver and NUnit**.  
It simulates valid and invalid login scenarios on [SauceDemo.com](https://www.saucedemo.com/v1/) to demonstrate automated browser interaction and error handling.

---

## Tech Stack

- **Language:** C#
- **Testing Framework:** NUnit
- **Automation Library:** Selenium WebDriver
- **Browser Driver:** ChromeDriver
- **IDE:** Visual Studio 2022

---

## Tests Covered

- Launch browser and navigate to login page
- Input valid credentials and assert successful login by verifying `"Products"` text
- Input invalid credentials and assert proper error handling by verifying `"Epic sadface"` message
- Capture screenshot on failure
- Use structured setup and teardown methods to manage browser lifecycle

---

## Project Structure

LoginAutomationTest/  
├── LoginTest.cs          // Main test class  
├── LoginAutomationTest.csproj  
├── LoginAutomationTest.sln  // Visual Studio solution file  
└── README.md             // This file

---

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/YOUR-USERNAME/SDET_C_Sharp_Samples.git
