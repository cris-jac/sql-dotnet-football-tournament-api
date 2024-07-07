# Football Tournament API

## Description

EN: <BR>
.NET API designed for manage Football tournaments, the matches, the teams/clubs and the players. The matches are created and then they can be updated with the corresponding result. The result of each match will affect their standing in the tournament, taking into account points, goals, wins and losses.

ES: <br>
API de .NET diseñada para gestionar torneos de fútbol, ​​los partidos, los equipos/clubes y los jugadores. Los partidos se crean y luego se pueden actualizar con el resultado correspondiente. El resultado de cada partido afectará la posición de cada equipo en el torneo, teniendo en cuenta puntos, goles, victorias y derrotas.
<br>
<br>

## Features

EN:

- Authentication credentials verified with json web tokens (JWT)
- DAL management with Entity Framework
- Repository design pattern
- Clean architecture
- Exception handling middleware

ES:

- Credenciales de autenticación verificadas con json web tokens (JWT)
- Gestión de DAL con Entity Framework
- Patrón de diseño Repository.
- Arquitectura Clean
- Middleware de manejo de excepciones

## Requirements

- .NET 6
- SQLite
  <br>

## Extra Resources

![api-diagram-football](https://github.com/cris-jac/sql-dotnet-football-tournament-api/assets/57887225/ba06a7e2-b03b-45da-b53f-9e33722dd782)

<br>
<br>

## Installation

#### Steps (EN)

1. Clone from github, using this command:<br>
   `git clone https://github.com/cris-jac/sql-dotnet-football-tournament-api.git`

2. Navigate to the repository folder:<br>
   `cd sql-dotnet-football-tournament-api`

3. Build app:<br>
   `dotnet build`

4. Set environmental variables (Connection String and JwtSettings) in 'Laboratorio/appsettings.json'

5. Run the app:<br>
   `dotnet run`
   <br>

#### Pasos (ES)

1. Clonar repositorio, usando este comando:<br>
   `git clone https://github.com/cris-jac/sql-dotnet-football-tournament-api.git`

2. Navegar a directorio del repositorio:<br>
   `cd sql-dotnet-football-tournament-api`

3. Levantar app:<br>
   `dotnet build`

4. Definir variables de entorno (Connection String and JwtSettings) en 'Laboratorio/appsettings.json'

5. Correr la aplicacion:<br>
   `dotnet run`
   <br>

<br>

## API endpoints

### Authentication

#### Login (Iniciar sesión)

```http
POST /Auth/Login
```

#### Register (Registrar)

```http
POST /Auth/register
```

<br>

---

### Club

#### Get Clubs (Obtener clubes)

```http
GET /Club
```

#### Get Club by ID (Obtener club por ID)

```http
GET /Club/{id}
```

| Parameter | Type     | Description                           |
| :-------- | :------- | :------------------------------------ |
| `id`      | `string` | **Required**. ID of the club to fetch |

#### Get Players of Club (Obtener jugadores del club)

```http
GET /Club/{id}/players
```

| Parameter | Type     | Description                  |
| :-------- | :------- | :--------------------------- |
| `id`      | `string` | **Required**. ID of the club |

#### Delete Club (Eliminar club)

```http
DELETE /Club/{id}
```

| Parameter | Type     | Description                            |
| :-------- | :------- | :------------------------------------- |
| `id`      | `string` | **Required**. ID of the club to delete |

<br>

---

### Matches

#### Get Matches (Obtener partidos)

```http
GET /Matches
```

#### Get Match by ID (Obtener partido por ID)

```http
GET /Matches/{id}
```

| Parameter | Type     | Description                            |
| :-------- | :------- | :------------------------------------- |
| `id`      | `string` | **Required**. ID of the match to fetch |

#### Create Match (Crear partido)

```http
POST /Matches
```

#### Update Match (Actualizar partido)

```http
PUT /Matches/{id}
```

| Parameter | Type     | Description                             |
| :-------- | :------- | :-------------------------------------- |
| `id`      | `string` | **Required**. ID of the match to update |

<br>

---

### Players

#### Get Player by ID (Obtener jugador por ID)

```http
GET /Players/{id}
```

| Parameter | Type     | Description                             |
| :-------- | :------- | :-------------------------------------- |
| `id`      | `string` | **Required**. ID of the player to fetch |

#### Get Player by Number (Obtener jugador por número)

```http
GET /Players/{number}/player
```

| Parameter | Type     | Description                        |
| :-------- | :------- | :--------------------------------- |
| `number`  | `string` | **Required**. Number of the player |

#### Create Player (Crear jugador)

```http
POST /Players
```

#### Update Player (Actualizar jugador)

```http
PUT /Players/{id}
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :--------------------------------------- |
| `id`      | `string` | **Required**. ID of the player to update |

#### Delete Player (Eliminar jugador)

```http
DELETE /Players/{id}
```

| Parameter | Type     | Description                              |
| :-------- | :------- | :--------------------------------------- |
| `id`      | `string` | **Required**. ID of the player to delete |

<br>

---

### Standings

#### Get Standings (Obtener clasificaciones)

```http
GET /Standings
```

#### Get Standing by ID (Obtener clasificación por ID)

```http
GET /Standings/{id}
```

| Parameter | Type     | Description                               |
| :-------- | :------- | :---------------------------------------- |
| `id`      | `string` | **Required**. ID of the standing to fetch |

#### Get Standings by Club ID (Obtener clasificaciones por ID de club)

```http
GET /Standings/{clubId}/standing
```

| Parameter | Type     | Description                  |
| :-------- | :------- | :--------------------------- |
| `clubId`  | `string` | **Required**. ID of the club |

#### Delete Standing (Eliminar clasificación)

```http
DELETE /Standings/{id}
```

| Parameter | Type     | Description                                |
| :-------- | :------- | :----------------------------------------- |
| `id`      | `string` | **Required**. ID of the standing to delete |

<br>

---

### Tournaments

#### Get Tournaments (Obtener torneos)

```http
GET /Tournaments
```

#### Get Tournament by ID (Obtener torneo por ID)

```http
GET /Tournaments/{id}
```

| Parameter | Type     | Description                                 |
| :-------- | :------- | :------------------------------------------ |
| `id`      | `string` | **Required**. ID of the tournament to fetch |

#### Create Tournament (Crear torneo)

```http
POST /Tournaments
```
