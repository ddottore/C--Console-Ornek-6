Console.Write("Bir sayı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
int sayac2 = 0;

for (int y = 2; y <= sayi2; y++)
{
    sayac2 = 0;

    for (int x = 2; x < y ; x++)
    {
        if (y % x == 0)
        {
            sayac2++;
            break;
        }
    }
    if (sayac2 == 0)
    {
        Console.Write(y + "-");
    }

}

//Verilen sayıya kadar olan asal sayıları bulma