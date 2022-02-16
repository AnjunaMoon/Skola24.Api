Full databas-backup ligger i Skola24.Api/App_Data. Restore behöver köras från Management Studio. 
Enklast är väl att ni ändrar till Integrated Security=True och skippar att justera i Logins och Users. Samt förstås ändrar servernamnet.
ConnectionString ligger i Skola24.Api/appsettings

Om det blir för struligt för er att lägga in DB:n får jag väl dema via Teams och koden får studeras utan debugger.
Hade jag haft tid hade jag kanske löst problemen jag hade med EF Core i samband med MSSQLLocalDB-filen


