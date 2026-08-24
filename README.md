# Schedulo

### Client Appointment Scheduling & Notification Platform

Schedulo is a professional appointment scheduling backend built with **C#, .NET 10, and ASP.NET Core Web API**. It is designed to provide a reliable, scalable, secure, and maintainable platform for managing clients, staff, services, appointments, availability, and automated email notifications.

The project follows **Clean Architecture** principles with a strong focus on separation of concerns, domain-driven business logic, scalability, performance, security, testability, and production-ready backend engineering practices.

> **Project Status:** 🚧 Under Active Development

---

## 📌 Overview

Schedulo is designed to solve the common problem of managing appointments between clients and service providers.

The platform will allow businesses to:

- Manage clients
- Manage staff members
- Manage business information
- Define and manage services
- Configure staff working hours
- Define holidays
- Define blocked time periods
- Calculate available appointment slots
- Create appointments
- Prevent conflicting bookings
- Confirm appointments
- Cancel appointments
- Reschedule appointments
- Complete appointments
- Send automated email notifications using SMTP
- Send appointment reminders
- Track notification delivery
- Authenticate users securely
- Authorize users based on roles
- Maintain audit information
- Monitor application health
- Handle errors consistently
- Provide a documented REST API

The primary goal is to build Schedulo as a **real-world backend system**, rather than a basic CRUD application.

---

# 🎯 Project Objectives

Schedulo is being developed with the following objectives:

- Clean and maintainable architecture
- Strong domain modelling
- Reliable appointment scheduling
- Conflict-free booking
- Secure authentication
- Role-based authorization
- Automated email notifications
- Background notification processing
- Database consistency
- API validation
- Centralized exception handling
- Structured logging
- Automated testing
- Containerized development
- CI/CD integration
- Production-oriented configuration
- Performance optimization
- Scalable application design

---

# 🏗️ Architecture

Schedulo follows **Clean Architecture**.

The application is divided into four primary layers:

```text
                         ┌─────────────────────────┐
                         │      Schedulo.Api       │
                         │                         │
                         │    ASP.NET Core Web API │
                         │    Controllers          │
                         │    Middleware           │
                         └────────────┬────────────┘
                                      │
                                      ▼
                         ┌─────────────────────────┐
                         │ Schedulo.Application    │
                         │                         │
                         │ Use Cases               │
                         │ Business Workflows      │
                         │ Validation              │
                         │ DTOs                    │
                         │ Application Services    │
                         └────────────┬────────────┘
                                      │
                                      ▼
                         ┌─────────────────────────┐
                         │    Schedulo.Domain      │
                         │                         │
                         │ Entities                │
                         │ Business Rules          │
                         │ Value Objects           │
                         │ Domain Events           │
                         │ Domain Exceptions       │
                         └─────────────────────────┘
                                      ▲
                                      │
                         ┌────────────┴────────────┐
                         │ Schedulo.Infrastructure │
                         │                         │
                         │ Entity Framework Core   │
                         │ SQL Server              │
                         │ SMTP                    │
                         │ Authentication          │
                         │ Repositories            │
                         │ External Services       │
                         └─────────────────────────┘

## Dependency Direction

The project follows the Dependency Inversion Principle.

```text
Schedulo.Api
      │
      ▼
Schedulo.Application
      │
      ▼
Schedulo.Domain


Schedulo.Infrastructure
      │
      ▼
Schedulo.Application
      │
      ▼
Schedulo.Domain