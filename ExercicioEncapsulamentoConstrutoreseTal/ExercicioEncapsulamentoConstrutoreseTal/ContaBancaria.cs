namespace ExercicioEncapsulamentoConstrutoreseTal
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        //Private no Saldo? Porquê o saldo não pode ser alterado de uma vez, no código, só através de depósito ou saque
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Depositar(depositoInicial);
        }
        //Mesma coisa de Saldo = depositoInicial, mas assim estamos aproveitando o encapsulamento e escrevendo menos coisa
        //Caso a regra de depósito atualize no futuro, vai estar atualizada alí também
        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
        public void Sacar(double quantia)
        {
            Saldo -= (quantia+5.0);
        }
        public override string ToString()
        {
            return ($"Conta: {Numero}, Titular: {Titular}, Saldo: R${Saldo.ToString("F2")}");
        }
    }
}
