namespace Atv_Abastract.Entidades
{
    class Individual : TaxPlayer
    {
        public double healthExpeditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthexpeditures) 
            : base(name, anualIncome)
        {
            healthExpeditures = healthexpeditures;
        }

        public override double tax()
        {
            if (anualIncome < 20000.0)
            {

                return anualIncome * 0.15 - healthExpeditures * 0.5;

            }
            else
            {
                return anualIncome * 0.25 - healthExpeditures * 0.5;

            }

            

        }
    }
}
