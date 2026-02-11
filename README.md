# 🚀 Playwright & Selenium Automation Framework (C#)

## 📌 Overview

This project demonstrates my automation testing skills using **C# (.NET)**, combining modern UI automation, API testing, and structured test architecture.

It includes:

- 🎭 Playwright for modern UI automation
- 🌐 Selenium WebDriver for cross-browser testing
- 🔌 API Testing using HttpClient
- 🧪 NUnit as the test framework
- 🏗 Scalable and maintainable framework structure

The goal of this project is to showcase clean architecture, reusable components, and real-world QA automation practices.

---

## 🛠 Tech Stack

- **Language:** C# (.NET)
- **UI Automation:** Playwright & Selenium
- **API Testing:** HttpClient
- **Test Framework:** NUnit
- **Architecture:** Layered framework design
- **Design Patterns:** Factory Pattern, Base Test setup

---

## 📂 Project Structure

### Core/

├── Base/ Base test configuration and setup

├── Browser/ Playwright & Selenium factories

├── Api/ API client and HTTP utilities

### Test/

├── UI/ UI test cases

├── API/ API test cases


### 🔹 Core Layer
Responsible for:
- Driver initialization
- Browser management
- API reusable methods
- Test setup and teardown

### 🔹 Test Layer
Responsible for:
- UI test scenarios
- API test validation
- End-to-end integration tests

---

## ✅ Features Implemented

### UI Automation
- Login validation
- Negative login test
- Navigation flows
- Element assertions
- Locator-based validation (Playwright best practices)

### API Automation
- Create User (POST)
- Delete User (DELETE)
- JSON request handling
- x-www-form-urlencoded support
- Response validation (Status Code + Body)

### Framework Capabilities
- Async/Await implementation
- Reusable HTTP methods (Post, Delete, PostForm)
- Clean separation between API & UI
- Test Setup & TearDown hooks
- Dynamic test data (Guid for unique emails)

---

## 🧪 Trial Project

This repository represents a trial automation framework created for demonstration purposes.

The structure is modular and can be easily extended by adding new test cases, API endpoints, reporting tools, and CI/CD integration.

The framework is designed to be scalable and adaptable to real-world automation projects.
