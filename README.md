# Task-Tracker-CLI

## Task Manager CLI

Task Manager CLI is a simple command-line tool for managing tasks. You can add, list, view details, update, remove tasks, and mark them as completed. It's written in C# and demonstrates fundamental CRUD operations for a task management system.

## Features

- **Add Tasks**: Create tasks with a title, description, and assigner.
- **List Tasks**: Display all tasks.
- **View Task Details**: See detailed information about a specific task.
- **Update Tasks**: Modify task details.
- **Remove Tasks**: Delete tasks by their ID.
- **Clear Console**: Clean the console with the `cls` command.
- **Exit**: Quit the application.

## Commands

| Command      | Description                                  | Example                          |
|--------------|----------------------------------------------|----------------------------------|
| `add`        | Add a new task.                             | `add`                           |
| `list`       | Display all tasks.                          | `list`                          |
| `detail`     | View details of a specific task by ID.       | `detail 1`                      |
| `update`     | Update a specific task by ID.               | `update 2`                      |
| `remove`     | Remove a specific task by ID.               | `remove 3`                      |
| `cls`        | Clear the console.                          | `cls`                           |
| `exit`       | Quit the application.                       | `exit`                          |

## Prerequisites

- .NET SDK 8.0 or later
- A terminal or command prompt

## How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/namngo923/Task-Tracker-CLI.git
   cd Task-Tracker-CLI
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

## Example Usage

### Add a Task:
```bash
> add
Title: Build Task Manager
Description: Create a CLI tool for task management.
Assigner: John Doe
Task added: Build Task Manager
```

### List Tasks:
```bash
> list
[ ] 1: Build Task Manager
```

### View Task Details:
```bash
> detail 1
Task #1
Title: Build Task Manager
Description: Create a CLI tool for task management.
Assigner: John Doe
Created At: 12/23/2024 10:30 AM
Status: Pending
```

### Update a Task:
```bash
> update 1
Task updated successfully.
```

### Remove a Task:
```bash
> remove 1
Task 1 removed.
```

### Clear the Console:
```bash
> cls
```

### Exit:
```bash
> exit
Goodbye!
```

## Project Structure

```
TaskManager/
├── Models/
│   └── TaskItem.cs       
├── Services/
│   └── TaskService.cs    // Core business logic
└── Program.cs            // Main application entry point
```

## Contributing

Feel free to contribute by submitting issues, feature requests, or pull requests.

## Additional Resources

For more guidance on building task management systems, visit [Task Tracker Roadmap](https://roadmap.sh/projects/task-tracker).

