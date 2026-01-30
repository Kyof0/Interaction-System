using UnityEngine;

public class HoldInteractable : BaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
        interactionType = InteractionType.Hold;
    }
}