using UnityEngine;

public class ToggleInteractable : InstantInteractable
{
    protected bool isOpen = false;
    public override void Interact()
    {
        base.Interact();
        isOpen = !isOpen;
    }
}
