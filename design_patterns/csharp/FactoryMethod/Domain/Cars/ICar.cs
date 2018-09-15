namespace FactoryMethod.Domain.Cars
{
	interface ICar
	{
		void TurnOn();
		void TurnOff();

		int Produced { get; set; }
	}
}
