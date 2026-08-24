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
                         │ Domain Events            │
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
                         
````
---
### Dependency Direction

Schedulo follows the Dependency Inversion Principle and Clean Architecture dependency rules.

The dependency direction is:

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
````
---
### Dependency Rules

* `Schedulo.Domain` must not depend on any other Schedulo project.
* `Schedulo.Application` may depend only on `Schedulo.Domain`.
* `Schedulo.Infrastructure` may depend on `Schedulo.Application` and `Schedulo.Domain`.
* `Schedulo.Api` may depend on `Schedulo.Application` and `Schedulo.Infrastructure`.
* Business rules must remain independent of ASP.NET Core.
* Infrastructure-specific implementations must not leak into the Domain layer.
* Controllers must remain thin and delegate business operations to Application services/use cases.

This keeps the core business logic independent from external technologies such as databases, SMTP providers, HTTP frameworks, and cloud services.

---

# 🧱 Architecture Principles

Schedulo follows the following architectural principles:

* Clean Architecture
* Domain-Driven Design principles
* SOLID principles
* Separation of Concerns
* Dependency Inversion
* Dependency Injection
* CQRS-style feature organization
* Repository Pattern where appropriate
* Unit of Work principles where appropriate
* Domain Events
* Asynchronous programming
* Fail-fast validation
* Secure-by-default design
* Testable business logic

---

# 🛠️ Technology Stack

## Backend

* C#
* .NET 10
* ASP.NET Core Web API
* Minimal APIs / Controllers where appropriate
* Dependency Injection
* Asynchronous Programming
* LINQ

## Architecture

* Clean Architecture
* Domain-Driven Design principles
* CQRS-style architecture
* SOLID
* Repository Pattern
* Domain Events
* Dependency Injection

## Database

* Microsoft SQL Server
* Entity Framework Core
* EF Core Migrations
* LINQ
* SQL

## Authentication & Authorization

Planned:

* JWT Authentication
* Refresh Tokens
* Role-Based Authorization
* Password Hashing
* Secure Token Management
* Token Expiration
* Token Rotation

## Email

Planned:

* SMTP
* HTML Email Templates
* Appointment Confirmation Emails
* Appointment Cancellation Emails
* Appointment Rescheduling Emails
* Appointment Reminder Emails
* Background Email Processing
* Email Delivery Tracking
* Retry Handling

## Validation

Planned:

* FluentValidation
* ASP.NET Core Model Validation
* Domain Validation
* Business Rule Validation
* Centralized Exception Handling
* Consistent API Error Responses

## API Documentation

* Swagger
* OpenAPI

## Testing

Planned:

* xUnit
* Unit Testing
* Integration Testing
* API Testing
* Domain Testing

## DevOps

Planned:

* Docker
* Docker Compose
* GitHub Actions
* CI/CD

## Version Control

* Git
* GitHub

## Development Environment

* Visual Studio Code
* macOS / Linux / Windows
* .NET CLI
* Bash / Zsh

---

# 📂 Project Structure

Current project structure:

```text
Schedulo/
│
├── Schedulo.slnx
│
├── src/
│   │
│   ├── Schedulo.Api/
│   │
│   ├── Schedulo.Application/
│   │
│   ├── Schedulo.Domain/
│   │
│   └── Schedulo.Infrastructure/
│
├── tests/
│
├── docs/
│
├── .gitignore
│
└── README.md
```

The target production-oriented structure is:

