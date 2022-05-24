CREATE TABLE KitapDil( 
	dilId int NOT NULL, 
	kitapid int NOT null, 
	FOREIGN KEY(dilId) REFERENCES Dil(dilId), 
	FOREIGN KEY(kitapid) REFERENCES Kitap(kitapid) 
)