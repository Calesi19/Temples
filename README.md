
![Temples API Banner](docs/banner.png)


# LDS Temples API

## Overview
This repository contains the LDS Temples API, a comprehensive resource for accessing information about Latter-day Saint (LDS) temples. Designed with efficiency and ease of use in mind, it offers detailed data about each temple, including location, history, and other relevant details.

## Features

Comprehensive Temple Data: Access detailed information about each LDS temple.
Search and Filter: Easily search for temples by various criteria.
Regular Updates: The database is regularly updated with the latest information.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

# Task Tamer

A simple to do list api to practice creating a .NET Web API. This Repo serves a reference guide for creating .NET APIs.

# How to run the project

## Setup the database.

1. Install Docker
2. Create a Docker account.
3. Run the following command to start a Postgres container.

```bash
docker run --name temples_db -p 5432:5432 -e POSTGRES_PASSWORD=Pioneer47 -e POSTGRES_USER=brigham -e POSTGRES_DB=temples_db -d postgres
```

## Setup the API
1. Clone the project
```bash
git clone https://github.com/Calesi19/FaveFinder.git
```

2. Install the dependencies
```bash
dotnet restore
```

3. Run the project
```bash
dotnet run
```

4. Open your browser and go to `http://localhost:5000`

# Create and Run a Docker Image

1. Create the image with the code by running the following command:
```bash
docker build -t tasktamer .
```
2. Run the docker image by running the command:
```bash
docker run -p 8080:8080 -p 8081:8081 tasktamer
```



# Packages

* Npgsql.EntityFrameworkCore.PostgreSQL
* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.Design

# Managing Packages

You can install/remove a package by running the following commands:
```bash
# To install a package
dotnet add package <package-name>

# To update a package
dotnet add package <package-name> --version <new-version>

# To remove a package
dotnet remove package <package-name>
```

# Run Migrations

Make sure to have the dotnet-ef tool installed.

```bash
dotnet tool install --global dotnet-ef
```

Once a model has been created and added to the DataAccess class, run the following migration commands on the terminal to create the tables in the database.

```bash
dotnet ef migrations add <Nameofthemigration>
dotnet ef database update
```
Replace <Nameofthemigration> with a name you'd like to give your migration. Don't use spaces.


# Helpful Resources

* [Postgres Setup with .NET Entity Framework](https://www.youtube.com/watch?v=z7G6HV7WWz0)
* [.NET API Guide](https://www.youtube.com/playlist?list=PL82C6-O4XrHdiS10BLh23x71ve9mQCln0)

# Tutorial Guide

To create a .NET Web API, you need to have the .NET Core SDK installed on your machine.

You can run the following command to bootstrap a new .NET Web API project.
```bash
dotnet new webapi -n Temples
```

To create a sln file, run the following command:
```bash
dotnet new sln
```
To add a project to the solution, run the following command:
```bash
dotnet sln something.sln add something/something.csproj
```


# Testing
Swagger is a great tool to document your API and will come pre-installed with the project. To access the Swagger UI, run the project and go to `/swagger/index.html` page when you start your API.