```text
Schedulo/
│
├── Schedulo.slnx
│
├── src/
│   │
│   ├── Schedulo.Api/
│   │   │
│   │   ├── Controllers/
│   │   ├── Middleware/
│   │   ├── Filters/
│   │   ├── Extensions/
│   │   ├── Contracts/
│   │   ├── Properties/
│   │   ├── Program.cs
│   │   ├── appsettings.json
│   │   └── appsettings.Development.json
│   │
│   ├── Schedulo.Application/
│   │   │
│   │   ├── Common/
│   │   │   ├── Interfaces/
│   │   │   ├── Behaviors/
│   │   │   ├── Exceptions/
│   │   │   ├── Models/
│   │   │   └── Mappings/
│   │   │
│   │   ├── Features/
│   │   │   ├── Authentication/
│   │   │   ├── Clients/
│   │   │   ├── Staff/
│   │   │   ├── Businesses/
│   │   │   ├── Services/
│   │   │   ├── Appointments/
│   │   │   ├── Availability/
│   │   │   └── Notifications/
│   │   │
│   │   └── DependencyInjection.cs
│   │
│   ├── Schedulo.Domain/
│   │   │
│   │   ├── Common/
│   │   │   ├── Entity.cs
│   │   │   ├── AuditableEntity.cs
│   │   │   └── IDomainEvent.cs
│   │   │
│   │   ├── Entities/
│   │   ├── Enums/
│   │   ├── ValueObjects/
│   │   ├── Events/
│   │   └── Exceptions/
│   │
│   └── Schedulo.Infrastructure/
│       │
│       ├── Persistence/
│       │   ├── Configurations/
│       │   ├── Migrations/
│       │   ├── Interceptors/
│       │   └── ScheduloDbContext.cs
│       │
│       ├── Repositories/
│       ├── Email/
│       ├── Authentication/
│       ├── Services/
│       ├── BackgroundJobs/
│       └── DependencyInjection.cs
│
├── tests/
│   │
│   ├── Schedulo.Domain.Tests/
│   │
│   ├── Schedulo.Application.Tests/
│   │
│   ├── Schedulo.Infrastructure.Tests/
│   │
│   └── Schedulo.Api.Tests/
│
├── docs/
│   ├── architecture.md
│   ├── database.md
│   ├── api.md
│   ├── security.md
│   └── deployment.md
│
├── Dockerfile
├── docker-compose.yml
├── .dockerignore
├── .gitignore
├── README.md
└── LICENSE
```

---

# 👤 User Roles

Schedulo supports a role-based user model.

```text
Client
Staff
BusinessAdmin
SuperAdmin
```

---

## Client

A Client can:

* Register
* Login
* Manage profile
* Browse businesses
* Browse services
* View available appointment slots
* Create appointments
* View personal appointments
* Cancel appointments
* Request rescheduling
* Receive email notifications
* View appointment history

---

## Staff

A Staff member can:

* Login
* View assigned appointments
* View availability
* Manage working hours
* Manage blocked time
* Confirm appointments
* Complete appointments
* Cancel appointments where permitted
* View appointment history

---

## Business Admin

A Business Admin can:

* Manage business information
* Manage staff
* Manage services
* Manage working hours
* Manage holidays
* Manage blocked time
* View appointments
* Manage business-level configuration
* View operational statistics

---

## Super Admin

A Super Admin can:

* Manage system users
* Manage businesses
* Monitor platform activity
* Manage system configuration
* Review audit logs
* Manage platform-level settings

---

# 🧩 Core Domain Entities

The core domain revolves around appointment scheduling.

Planned entities include:

```text
User
Business
ClientProfile
StaffProfile
Service
Appointment
WorkingHour
Holiday
BlockedTime
Notification
RefreshToken
AuditLog
```

---

# 🔗 Domain Relationships

Conceptual relationships:

```text
User
 │
 ├────────────────┐
 │                │
 ▼                ▼
Client          Staff
Profile         Profile
                  │
                  ▼
               Business
                  │
          ┌───────┼────────┐
          │       │        │
          ▼       ▼        ▼
       Service Working   Holiday
                Hours
                  │
                  ▼
             BlockedTime


Client
  │
  ▼
Appointment
  │
  ├── Service
  ├── Staff
  ├── Business
  └── Time Slot
```

---

# 📅 Appointment Lifecycle

Appointments follow a controlled lifecycle.

```text
                 ┌─────────────┐
                 │   Pending   │
                 └──────┬──────┘
                        │
                        ▼
                 ┌─────────────┐
                 │  Confirmed  │
                 └──────┬──────┘
                        │
                        ▼
                 ┌─────────────┐
                 │  Completed  │
                 └─────────────┘
```

