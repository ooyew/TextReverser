# TextReverser

This Visual Studio solution consists of two projects:

## TextReverser
A complete ReactJS + ASP .NET Core project. There are 2 API endpoints created:
1. POST /api/v1/home/reversedInput -> to store the user input string and return the reversed result to Database.
2. GET /api/v1/home/getAllInput -> to list all the user input and reversed result in Database.

The Database provider used in this project is EF Core In-Memory for testing purpose.

## TestApplication
A NUnit created to test the business logic for TextReverser.

### How to start the Web Application
1. Clone this repository into your local machine.
2. Launch Command Prompt and navigate to TextReverser/TextReverser folder.
3. Run "dotnet publish" in Command Prompt.
4. Once successful, navigate to /publish folder.
5. Locate TextReverser.exe and double click on it. It will create a local hosting server.
6. Click on the localhost link in local hosting server and it will launch the TextReverser Web Application.