CREATE TABLE form(
	
	id INT IDENTITY not null,
	a_id INT not null,
	name VARCHAR(50) not null,
	col VARCHAR(50) not null,
	tabl VARCHAR(50) not null,
	created DATETIME not null,
	CONSTRAINT pk_id PRIMARY KEY (id),
	CONSTRAINT unique_name UNIQUE (name),
	CONSTRAINT fk_a_id FOREIGN KEY (a_id)
		REFERENCES attribute (id)

);