Cancellation can occur from valid states:

```text
Pending ─────────► Cancelled

Confirmed ───────► Cancelled
```

Other possible states:

```text
NoShow
```

The Domain layer will enforce valid state transitions.

Invalid transitions must be rejected.

For example:

```text
Completed → Confirmed
Completed → Pending
Cancelled → Completed
```

should not be permitted unless an explicit business rule allows such a transition.

---

# 🕒 Appointment Scheduling Engine

The availability engine is one of the most important components of Schedulo.

Available appointment slots are calculated using:

```text
Business Working Hours
          +
Staff Working Hours
          +
Service Duration
          +
Existing Appointments
          +
Holidays
          +
Blocked Time
          +
Scheduling Rules
          +
Time Zone
          ↓
Available Appointment Slots
```

For example:

```text
Staff Working Hours

09:00 ─────────────────────────────── 17:00


Existing Appointment

11:00 ─────────── 12:00


Available Slots

09:00 ───── 10:00       AVAILABLE
10:00 ───── 11:00       AVAILABLE
11:00 ───── 12:00       UNAVAILABLE
12:00 ───── 13:00       AVAILABLE
13:00 ───── 14:00       AVAILABLE
14:00 ───── 15:00       AVAILABLE
15:00 ───── 16:00       AVAILABLE
16:00 ───── 17:00       AVAILABLE
```

The scheduling engine will consider:

* Appointment duration
* Staff availability
* Business availability
* Working hours
* Holidays
* Blocked periods
* Existing appointments
* Time zones
* Minimum booking notice
* Maximum booking window
* Slot interval
* Service duration
* Buffer time where applicable

---

# 🚫 Conflict Prevention

Schedulo must prevent overlapping appointments.

Example:

```text
Existing:

10:00 ───────── 11:00


New Request:

10:30 ───────── 11:30
```

The new appointment must be rejected.

Expected response:

```text
409 Conflict
```

Example:

```json
{
  "success": false,
  "message": "The selected appointment slot is no longer available."
}
```

Conflict detection will be handled at the application/domain level and reinforced with appropriate database constraints or concurrency strategies.

---

# 🔐 Concurrency Handling

Appointment scheduling is a concurrency-sensitive operation.

Example:

```text
Client A ──────┐
               │
               ▼
          Slot 10:00
               ▲
               │
Client B ──────┘
```

Only one request should successfully reserve the same appointment slot.

The system will use appropriate concurrency control techniques such as:

* Database transactions
* Unique constraints where applicable
* Optimistic concurrency
* Atomic operations
* Proper isolation levels where necessary
* Rechecking availability before persistence

The exact strategy will depend on the final database model.

---

# 📧 SMTP Email Notification System

Schedulo will support transactional email notifications using SMTP.

The architecture will be:

```text
Appointment Created
        │
        ▼
Application Layer
        │
        ▼
Notification Service
        │
        ▼
Background Processing
        │
        ▼
SMTP Email Service
        │
        ▼
SMTP Provider
        │
        ▼
Client Email
```

---

# ✉️ Email Notification Types

Schedulo will support:

## Appointment Confirmation

Sent when an appointment is successfully created or confirmed.

## Appointment Cancellation

Sent when an appointment is cancelled.

## Appointment Rescheduling

Sent when an appointment is rescheduled.

## Appointment Reminder

Sent before the scheduled appointment.

## Appointment Completion

Optional notification after the appointment is completed.

---

# ⚙️ Background Email Processing

Email delivery should not unnecessarily block the main appointment API request.

Instead of:

```text
API Request
    ↓
Create Appointment
    ↓
Send SMTP Email
    ↓
Wait
    ↓
API Response
```

Schedulo will move non-critical email work to background processing:

```text
API Request
    ↓
Create Appointment
    ↓
Create Notification
    ↓
Commit Transaction
    ↓
Return API Response
    │
    ▼
Background Worker
    ↓
SMTP
    ↓
Email
```

Benefits:

* Lower API latency
* Better user experience
* Retry capability
* Failure isolation
* Better scalability
* Easier monitoring

