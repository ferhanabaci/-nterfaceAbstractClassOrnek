namespace interfaceOrnek{

    public class Civic : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}