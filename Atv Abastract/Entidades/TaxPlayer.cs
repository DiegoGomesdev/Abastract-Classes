namespace Atv_Abastract.Entidades
{
     abstract class TaxPlayer
    {
        public string Name { get; set; }
        public double anualIncome { get; set; }
        public TaxPlayer()
        {


        }
        public TaxPlayer(string name, double anualincome)
        {
            Name = name;
            anualIncome = anualincome;
        }

        public abstract double tax();

        
    }
}