---

# 🔁 Email Retry Strategy

Email delivery failures should not immediately result in permanent failure.

The notification system will support:

```text
Pending
   │
   ▼
Processing
   │
   ├──────────────► Sent
   │
   ▼
Failed
   │
   ▼
Retry
   │
   ▼
Processing
```

After a configurable number of failures:

```text
Failed
   ↓
Dead Letter / Permanently Failed
```

Retry strategy may use exponential backoff.

Example:

```text
Attempt 1 → Immediate
Attempt 2 → Short delay
Attempt 3 → Longer delay
Attempt 4 → Final retry
```

---

# 🔐 Authentication

Schedulo will implement secure authentication.

Planned authentication flow:

```text
Register
   │
   ▼
Password Hashing
   │
   ▼
Login
   │
   ▼
JWT Access Token
   +
Refresh Token
```

Authentication features:

* User registration
* User login
* Password hashing
* JWT access tokens
* Refresh tokens
* Token expiration
* Refresh token rotation
* Logout
* Role-based authorization

---

# 🛡️ Authorization

Access to resources depends on the authenticated user's role.

Example:

```text
Client
   │
   └── Create / View / Manage own appointments


Staff
   │
   └── Manage assigned appointments


BusinessAdmin
   │
   ├── Manage staff
   ├── Manage services
   ├── Manage business
   └── Manage appointments


SuperAdmin
   │
   └── Platform-level management
```

Authorization must also verify resource ownership.

For example:

```text
Client A
    │
    └── Appointment A
```

Client A must not be able to access:

```text
Client B
    │
    └── Appointment B
```

simply by changing an appointment ID in the URL.

---

# 🌐 REST API

Schedulo exposes a versioned RESTful API.

Base URL:

```text
/api/v1
```

Planned modules:

```text
/api/v1/auth
/api/v1/users
/api/v1/clients
/api/v1/staff
/api/v1/businesses
/api/v1/services
/api/v1/appointments
/api/v1/availability
/api/v1/notifications
```

---

# 🔌 Example API Endpoints

## Authentication

```http
POST /api/v1/auth/register
POST /api/v1/auth/login
POST /api/v1/auth/refresh
POST /api/v1/auth/logout
```

---

## Appointments

```http
GET    /api/v1/appointments
GET    /api/v1/appointments/{id}
POST   /api/v1/appointments
POST   /api/v1/appointments/{id}/confirm
POST   /api/v1/appointments/{id}/cancel
POST   /api/v1/appointments/{id}/reschedule
POST   /api/v1/appointments/{id}/complete
```

---

## Availability

```http
GET /api/v1/availability
GET /api/v1/availability/staff/{staffId}
```

---

## Services

```http
GET    /api/v1/services
GET    /api/v1/services/{id}
POST   /api/v1/services
PUT    /api/v1/services/{id}
DELETE /api/v1/services/{id}
```

---

## Staff

```http
GET    /api/v1/staff
GET    /api/v1/staff/{id}
POST   /api/v1/staff
PUT    /api/v1/staff/{id}
DELETE /api/v1/staff/{id}
```

---

# 📊 Pagination

Large collections will support pagination.

Example:

```http
GET /api/v1/appointments?page=1&pageSize=20
```

Example response:

```json
{
  "items": [],
  "page": 1,
  "pageSize": 20,
  "totalCount": 100,
  "totalPages": 5
}
```

Pagination prevents unnecessarily large database queries and API responses.

---

# 🔎 Filtering & Searching

Appointment lists will support filtering.

Examples:

```http
GET /api/v1/appointments?status=confirmed
```

```http
GET /api/v1/appointments?staffId={staffId}
```

```http
GET /api/v1/appointments?date=2026-08-25
```

Additional filters may include:

* Date range
* Business
* Staff
* Client
* Service
* Status

---

# ⚠️ Error Handling

Schedulo will use centralized exception handling.

All API errors should follow a consistent response structure.

Example:

```json
{
  "success": false,
  "message": "The selected appointment slot is no longer available.",
  "errors": []
}
```

Expected HTTP status codes:

