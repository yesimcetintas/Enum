
Console.WriteLine(Gunler.Cuma);
Console.WriteLine((int)Gunler.Cuma);

int sicaklik = 25;

if(sicaklik <= (int)HavaDurumu.Normal){
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
}else if(sicaklik>=(int)HavaDurumu.Sıcak){
    Console.WriteLine("Dışarıya çıkmak için sıcak bir gün.");
}else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak){
    Console.WriteLine("Hadi dışarıya çıkalım");
}

enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 20,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sıcak=25,
    CokSıcak = 30
}
