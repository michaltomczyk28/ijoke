# IJoke (PAC1)

## Why and what?

We want to provide a convenient, modern-looking web application that allows users to read, add, and like jokes.

## How?

### Tech stack

* React
* TypeScript
* ASP.NET Core
* PostgreSQL
* Github Actions
* Docker

## Conventions

We use [Conventional commits](https://www.conventionalcommits.org/en/v1.0.0/) for commit messages.

## Running the application locally

You need to have the Docker installed.

### Startup

Run the following command:

```shell
docker compose up --build -d
```

Backend is available at: http://localhost:8080 \
Postgresql is available at: http://localhost:5430