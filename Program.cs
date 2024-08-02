

namespace Daspro_8;

class Program
{
    static void Main(string[] args)
    {
        // Identitas manusia,mahasiswa, dosen
        Manusia manusia = new Manusia();
        manusia.Nama = "Diki";
        manusia.Umur = 24;
        Console.WriteLine(manusia.perkenalan());

        Mahasiswa mahasiswa = new Mahasiswa();
        mahasiswa.Nama = "Rizkillah";
        mahasiswa.Umur = 18;
        mahasiswa.Nilai = 98;
        Console.WriteLine(mahasiswa.perkenalan());

        Dosen dosen = new Dosen();
        dosen.Nama = "Rahmat Rizal Andhi";
        dosen.Umur = 42;
        dosen.Gaji = "Rp.12.000.000";
        Console.WriteLine(dosen.perkenalan());
    }
}
// Kelas Manusia
class Manusia
{
    public int Umur { get; set; }
    public string? Nama { get; set; }
    // Overload Methods
    public virtual string perkenalan()
    {
        return $"Nama : {Nama}, Umur : {Umur}";
    }
    // Overload Methods
    public virtual string perkenalan(double NU)
    {
        return $"Nama : {Nama}, Umur : {Umur}";
    }
    // Overload Methods
    public virtual string perkenalan(string Nama, int Umur)
    {
        return $"Nama : {Nama}, Umur : {Umur}";
    }
    // Overload Methods
    public virtual string perkenalan(int Umur, string Nama)
    {
        return $"Nama : {Nama}, Umur : {Umur}";
    }
}
// Kelas mahasiswa turunan dari manusia(Overriding)
class Mahasiswa : Manusia
{
    public int Nilai { get; set; }
    // Overload Methods
    public override string perkenalan()
    {
        return base.perkenalan() + $" ,dan Nilai : {Nilai}";
    }
}
// Kelas dosen turunan dari manusia(Overriding)
class Dosen : Manusia
{
    public string? Gaji { get; set; }
    // Overload Methods
    public override string perkenalan()
    {
        return base.perkenalan() + $" ,dan Gaji : {Gaji}";
    }
}

