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