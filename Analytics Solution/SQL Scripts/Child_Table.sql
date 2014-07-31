CREATE TABLE children(
	
	id INT IDENTITY not null,
	parent_id INT not null,
	child_id INT not null,
	created DATETIME not null,
	CONSTRAINT pk_id PRIMARY KEY (id),
	CONSTRAINT fk_parent_id FOREIGN KEY (parent_id)
		REFERENCES attribute (id),
	CONSTRAINT fk_child_id FOREIGN KEY (child_id)
		REFERENCES project (id)

);