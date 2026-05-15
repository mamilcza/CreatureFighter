namespace CreatureFighter.Interfaces
{
    internal interface ITalkable: INamed
    {
        string Say(string message);
    }
}
