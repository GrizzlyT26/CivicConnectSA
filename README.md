# CivicConnect SA

## Municipal Services Application

CivicConnect SA is a C# .NET Framework Windows Forms application designed to improve citizen engagement with municipal services in South Africa.

The application allows residents to report municipal issues, provide supporting information, attach images or documents, and receive a unique reference number that can be used to check the status of their service request.

---

## Features

### 1. Main Menu

The application provides a main menu with the following options:

- Report Issues
- Local Events & Announcements
- Service Request Status
- Exit

The Report Issues functionality is fully implemented.

Local Events & Announcements is currently under development.

---

### 2. Report Municipal Issue

Residents can submit municipal service issues by providing:

- Location of the issue
- Issue category
- Detailed description
- Supporting image or document

Available issue categories include:

- Sanitation
- Roads and Potholes
- Water Supply
- Electricity
- Waste Management
- Street Lighting
- Public Safety
- Other

The application provides:

- Input validation
- Character counter
- Progress indicator
- Community engagement messages
- File attachment functionality
- File size validation
- Submission confirmation
- Unique service request reference number

---

### 3. Service Request Status

Residents can check their submitted issue using the reference number generated when the report was submitted.

The application displays:

- Request status
- Location
- Category
- Date reported
- Description

---

## Technology Stack

- C#
- .NET Framework
- Windows Forms
- Visual Studio
- Object-Oriented Programming
- Generic List data structure
- OpenFileDialog
- Windows Forms MessageBox

---

## Data Storage

The application currently uses an in-memory data structure to store reported issues during the application session.

The `Issue` model stores:

- ReferenceNumber
- Location
- Category
- Description
- AttachmentPath
- DateReported
- Status

The `IssueDataStore` class maintains a `List<Issue>` containing submitted reports.

Data is stored for the duration of the application session.

---

## System Requirements

To compile and run the application, the following are required:

- Windows operating system
- Visual Studio
- .NET Framework compatible with the project
- C# development tools

---

## How to Compile

1. Open Visual Studio.
2. Open the `CivicConnectSA` solution.
3. Open **Solution Explorer**.
4. Select the `CivicConnectSA` project.
5. Select:

   **Build → Build Solution**

6. Ensure that the project builds successfully without errors.

---

## How to Run

1. Open the CivicConnectSA solution in Visual Studio.
2. Build the solution.
3. Press:

   **F5**

   or select:

   **Debug → Start Debugging**

4. The CivicConnect SA main menu will appear.

---

## How to Use the Application

### Reporting an Issue

1. Start the application.
2. Select **Report Issues**.
3. Enter the location of the municipal issue.
4. Select the relevant issue category.
5. Enter a detailed description.
6. Optionally attach an image or document.
7. Review the progress indicator.
8. Select **Submit Report**.
9. A confirmation message will display the generated reference number.
10. Keep the reference number for checking the status of the report.

---

### Checking a Service Request

1. Return to the Main Menu.
2. Select **Service Request Status**.
3. Enter the reference number received after submitting a report.
4. Select **Check Status**.
5. The application will display the stored service request information.

---

## File Attachments

The application supports:

- JPG
- JPEG
- PNG
- PDF
- DOC
- DOCX

Attachments are limited to a maximum size of 10 MB.

The selected file name is displayed on the report form.

---

## User Engagement Feature

The application uses a dynamic progress indicator as its primary user engagement feature.

The progress indicator responds to information entered by the user.

Progress is calculated based on:

- Location entered – 30%
- Category selected – 25%
- Description entered – 35%
- Supporting attachment – 10%

The application also provides dynamic encouragement messages to guide users through the reporting process.

Examples include:

- "Good start! Please select an issue category."
- "You're making progress! Please describe the issue."
- "Almost done! You can add an attachment if available."
- "Your report is complete and ready to submit."

This feature encourages users to complete the reporting process and provides immediate feedback about their progress.

---

## Data Structure

The application uses a generic `List<Issue>` data structure to store submitted municipal reports.

Each report is represented by an `Issue` object.

Example:

```csharp
List<Issue> ReportedIssues