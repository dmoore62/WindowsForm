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