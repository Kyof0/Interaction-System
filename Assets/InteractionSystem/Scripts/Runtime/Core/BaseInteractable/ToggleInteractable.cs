public class ToggleInteractable : InstantInteractable
{
    protected bool IsOpen = false;
    public override void Interact()
    {
        base.Interact();
        IsOpen = !IsOpen;
    }
}