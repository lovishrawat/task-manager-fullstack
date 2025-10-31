# Task Manager - Full-Stack Application

A simple and elegant task management application built with **C# .NET 8** (Backend) and **React + TypeScript** (Frontend).

## 📋 Features

- ✅ **Add Tasks** - Create new tasks with descriptions
- ✅ **Toggle Completion** - Mark tasks as complete or incomplete
- ✅ **Delete Tasks** - Remove tasks you no longer need
- ✅ **Filter Tasks** - View all, active, or completed tasks
- ✅ **Real-time Updates** - Instant UI updates with API integration
- ✅ **Responsive Design** - Beautiful UI that works on all devices
- ✅ **In-Memory Storage** - No database setup required

## 🛠️ Tech Stack

### Backend
- **C# .NET 8** - Web API
- **RESTful API** - Standard HTTP methods (GET, POST, PUT, DELETE)
- **In-Memory Storage** - No database configuration needed
- **CORS** enabled for frontend communication

### Frontend
- **React 18** - Modern UI library
- **TypeScript** - Type-safe JavaScript
- **Tailwind CSS** - Utility-first styling
- **Lucide React** - Beautiful icons
- **Fetch API** - HTTP client for API calls

## 📁 Project Structure

```
task-manager/
├── TaskManagerApi/           # Backend (C# .NET 8)
│   ├── Controllers/
│   │   └── TasksController.cs
│   ├── Models/
│   │   └── TaskItem.cs
│   ├── Program.cs
│   └── TaskManagerApi.csproj
│
└── task-manager-frontend/    # Frontend (React + TypeScript)
    ├── src/
    │   ├── App.tsx
    │   └── index.css
    ├── public/
    └── package.json
```

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (v18 or higher)
- [npm](https://www.npmjs.com/) or [yarn](https://yarnpkg.com/)
- Git (optional)

### Backend Setup

1. **Navigate to the backend folder:**
   ```bash
   cd TaskManagerApi
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Run the API:**
   ```bash
   dotnet run
   ```

4. **Verify it's running:**
   - API will be available at: `http://localhost:5000`
   - Swagger UI (if installed): `http://localhost:5000/swagger`

### Frontend Setup

1. **Navigate to the frontend folder:**
   ```bash
   cd task-manager-frontend
   ```

2. **Install dependencies:**
   ```bash
   npm install
   ```

3. **Install Tailwind CSS:**
   ```bash
   npm install -D tailwindcss postcss autoprefixer
   npx tailwindcss init -p
   ```

4. **Install Lucide React for icons:**
   ```bash
   npm install lucide-react
   ```

5. **Start the development server:**
   ```bash
   npm start
   ```

6. **Open your browser:**
   - Frontend will be available at: `http://localhost:3000`

## 🔌 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/tasks` | Get all tasks |
| `POST` | `/api/tasks` | Create a new task |
| `PUT` | `/api/tasks/{id}` | Update a task |
| `DELETE` | `/api/tasks/{id}` | Delete a task |

### Example Request Bodies

**Create Task (POST):**
```json
{
  "description": "Learn C# and React"
}
```

**Update Task (PUT):**
```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "description": "Learn C# and React",
  "isCompleted": true
}
```

## 🎨 Screenshots

### Main Interface
- Clean, modern UI with task list
- Add new tasks with a single click
- Filter tasks by status (All/Active/Completed)

### Features in Action
- Toggle task completion with checkmark icons
- Delete tasks with trash icon
- Real-time updates without page refresh

## 🧪 Testing the Application

1. **Start the backend** (Terminal 1):
   ```bash
   cd TaskManagerApi
   dotnet run
   ```

2. **Start the frontend** (Terminal 2):
   ```bash
   cd task-manager-frontend
   npm start
   ```

3. **Test the features:**
   - Add a new task
   - Mark it as complete
   - Filter by completed/active
   - Delete a task

## 📦 Building for Production

### Backend
```bash
cd TaskManagerApi
dotnet publish -c Release -o ./publish
```

### Frontend
```bash
cd task-manager-frontend
npm run build
```

The optimized build will be in the `build/` folder.

## 🔧 Configuration

### Changing API URL

If your backend runs on a different port, update the `API_URL` in `src/App.tsx`:

```typescript
const API_URL = 'http://localhost:YOUR_PORT/api/tasks';
```

### CORS Configuration

The backend is configured to allow requests from:
- `http://localhost:3000` (Create React App default)
- `http://localhost:5173` (Vite default)

To add more origins, edit `Program.cs` in the backend.

## 🐛 Troubleshooting

### Backend won't start
- Make sure .NET 8 SDK is installed: `dotnet --version`
- Check if port 5000 is already in use

### Frontend can't connect to API
- Verify backend is running on `http://localhost:5000`
- Check browser console for CORS errors
- Ensure API_URL in `App.tsx` matches your backend URL

### Lucide icons not showing
- Run: `npm install lucide-react`
- Restart the development server

## 📝 Assignment Requirements Checklist

- ✅ Display a list of tasks
- ✅ Add a new task with a description
- ✅ Mark a task as completed or uncompleted
- ✅ Delete a task
- ✅ RESTful API using .NET 8 Core
- ✅ In-memory data storage (no database)
- ✅ TaskItem model with Id, Description, IsCompleted
- ✅ All required endpoints (GET, POST, PUT, DELETE)
- ✅ Single-page React application
- ✅ TypeScript implementation
- ✅ React Hooks for state management
- ✅ Fetch API for backend integration

## 🤝 Contributing

This is a learning project for assignment purposes. Feel free to fork and experiment!

## 📄 License

This project is created for educational purposes.

## 👨‍💻 Author

Created as part of a full-stack development assignment to demonstrate proficiency in C# .NET 8 and React with TypeScript.

---

**Note:** This application uses in-memory storage, so all tasks will be lost when the backend server restarts. For persistent storage, consider adding a database like SQL Server or PostgreSQL.
