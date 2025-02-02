namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // DONE: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // DONE: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade da suite é insuficiente para essa quantidade de hóspedes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // DONE: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // DONE: Retorna o valor da diária            
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                valor -= valor * 10/100;
            }

            return valor;
        }
    }
}