using UnityEngine;

public class InstantInteractable : BaseInteractable
{
    protected override void Awake()
    {
        base.Awake();
        interactionType = InteractionType.Instant;
    }
}