CREATE TABLE attribute(
	
	id INT IDENTITY not null,
	name VARCHAR(50) not null,
	descr TEXT not null,
	pid INT not null,
	created DATETIME not null,
	CONSTRAINT pk_id PRIMARY KEY (id),
	CONSTRAINT unique_name UNIQUE (name),
	CONSTRAINT fk_pid FOREIGN KEY (pid)
		REFERENCES project (id)

);