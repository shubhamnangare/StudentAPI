# Student API

A REST API for managing student records using .NET 8

## Features

- Create new student
- Read student details
- Update student information  
- Delete student records
- RESTful API endpoints

## Technologies Used

- .NET 8
- C#
- Entity Framework Core
- SQL Server

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/students | Get all students |
| GET | /api/students/{id} | Get student by ID |
| POST | /api/students | Create new student |
| PUT | /api/students/{id} | Update student |
| DELETE | /api/students/{id} | Delete student |

## Setup Instructions

```bash
git clone https://github.com/shubhamnangare/StudentAPI.git
cd StudentAPI
dotnet restore
dotnet run


MIT License
---

### Tarika 2: Command Line se (Agar command line pasand ho)

```bash
echo "# Student API" > README.md
echo "" >> README.md
echo "A REST API for managing student records using .NET 8" >> README.md
echo "" >> README.md
echo "## Features" >> README.md
echo "- Create, Read, Update, Delete students" >> README.md
echo "- RESTful API endpoints" >> README.md
echo "" >> README.md
echo "## Setup Instructions" >> README.md
echo '```' >> README.md
echo "git clone https://github.com/shubhamnangare/StudentAPI.git" >> README.md
echo "dotnet restore" >> README.md
echo "dotnet run" >> README.md
echo '```' >> README.md

git add README.md
git commit -m "Fix README formatting"
git push origin main
