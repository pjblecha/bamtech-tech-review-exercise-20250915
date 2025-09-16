# My working process

Refresh memory on items
Download project
Extract project
Run project in unaltered state
Access Swagger and see what state we are in
	Database doesn't exist yet!
First backend task
	Build database migrations
	Run: dotnet ef migrations add FirstMigration
	Update the database
	Run: dotnet ef database update

NOTES

	To solve dereferenced nulls, I would wrap each statement in null checks. This might cause some downstream issues, which means more error handling.

	Error handling!
	I would create some custom Exception classes that would contain specific information at each error point. This would get stored in custom logs on the database. 

	
