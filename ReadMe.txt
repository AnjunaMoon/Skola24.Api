Full databas-backup ligger i Skola24.Api/App_Data. Restore beh�ver k�ras fr�n Management Studio. 
Enklast �r v�l att ni �ndrar till Integrated Security=True och skippar att justera i Logins och Users. Samt f�rst�s �ndrar servernamnet.
ConnectionString ligger i Skola24.Api/appsettings


API: 
	GET http://localhost:5000/api/absence?schoolName=
