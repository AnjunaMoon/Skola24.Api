Full databas-backup ligger i Skola24.Api/App_Data. Restore behöver köras från Management Studio. 
Enklast är väl att ni ändrar till Integrated Security=True och skippar att justera i Logins och Users. Samt förstås ändrar servernamnet.
ConnectionString ligger i Skola24.Api/appsettings


API: 
	GET http://localhost:5000/api/absence?schoolName=
