namespace interfaceOrnek{

    public class Corolla : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return  Marka.Toyota;
        }

        public int KacTekerOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return   Renk.Beyaz;
        }
    }
}
