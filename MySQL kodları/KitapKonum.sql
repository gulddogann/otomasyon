CREATE TABLE KitapKonum(
    kitapid int not null,
    konumId int not null,
    FOREIGN KEY (kitapid) REFERENCES Kitap(kitapid),
    FOREIGN KEY (konumId) REFERENCES konumTablo(konumId)
)