| Status | Meaning                                  |
| ------ | ---------------------------------------- |
| 200    | Successful request                       |
| 201    | Resource created                         |
| 204    | Successful request with no response body |
| 400    | Invalid request                          |
| 401    | Unauthorized                             |
| 403    | Forbidden                                |
| 404    | Resource not found                       |
| 409    | Resource conflict                        |
| 422    | Validation failure                       |
| 429    | Too many requests                        |
| 500    | Internal server error                    |

---

# 🧪 Validation

Schedulo will perform validation at multiple levels.

Validation examples:

```text
Invalid email
Invalid phone number
Invalid appointment date
Invalid appointment duration
Appointment in the past
Appointment outside working hours
Appointment on a holiday
Appointment during blocked time
Overlapping appointment
Unauthorized appointment modification
Invalid service
Inactive staff member
Inactive business
```

FluentValidation will be used for application-level request validation where appropriate.

Domain rules will remain inside the Domain layer.

---

# 🗄️ Database

Schedulo will use:

```text
Microsoft SQL Server
        +
Entity Framework Core
```

EF Core will provide:

* Object-relational mapping
* Database queries
* Relationships
* Transactions
* Migrations
* Change tracking
* Database configuration
* Query translation

---

# 🧱 Database Design

Expected tables:

```text
Users
Businesses
ClientProfiles
StaffProfiles
Services
Appointments
WorkingHours
Holidays
BlockedTimes
Notifications
RefreshTokens
AuditLogs
```

The final database design will include:

* Primary keys
* Foreign keys
* Unique constraints
* Indexes
* Appropriate data types
* Decimal precision
* Concurrency handling
* Referential integrity
* Soft deletion where appropriate

---

# 🔍 Database Performance

Database performance will be considered throughout development.

Techniques include:

* Proper indexing
* Query projection
* Pagination
* `AsNoTracking()` for read-only operations
* Avoiding N+1 queries
* Efficient LINQ queries
* Database constraints
* Async database operations
* Compiled queries where justified
* Query profiling
* Appropriate relationship loading

---

# 🔒 Security

Security is a core requirement.

Planned security features include:

* Password hashing
* JWT authentication
* Refresh token security
* Role-based authorization
* Resource-level authorization
* Input validation
* SQL injection protection through parameterized EF Core queries
* HTTPS
* CORS
* Rate limiting
* Secure HTTP headers
* Environment-specific configuration
* Secret management
* Sensitive-data protection
* Secure logging
* Audit logging

---

# 🔑 Secrets Management

Sensitive values must never be committed to Git.

Examples:

```text
Database Password
SMTP Username
SMTP Password
JWT Secret
API Keys
Encryption Keys
Refresh Token Secrets
```

Development secrets should use appropriate mechanisms such as:

```text
.NET User Secrets
Environment Variables
Docker Secrets
Production Secret Managers
```

Example:

```bash
dotnet user-secrets init
```

Secrets must never be hardcoded into:

```text
Program.cs
appsettings.json
Controllers
Services
Repositories
```

---

# 📝 Logging

Schedulo will use structured application logging.

Important events may include:

```text
UserRegistered
UserLoggedIn
AuthenticationFailed
AppointmentCreated
AppointmentConfirmed
AppointmentCancelled
AppointmentRescheduled
AppointmentCompleted
NotificationCreated
EmailSent
EmailFailed
```

Logs must never expose:

* Passwords
* JWT secrets
* SMTP passwords
* Refresh tokens
* Authorization headers
* Sensitive personal information

---

# 📋 Audit Logging

Important business operations may be recorded in an audit log.

Example:

```text
User
  │
  ▼
Appointment Cancellation
  │
  ▼
AuditLog
```

Example audit information:

```text
UserId
Action
EntityType
EntityId
Timestamp
IP Address
User Agent
Additional Metadata
```

Audit logging will be implemented carefully to avoid storing unnecessary sensitive information.

---

# ❤️ Health Checks

Schedulo will expose application health information.

Example:

```http
GET /health
```

Health checks may verify:

