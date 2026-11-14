# MediCord

A health management system built with C# Windows Forms and SQL Server Express.
Supports **SDG 3: Good Health and Well-being**.

## Features
**Patients (mobile-style interface)**
- Book, view and cancel appointments
- Medical records (view and download PDFs)
- Dependents: a guardian can manage and switch to a child's or OKU family member's profile
- Find nearby health facilities, sorted by city and state, with opening hours and details

**Facility admin / health workers (desktop interface)**
- Approve, decline, complete and reassign appointments
- Manage health workers and their working days
- Set facility details, opening hours and closed dates (with a check for existing appointments)

## Tech stack
- C# / .NET <version>, Windows Forms
- SQL Server Express (database `MedicordV1`)
- Siticone UI (NuGet), custom `Theme` helper

## Requirements
- Windows 10/11
- Visual Studio 2022 with the **.NET desktop development** workload
- SQL Server Express (instance `.\SQLEXPRESS`) and SSMS
- Internet on first build (NuGet restore)

## Setup
1. **Create the database:** open `Database/MedicordV1.sql` in SSMS and click Execute. It creates the `MedicordV1` database, tables, views and demo data.
2. **Open** `medicord_v1.sln` in Visual Studio.
3. **Check the connection string** in `App.config` / `Database.cs`. Change `.\SQLEXPRESS` if your instance has a different name.
4. Right-click the solution → **Restore NuGet Packages**, then press **F5**.

## Demo accounts
| Role | Email | Password |
|------|-------|----------|
| Patient | <email> | <password> |
| Facility admin | <email> | <password> |
| Health worker | <email> | <password> |

## Project structure
- `Screens/Patient`: mobile patient screens
- `Screens/Desktop`, `Screens/Worker`: facility admin and worker screens
- `Services/`: database access and business logic
- `Helpers/`: Theme, Nav, Msg, shared UI helpers
