namespace interfaceOrnek{

    public abstract class Otomobil{
        public int KacTekerOlusur(){
            return 4;
        }
        public virtual Renk StandartRengiNe(){
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkanınAraci();
            
        
         
    }


}