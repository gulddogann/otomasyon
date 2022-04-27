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