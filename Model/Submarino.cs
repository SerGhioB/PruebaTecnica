namespace SergioBoror.Model
{
    public class Submarino : Vehiculo
    {
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima;}
            set { profundidadMaxima = value;}
        }

        public Submarino(){}
        public Submarino(string marca, string modelo, float profundidadMaxima) => (base.Marca, base.Modelo, base.VelocidadMaxima) = (marca, modelo, profundidadMaxima);


        public void Sumergir(float metros)
        {
            
        }
   

    }
}