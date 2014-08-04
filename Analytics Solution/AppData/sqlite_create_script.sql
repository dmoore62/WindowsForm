CREATE DATABASE pandera_metadata

CREATE TABLE project(
	
	id INT IDENTITY not null,
	name VARCHAR(50) not null,
	created DATETIME not null,
	DB_File TEXT not null,
	CONSTRAINT project_pk_id PRIMARY KEY (id),
	CONSTRAINT project_unique_name UNIQUE (name)
);

CREATE TABLE attribute(
	
	id INT IDENTITY not null,
	name VARCHAR(50) not null,
	descr TEXT not null,
	pid INT not null,
	created DATETIME not null,
	CONSTRAINT attr_pk_id PRIMARY KEY (id),
	CONSTRAINT attr_unique_name UNIQUE (name),
	CONSTRAINT attr_fk_pid FOREIGN KEY (pid)
		REFERENCES project (id)

);

CREATE TABLE children(
	
	id INT IDENTITY not null,
	parent_id INT not null,
	child_id INT not null,
	created DATETIME not null,
	CONSTRAINT child_pk_id PRIMARY KEY (id),
	CONSTRAINT child_fk_parent_id FOREIGN KEY (parent_id)
		REFERENCES attribute (id),
	CONSTRAINT child_fk_child_id FOREIGN KEY (child_id)
		REFERENCES project (id)

);

CREATE TABLE form(
	
	id INT IDENTITY not null,
	a_id INT not null,
	name VARCHAR(50) not null,
	col VARCHAR(50) not null,
	tabl VARCHAR(50) not null,
	created DATETIME not null,
	CONSTRAINT form_pk_id PRIMARY KEY (id),
	CONSTRAINT form_unique_name UNIQUE (name),
	CONSTRAINT form_fk_a_id FOREIGN KEY (a_id)
		REFERENCES attribute (id)

);