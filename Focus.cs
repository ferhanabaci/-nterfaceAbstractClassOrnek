namespace interfaceOrnek{

    public class Focus : IOtomobil
    {
        public Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
        }

        public int KacTekerOlusur()
        {
                return 4;
         }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }


}