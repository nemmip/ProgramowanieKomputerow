namespace Zadanie2
{
    public struct Zespolone
    {
        //z = a+bi
        private int Re;
        private int Im;
        //Konstruktor
        Zespolone(int Re, int Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        //metody
        public override string ToString()=>$"{Re}+{Im}i";

        public override bool Equals(object obj)
        {
            if (obj is Zespolone)
                return this.Equals((Zespolone)obj);
            else
                return false;
        }

        public bool Equals(Zespolone z) => (this.Re == z.Re) && (this.Im == z.Im);
        public static bool operator == (Zespolone lewy, Zespolone prawy) => lewy.Equals(prawy);
        public static bool operator !=(Zespolone lewy, Zespolone prawy) => !(lewy.Equals(prawy));

        public static Zespolone operator +(Zespolone lewy, Zespolone prawy)
        {
            Zespolone zespolone = new Zespolone();
            zespolone.Re = lewy.Re + prawy.Re;
            zespolone.Im = lewy.Im + prawy.Im;
            return zespolone;
        }
    }
}