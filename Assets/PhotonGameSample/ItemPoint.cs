using UnityEngine;

public class ItemPoint : Item
{
    [SerializeField] private int itemPoint = 0;

    public override int itemValue => itemPoint;
}
