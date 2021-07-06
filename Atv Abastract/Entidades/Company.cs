namespace Atv_Abastract.Entidades
{
    class Company : TaxPlayer
    {
        public int numberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberofemployees) : base(name, anualIncome)
        {
            numberOfEmployees = numberofemployees;
        }

        public override double tax()
        {
            if(numberOfEmployees > 10)
            {
                return anualIncome * 0.14;

            }
            else
            {
                return anualIncome * 0.16;
            }

        }
    }
}
