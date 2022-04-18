using System.Globalization;
namespace Logica_C_Sharp
{
    class DadosConta
    {
        private int _numConta;
        private string _nome;
        private double _saldo;

        public DadosConta(int numConta, string nome, double saldo)
        {
            _numConta = numConta;
            _nome = nome;
            _saldo = saldo;

        }
        public DadosConta(int numConta, string nome)
        {
            _numConta = numConta;
            _nome = nome;
        }
        public int NumConta
        {
            get { return _numConta; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public override string ToString()
        {
            return $"Conta {_numConta}, Titular: {_nome}, Saldo = R${_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double Deposito(double deposito)
        {
            return _saldo += deposito;
        }
        public double Saque(double saque)
        {
            return _saldo -= saque + 5;
        }

    }
}
