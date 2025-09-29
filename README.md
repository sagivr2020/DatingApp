# Dating App - Full Stack Application

A full-stack dating application built with Angular 9 frontend and .NET 8 API backend, featuring user authentication, photo uploads, messaging, and matching functionality.

## 🚀 Quick Start

### Prerequisites

- **Node.js** (v16 or higher) - [Download](https://nodejs.org/)
- **.NET 8 SDK** - [Download](https://dotnet.microsoft.com/download/dotnet/8.0)
- **PostgreSQL** - [Download](https://www.postgresql.org/download/)
- **Angular CLI** - Install globally: `npm install -g @angular/cli@9`

### 📦 Installation & Setup

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd DatingApp
   ```

2. **Set up PostgreSQL Database**
   ```bash
   # Create database and user
   psql -U postgres
   CREATE DATABASE datingapp;
   CREATE USER appuser WITH PASSWORD 'Pa$$w0rd';
   GRANT ALL PRIVILEGES ON DATABASE datingapp TO appuser;
   \q
   ```

3. **Configure Backend (.NET API)**
   ```bash
   cd DatingApp.API
   
   # Copy environment file and update with your values
   cp .env.example .env
   # Edit .env with your actual credentials (see Configuration section below)
   
   # Install dependencies
   dotnet restore
   
   # Update database with migrations
   dotnet ef database update
   
   # Seed database with sample users
   dotnet run
   ```

4. **Configure Frontend (Angular)**
   ```bash
   cd ../DatingApp-SPA
   
   # Install dependencies
   npm install
   
   # Start development server
   npm start
   ```

### 🔧 Configuration

#### Environment Variables Setup

The application uses environment variables for sensitive configuration. Copy the example file and update with your values:

```bash
cd DatingApp.API
cp .env.example .env
```

Edit the `.env` file with your actual credentials:

```bash
# JWT Configuration
JWT_SECRET=your-jwt-secret-key-at-least-64-characters-long

# Database Configuration
DB_HOST=localhost
DB_PORT=5432
DB_USER=your-db-username
DB_PASSWORD=your-db-password
DB_NAME=datingapp

# Cloudinary Configuration (Sign up at https://cloudinary.com/)
CLOUDINARY_CLOUD_NAME=your-cloudinary-cloud-name
CLOUDINARY_API_KEY=your-cloudinary-api-key
CLOUDINARY_API_SECRET=your-cloudinary-api-secret
```

#### Cloudinary Setup (for photo uploads)
1. Sign up at [Cloudinary](https://cloudinary.com/)
2. Get your credentials from the dashboard
3. Update the Cloudinary variables in your `.env` file

> **⚠️ Important**: The `.env` file is ignored by git to keep your credentials secure. Never commit sensitive data to version control!

### 🏃‍♂️ Running the Application

#### Start Backend API
```bash
cd DatingApp.API
export PATH="/usr/local/share/dotnet:/opt/homebrew/bin:$PATH"  # macOS only
dotnet run
```
Backend will run on: `http://localhost:5000`

#### Start Frontend
```bash
cd DatingApp-SPA
export NODE_OPTIONS="--openssl-legacy-provider"  # For Node.js compatibility
npm start
```
Frontend will run on: `http://localhost:4200`

### 🔐 Default Login Credentials

The database is seeded with sample users. You can login with:
- **Username**: `freda`
- **Password**: `password`

(Or any other seeded user from the sample data)

### 🛠️ Development Commands

#### Backend (.NET API)
```bash
# Run in development mode
dotnet run

# Run database migrations
dotnet ef database update

# Create new migration
dotnet ef migrations add MigrationName

# Build project
dotnet build

# Run tests
dotnet test
```

#### Frontend (Angular)
```bash
# Start development server
npm start
# or
ng serve

# Build for production
npm run build
# or
ng build --prod

# Run tests
ng test

# Run linting
ng lint

# Generate component
ng generate component component-name
```

### 📁 Project Structure

```
DatingApp/
├── DatingApp.API/          # .NET 8 Web API Backend
│   ├── Controllers/        # API Controllers
│   ├── Data/              # Entity Framework & Repository
│   ├── DTO/               # Data Transfer Objects
│   ├── Helpers/           # Utility classes
│   ├── Models/            # Entity models
│   └── Program.cs         # Application entry point
├── DatingApp-SPA/         # Angular 9 Frontend
│   ├── src/
│   │   ├── app/           # Angular components & services
│   │   ├── environments/  # Environment configurations
│   │   └── assets/        # Static assets
│   └── package.json
└── README.md
```

### ✨ Features

- 🔐 **User Authentication** - JWT-based login/registration
- 👤 **User Profiles** - Detailed user profiles with photos
- 📸 **Photo Upload** - Cloudinary integration for image management
- 💬 **Real-time Messaging** - User-to-user messaging system
- ❤️ **Matching System** - Like/unlike functionality
- 📱 **Responsive Design** - Mobile-friendly interface
- 🔍 **User Search** - Filter users by age, location, etc.
- 📄 **Pagination** - Efficient data loading

### 🐛 Troubleshooting

#### Common Issues

1. **Port 5000 conflict (macOS AirPlay)**
   - Change API port in `launchSettings.json` to 5001
   - Update Angular `environment.ts` API URL accordingly

2. **Node.js OpenSSL Error**
   - Use: `NODE_OPTIONS="--openssl-legacy-provider" npm start`

3. **Database connection issues**
   - Ensure PostgreSQL is running
   - Verify connection string in `appsettings.Development.json`
   - Check user permissions

4. **Photo upload not working**
   - Verify Cloudinary credentials
   - Check browser console for errors

5. **Database null reference errors**
   - Some existing photos may have null `PublicID` values
   - Run `dotnet ef database drop` and `dotnet ef database update` to recreate with fresh data

### 📚 Technology Stack

**Backend:**
- .NET 8 Web API
- Entity Framework Core 8
- PostgreSQL
- JWT Authentication
- AutoMapper
- Cloudinary (Image hosting)

**Frontend:**
- Angular 9
- TypeScript
- Bootstrap 4
- ng2-file-upload
- JWT handling

### 🤝 Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Run tests
5. Submit a pull request

### 📄 License

This project is licensed under the MIT License.

---

## 🎯 Getting Started Checklist

- [ ] Install prerequisites (Node.js, .NET 8, PostgreSQL)
- [ ] Clone repository
- [ ] Set up PostgreSQL database
- [ ] Configure `appsettings.Development.json`
- [ ] Run `dotnet ef database update`
- [ ] Start backend with `dotnet run`
- [ ] Install Angular dependencies with `npm install`
- [ ] Start frontend with `npm start`
- [ ] Navigate to `http://localhost:4200`
- [ ] Login with demo credentials
- [ ] Set up Cloudinary for photo uploads (optional)

**🎉 You're ready to start developing!**