```text
Application
    │
    ├── Database
    │
    ├── SMTP Configuration
    │
    └── External Dependencies
```

Health checks will distinguish between:

```text
Healthy
Degraded
Unhealthy
```

---

# 📈 Observability

The system will be designed to support:

* Structured logging
* Health checks
* Application metrics
* Request tracing
* Error monitoring
* Database performance monitoring
* Background job monitoring
* Email delivery monitoring

Observability tooling may be added during production hardening.

---

# 🧪 Testing Strategy

Schedulo will use multiple levels of testing.

---

## Unit Testing

Unit tests will primarily target:

* Domain logic
* Appointment state transitions
* Availability calculations
* Scheduling rules
* Validation
* Application use cases

Example tests:

```text
CanBookAvailableSlot
CannotBookOverlappingAppointment
CannotBookOutsideWorkingHours
CannotBookDuringHoliday
CannotBookDuringBlockedTime
CanCancelAppointment
CanConfirmAppointment
CanRescheduleAppointment
CannotRescheduleCompletedAppointment
CannotCancelCompletedAppointment
```

---

## Integration Testing

Integration tests will verify:

```text
API
 ↓
Application
 ↓
Infrastructure
 ↓
Database
```

Integration testing may use a dedicated test database or an appropriate isolated database environment.

---

## API Testing

API tests will verify:

* Authentication
* Authorization
* HTTP status codes
* Request validation
* Response structure
* Appointment workflows
* Error handling
* Pagination
* Filtering

---

# 🐳 Docker

Schedulo will support containerized development and deployment.

Expected architecture:

```text
┌────────────────────────────┐
│       Schedulo API         │
│       ASP.NET Core         │
└──────────────┬─────────────┘
               │
               ▼
┌────────────────────────────┐
│        SQL Server          │
└────────────────────────────┘
```

Expected files:

```text
Dockerfile
docker-compose.yml
.dockerignore
```

---

# 🚀 CI/CD

GitHub Actions will automate the build and test pipeline.

Expected workflow:

```text
Developer
    │
    ▼
Git Push
    │
    ▼
GitHub
    │
    ▼
GitHub Actions
    │
    ├── Restore
    │
    ├── Build
    │
    ├── Test
    │
    ├── Security Checks
    │
    ├── Publish
    │
    └── Deployment
```

---

# 📖 API Documentation

Schedulo will provide API documentation using:

* Swagger
* OpenAPI

Documentation will include:

* Endpoints
* Request bodies
* Response bodies
* Authentication
* Status codes
* Validation errors
* Example requests
* Example responses

---

# 📈 Performance Goals

Schedulo prioritizes:

* Low API latency
* Efficient database queries
* Async I/O
* Efficient availability calculations
* Minimal unnecessary database calls
* Background processing for non-critical work
* Proper indexing
* Pagination
* Caching where beneficial
* Resource-efficient architecture

Performance should be measured using actual benchmarks and profiling rather than arbitrary performance claims.

---

# ⚡ Performance Considerations

The following areas will receive special attention:

## API Performance

* Async controller actions
* Async application services
* Async EF Core queries
* Response pagination
* Efficient DTO projections

## Database Performance

* Proper indexes
* Query optimization
* No unnecessary eager loading
* `AsNoTracking()` for read-only queries
* Avoiding N+1 queries

## Scheduling Performance

The availability engine should avoid repeatedly loading unnecessary appointment data.

The system should retrieve only the data required to calculate availability.

## Email Performance

SMTP email sending should not block appointment creation.

Email delivery should be processed asynchronously.

---

# 🧠 Engineering Principles

Schedulo follows:

## SOLID

### Single Responsibility Principle

Each class should have one clear responsibility.

### Open/Closed Principle

Components should be extendable without unnecessary modification.

### Liskov Substitution Principle

Implementations should correctly substitute their abstractions.

### Interface Segregation Principle

Interfaces should remain focused and minimal.

### Dependency Inversion Principle

High-level business logic should depend on abstractions rather than infrastructure implementations.

---

## Additional Principles

