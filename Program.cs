
Console.WriteLine("");

byte b = 5;         //2 byte yer kapları
sbyte sb = 5;       //2 byte

short s = 5;        //2 byte 
ushort us = 5;      //2 byte

Int16 i16 = 2;      //2 byte
Int32 i32 = 4;      //4 byte
int   i   = 4;      //4 byte
Int64 i64 = 8;      //8 byte

uint ui  = 4;       //4 byte
long l   = 8;       //8 byte
ulong ul = 8;       //8 byte


float f = 4;        //4 byte
double d = 8;       //8 byte
decimal de = 16;    //16 byte

char c = '2';       //2 byte
string str = "Zikriye";   //sınırsız

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x"; 
object o2 = 'y';
object o3 = 4;
object o4 = 4.3;


// String İfadeler

string str1 = string.Empty;
str1 = "Patika.dev, Patika +";
string ad = "Tom";
string soyad = "Hardy";
string tamIsim = ad + " "+ soyad;

// integer tanımlama

int integer1 = 5;
int integer2 = 6;
int toplam = integer1 + integer2;

Console.WriteLine("Toplam: " + toplam);

bool bool1 = 10>2;

// Değişken Dönüşümleri

string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger);


int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);

int int22 = int20 + int.Parse(str20);


//datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);