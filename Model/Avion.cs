namespace SergioBoror.Model
{
    public class Avion : Vehiculo
    {        
        private float alturaMaxima;
        public float AlturaMaxima
        {
            get { return alturaMaxima;}
            set { alturaMaxima = value;}
        }   

        private float alturaMinima;
        public float AlturaMinima
        {
            get { return alturaMinima;}
            set { alturaMinima = value;}
        } 

        public Avion(){}
        public Avion(string marca, string modelo, float alturaMaxima, float alturaMinima) => (base.Marca, base.Modelo, base.VelocidadMaxima, base.VelocidadMinima) = (marca, modelo, alturaMaxima, alturaMinima);
                   
        

        public void Despegar()
        {
            
        }

        public void Aterrizar()
        {
            
        }
        
        public void DisminuirAltura(float pie)
        {

        } 
        
    }
}