* DRY
* KISS
* Separation of Concerns
* Explicit validation
* Fail-fast behavior
* Asynchronous programming
* Secure-by-default design
* Testable business logic
* Maintainable code
* Performance-aware development
* Clean Code

---

# 🌿 Git Workflow

Recommended branch structure:

```text
main
│
├── develop
│
├── feature/domain-model
├── feature/appointment-scheduling
├── feature/authentication
├── feature/email-notifications
├── feature/availability-engine
├── feature/testing
└── feature/docker
```

Example:

```bash
git checkout -b feature/appointment-scheduling
```

---

# 📝 Commit Convention

Recommended commit format:

```text
feat: add appointment domain model
feat: implement appointment availability
feat: add SMTP notification service
feat: implement JWT authentication

fix: prevent overlapping appointments
fix: correct appointment timezone handling

test: add appointment conflict tests
test: add availability engine tests

refactor: improve appointment repository

docs: update API documentation

chore: update dependencies
```

---

# 🗺️ Development Roadmap

| Phase | Feature                  | Status         |
| ----- | ------------------------ | -------------- |
| 1     | Project Foundation       | ✅ Completed    |
| 2     | Domain Foundation        | 🔄 In Progress |
| 3     | Scheduling Domain        | ⏳ Planned      |
| 4     | Entity Framework Core    | ⏳ Planned      |
| 5     | SQL Server Database      | ⏳ Planned      |
| 6     | Database Migrations      | ⏳ Planned      |
| 7     | Repository / Persistence | ⏳ Planned      |
| 8     | Application Use Cases    | ⏳ Planned      |
| 9     | Authentication           | ⏳ Planned      |
| 10    | Authorization            | ⏳ Planned      |
| 11    | Appointment APIs         | ⏳ Planned      |
| 12    | Availability Engine      | ⏳ Planned      |
| 13    | SMTP Email Notifications | ⏳ Planned      |
| 14    | Background Notifications | ⏳ Planned      |
| 15    | Validation               | ⏳ Planned      |
| 16    | Exception Handling       | ⏳ Planned      |
| 17    | Logging                  | ⏳ Planned      |
| 18    | Health Checks            | ⏳ Planned      |
| 19    | Unit Tests               | ⏳ Planned      |
| 20    | Integration Tests        | ⏳ Planned      |
| 21    | Docker                   | ⏳ Planned      |
| 22    | Swagger / OpenAPI        | ⏳ Planned      |
| 23    | Security Hardening       | ⏳ Planned      |
| 24    | Performance Optimization | ⏳ Planned      |
| 25    | CI/CD                    | ⏳ Planned      |
| 26    | Documentation            | ⏳ Planned      |
| 27    | Production Polish        | ⏳ Planned      |

---

# 💻 Local Development

## Prerequisites

Install:

* .NET 10 SDK
* Git
* Docker
* Docker Compose
* Visual Studio Code
* SQL Server or SQL Server through Docker

---

# 🔍 Verify Installation

Check .NET:

```bash
dotnet --version
```

Check Git:

```bash
git --version
```

Check Docker:

```bash
docker --version
```

Check Docker Compose:

```bash
docker compose version
```

Check Entity Framework CLI:

```bash
dotnet ef --version
```

---

# ▶️ Running the Application

From the project root:

```bash
dotnet run --project src/Schedulo.Api
```

Build the complete solution:

```bash
dotnet build
```

Restore dependencies:

```bash
dotnet restore
```

Run tests:

```bash
dotnet test
```

---

# 🗃️ Entity Framework Core

Create a migration:

```bash
dotnet ef migrations add InitialCreate \
  --project src/Schedulo.Infrastructure \
  --startup-project src/Schedulo.Api
```

Update the database:

```bash
dotnet ef database update \
  --project src/Schedulo.Infrastructure \
  --startup-project src/Schedulo.Api
```

List migrations:

```bash
dotnet ef migrations list \
  --project src/Schedulo.Infrastructure \
  --startup-project src/Schedulo.Api
```

---

# ⚙️ Configuration

Application configuration will be environment-specific.

Expected configuration sources:

