namespace Observer.Domain
{
	interface IObserver
	{
		void Update();

		string Name { get; }
	}
}
