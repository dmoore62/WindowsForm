CREATE TABLE project(
	
	id INT IDENTITY not null,
	name VARCHAR(50) not null,
	created DATETIME not null,
	DB_File TEXT not null,
	CONSTRAINT project_pk_id PRIMARY KEY (id),
	CONSTRAINT project_unique_name UNIQUE (name)
);