```text
appsettings.json
appsettings.Development.json
Environment Variables
.NET User Secrets
Docker Configuration
Production Secret Management
```

Configuration categories include:

```text
Database
JWT
SMTP
Logging
CORS
Application
Scheduling
```

Sensitive credentials should never be stored directly in source control.

---

# 🧪 Development Commands

Build:

```bash
dotnet build
```

Run API:

```bash
dotnet run --project src/Schedulo.Api
```

Run tests:

```bash
dotnet test
```

Clean:

```bash
dotnet clean
```

Restore:

```bash
dotnet restore
```

---

# 📦 Deployment

Schedulo is designed with future production deployment in mind.

Potential deployment environments include:

* Docker
* Microsoft Azure
* AWS
* DigitalOcean
* VPS
* Kubernetes
* Other container-compatible platforms

The final deployment strategy will depend on infrastructure requirements.

---

# 🔮 Future Enhancements

Potential future features include:

* Recurring appointments
* Multiple business locations
* Multi-tenant architecture
* Google Calendar integration
* Microsoft Outlook integration
* SMS notifications
* WhatsApp notifications
* Custom email templates
* Appointment analytics
* Business dashboards
* Customer reviews
* Payment integration
* Subscription plans
* Calendar synchronization
* Time-zone aware scheduling
* Advanced reporting
* Waitlists
* Automated reminders
* Customer notification preferences
* Staff notification preferences
* Business notification policies

These features are outside the initial MVP scope and may be introduced after the core scheduling system is stable.

---

# 🎓 Portfolio Objective

Schedulo is being developed as a professional portfolio project demonstrating practical backend engineering using the modern .NET ecosystem.

The project focuses on:

```text
C#
   +
.NET 10
   +
ASP.NET Core
   +
Clean Architecture
   +
Domain Modeling
   +
Entity Framework Core
   +
SQL Server
   +
JWT Authentication
   +
Role-Based Authorization
   +
Appointment Scheduling
   +
Availability Engine
   +
SMTP
   +
Background Processing
   +
Validation
   +
Testing
   +
Docker
   +
CI/CD
   +
Production Engineering
```

The objective is not simply to build a CRUD application.

The objective is to demonstrate how a real-world backend system can be:

* Architected
* Designed
* Implemented
* Tested
* Secured
* Optimized
* Containerized
* Documented
* Monitored
* Deployed

---

# 📊 Project Status

Current status:

```text
🚧 Active Development
```

Current phase:

```text
Phase 2 — Domain Foundation
```

Completed:

```text
✅ .NET 10 SDK setup
✅ ASP.NET Core Web API project
✅ Clean Architecture project structure
✅ Domain project
✅ Application project
✅ Infrastructure project
✅ API project
✅ Solution configuration
✅ Initial solution build
```

Currently working on:

```text
🔄 Domain entities
🔄 Domain enums
🔄 Scheduling domain model
🔄 Appointment business rules
```

Upcoming:

```text
⏳ SQL Server
⏳ Entity Framework Core
⏳ Database configurations
⏳ Database migrations
⏳ Repository layer
⏳ Application use cases
⏳ JWT Authentication
⏳ Role-Based Authorization
⏳ Appointment APIs
⏳ Availability Engine
⏳ SMTP Notifications
⏳ Background Processing
⏳ Validation
⏳ Global Exception Handling
⏳ Logging
⏳ Health Checks
⏳ Unit Testing
⏳ Integration Testing
⏳ Docker
⏳ Swagger / OpenAPI
⏳ CI/CD
⏳ Performance Optimization
⏳ Production Hardening
```

---

# 👨‍💻 Author

**Om Kushwaha**

B.Tech — Information Technology

GitHub:

[https://github.com/omkushwaha9](https://github.com/omkushwaha9)

LinkedIn:

[https://www.linkedin.com/in/omkushwaha9/](https://www.linkedin.com/in/omkushwaha9/)

---

# 📄 License

This project is currently intended as a portfolio and learning project.

A formal open-source license will be added before the first stable public release.

Copyright © 2026 Om Kushwaha.

```
```
