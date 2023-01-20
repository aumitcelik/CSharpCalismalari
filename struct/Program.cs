

namespace structYapi
{
    class Program
    {
        static void Main(string[] args)
        {
            Diktorgen diktorgen = new Diktorgen();
            diktorgen.kisaKenar = 3;
            diktorgen.uzunKenar = 4;

            Console.WriteLine("Class alan hesabi: " + + diktorgen.alanHesapla());

            Diktorgen_struct diktorgen_struct = new Diktorgen_struct();
            diktorgen_struct.kisaKenar = 3;
            diktorgen_struct.uzunKenar = 4;

            /* 
           //structlari bu sekilde de gosterbiliriz..
            Diktorgen_struct diktorgen_struct;
            diktorgen_struct.kisaKenar = 3;
            diktorgen_struct.uzunKenar = 4;
            */

            Console.WriteLine("Struct alan hesabi: " + + diktorgen_struct.alanHesapla());



            Console.ReadLine();
        }
    }
    class Diktorgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Diktorgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;

        }

        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }

    struct Diktorgen_struct
    {
        public int kisaKenar;
        public int uzunKenar;
        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }
}
