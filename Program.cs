Console.WriteLine("Masukkan Angka");
Console.WriteLine("1. Penjumlahan");
Console.WriteLine("2. Pengurangan");
Console.WriteLine("3. Perkalian");
Console.WriteLine("4. Pembagian");

int inputPengguna = int.Parse(Console.ReadLine());
Console.WriteLine("Masukkan Angka Pertama: ");
int angka1 = int.Parse(Console.ReadLine());
Console.WriteLine("Masukkan Angka Kedua: ");
int angka2 = int.Parse(Console.ReadLine () );

switch (inputPengguna)
{
    case 1:
    int Penjumlahan = angka1 + angka2;
    Console.WriteLine(Penjumlahan);
    break;
    case 2:
    int Pengurangan = angka1 - angka2;
    Console.WriteLine(Pengurangan);
    break;
    case 3:
    int Perkalian = angka1 * angka2;
    Console.WriteLine(Perkalian);
    break;
    case 4:
    double Pembagian =(double)angka1 / angka2;
    Console.WriteLine(Pembagian);
    break;

    // haha
}