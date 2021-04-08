create table urunler
( 
urunkodu int primary key,
marka nvarchar(25),
model nvarchar(25),
kategori nvarchar(30),
alısfiyat int,
kdvoran int,
karoran int,
satısfiyat int, 
stokadet int,
kayıtyapan nvarchar(30)
)