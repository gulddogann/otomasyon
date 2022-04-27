CREATE TABLE KitapCevirmen(
	cevirmenId int NOT null,
    kitapid int NOT null,
    FOREIGN KEY (cevirmenId) REFERENCES Cevimen(cevirmenId),
    FOREIGN key (kitapid) REFERENCES Kitap(kitapid)
)