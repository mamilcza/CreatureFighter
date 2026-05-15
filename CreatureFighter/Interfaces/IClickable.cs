namespace CreatureFighter.Interfaces
{
    internal interface IClickable : INamed
    {
        string OnLeftClick();
        string OnRightClick();
    }
}
