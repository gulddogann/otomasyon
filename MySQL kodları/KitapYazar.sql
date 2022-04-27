CREATE TABLE KitapYazar(
	yazarId int NOT null,
    kitapid int NOT null,
    FOREIGN KEY (yazarId) REFERENCES yazarTablo(yazarId),
    FOREIGN KEY (kitapid) REFERENCES Kitap(kitapid)
)