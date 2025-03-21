
Hotel API 
Welcome to the Hotel Reservation System project! This application allows users to browse available hotels, make reservations, and receive email confirmations upon successful booking.

Features
Hotel Management: Add, edit, and delete hotels from the system.
Reservation System: Users can view available hotels and make reservations.
Email Notifications: After making a reservation, users will receive a confirmation email with the details.
Role-based Access: Admins have full control over hotel management, while regular users can only make reservations.
Technologies Used
ASP.NET Core: For building the API.
Entity Framework Core: For database interaction.
SQL Server: Used as the relational database.
JWT Authentication: Secure user authentication.
SMTP Email: Sends reservation confirmation emails to users.
Swagger: API documentation for easy testing and understanding.
Getting Started
Prerequisites
To run this project locally, you'll need:

.NET SDK 6.0 or later
SQL Server (or a local database server)
SMTP server for sending emails (you can configure your own SMTP server for testing)
Installation
Clone the repository:

bash
Copy
Edit
git clone https://github.com/yourusername/hotel-reservation-system.git
Navigate to the project directory:

bash
Copy
Edit
cd hotel-reservation-system
Restore the project dependencies:

bash
Copy
Edit
dotnet restore
Apply database migrations:

bash
Copy
Edit
dotnet ef database update
Run the application:

bash
Copy
Edit
dotnet run
Email Configuration
Make sure to configure your SMTP settings in the appsettings.json file to enable email functionality. Here's an example:

json
Copy
Edit
"EmailSettings": {
  "SmtpServer": "smtp.yourserver.com",
  "SmtpPort": 587,
  "SenderEmail": "noreply@yourdomain.com",
  "SenderPassword": "your-email-password"
}
Usage