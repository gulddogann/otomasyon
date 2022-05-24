-- Tunahan Deniz

use GT2MTE

CREATE TABLE Ogrenci(
ogrid int PRIMARY KEY NOT NULL,
ograd varchar(50) NOT NULL,
ogrsoyad varchar(20) not null,
ogrtel varchar(12) not null,
ogrposta varchar(30) not null,
ogrbolumad varchar(50) not null
)

CREATE TABLE KİTAP(
	kitapid int NOT NULL PRIMARY KEY,
    kitapadı varchar(50) NOT NULL,
    ısbn varchar(20) NOT NULL,
    yayınadı varchar(20) NOT NULL,
    stoksayısı int NOT NULL,
    sayfasayısı int NOT NULL,
    emanetdurum boolean NOT NULL,
    kütüpektarihi date NOT NULL,
    yayınyılı date NOT NULL
)

CREATE TABLE Edıtor(
	edıtorid int not null PRIMARY KEY,
    edıtor varchar(50)
)

CREATE TABLE KitapDil( 
	dilId int NOT NULL, 
	kitapid int NOT null, 
	FOREIGN KEY(dilId) REFERENCES Dil(dilId), 
	FOREIGN KEY(kitapid) REFERENCES Kitap(kitapid) 
)

CREATE TABLE KitapYazar(
	yazarId int NOT null,
    kitapid int NOT null,
    FOREIGN KEY (yazarId) REFERENCES yazarTablo(yazarId),
    FOREIGN KEY (kitapid) REFERENCES Kitap(kitapid)
)


CREATE TABLE KitapCevirmen(
	cevirmenId int NOT null,
    kitapid int NOT null,
    FOREIGN KEY (cevirmenId) REFERENCES Cevimen(cevirmenId),
    FOREIGN key (kitapid) REFERENCES Kitap(kitapid)
)


--Merve Kahraman

CREATE TABLE KitapEditor(
       kitapId int NOT NULL PRIMARY KEY,
       editorId int NOT NULL PRIMARY KEY
)
CREATE TABLE KitapKategori(
        kitapId int NOT NULL PRIMARY KEY,
        kategoriId int NOT NULL PRIMARY KEY
)
CREATE TABLE Cevirmen (
        cevirmenId  int NOT NULL PRIMARY KEY,
        cevirmen vaechar(50) NOT NULL
)
CREATE TABLE KitapPersonel(
        kitapId int NOT NULL PRIMARY KEY,
        personelId int NOT NULL PRIMARY KEY
)

--Gül-Tunahan

CREATE TABLE Personel( 
	persoenlid int PRIMARY KEY not null, 
	personelad varchar(50) not null, 
	personelsoyad varchar(50) not null, 
	personeltelno varchar(11) not null, 
	personeleposta varchar(30) not null 
)

CREATE TABLE yazarTablo(
	yazarId int primary key not null,
	yazar varchar(30) not null
)

CREATE TABLE kategoriTablo(
	KategoriId int primary key not null,
	KategoriAd varchar(30) not null
)

--Merve-Tunahan

CREATE TABLE konumTablo(
	konumId int primary key not null,
	kategoriRaflığı int not null,
	raf int not null,
	raflıkSütun int not null
)

CREATE TABLE KitapKonum(
    kitapid int not null,
    konumId int not null,
    FOREIGN KEY (kitapid) REFERENCES Kitap(kitapid),
    FOREIGN KEY (konumId) REFERENCES konumTablo(konumId)
)

CREATE TABLE Dil(
    dilId int primary key not null,
    dil varchar(20) not null
)

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