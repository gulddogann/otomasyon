CREATE TABLE OgrenciKitap(
    ogrid int not null,
    kitapid int not null,
    verilentarih datetime not null,
    alınantarih datetime not null,
    kaçkezuzatıldı int not null,
    kitapdurum boolean not null,
    FOREIGN KEY (ogrid) REFERENCES Ogrenci(ogrid),
    FOREIGN KEY (kitapid) REFERENCES Kitap(kitapid)
)