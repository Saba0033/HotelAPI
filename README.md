# Hotel Reservation System API

Welcome to the **Hotel Reservation System** project. This application provides an API for users to browse hotels, make reservations, and receive email confirmations upon successful booking.

---

## Features

- **Hotel Management**: Add, edit, and delete hotel entries.
- **Reservation System**: View available hotels and make reservations.
- **Email Notifications**: Receive reservation confirmation emails.
- **Role-based Access**: Admins have full control over hotel management, while regular users can only make reservations.

---

## Technologies Used

- **ASP.NET Core**: For building the API.
- **Entity Framework Core**: For database interaction.
- **SQL Server**: For database management.
- **JWT Authentication**: For secure user authentication.
- **SMTP Email**: For sending reservation confirmation emails.
- **Swagger**: For API documentation and testing.

---

## Getting Started

### Prerequisites

To run the project locally, ensure you have the following installed:

- **.NET SDK 6.0** or later
- **SQL Server** or another relational database system
- **SMTP server** for email functionality (configure your SMTP settings in `appsettings.json`)

---

### Installation

1. **Clone the repository**:

    ```bash
    git clone https://github.com/yourusername/hotel-reservation-system.git
    ```

2. **Navigate to the project directory**:

    ```bash
    cd hotel-reservation-system
    ```

3. **Restore the project dependencies**:

    ```bash
    dotnet restore
    ```

4. **Apply database migrations**:

    ```bash
    dotnet ef database update
    ```

5. **Run the application**:

    ```bash
    dotnet run
    ```

---

## Email Configuration

To enable email functionality, configure your SMTP settings in the `appsettings.json` file. Example configuration:

```json
"EmailSettings": {
  "SmtpServer": "smtp.yourserver.com",
  "SmtpPort": 587,
  "SenderEmail": "noreply@yourdomain.com",
  "SenderPassword": "your-email-password"
}
