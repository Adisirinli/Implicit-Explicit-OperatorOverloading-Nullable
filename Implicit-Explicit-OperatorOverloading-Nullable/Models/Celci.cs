

namespace Implicit_Explicit_OperatorOverloading_Nullable.Models
{
    public class Celci
    {
        public double celci {  get; set; }

        public Celci(double celci)
        {
            this.celci = celci;
        }

        public static implicit operator Kelvin(Celci celci)
        {
            return new Kelvin(celci.celci - 273);
        }

    }
}
