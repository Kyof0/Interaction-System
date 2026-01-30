using UnityEngine;

public abstract class BaseInteractable : MonoBehaviour, IInteractable
{
    protected string Interaction_UI_String = "";
    protected InteractionType interactionType;
    protected bool canInteract = true;
    public virtual void Interact()
    {
    }
    public virtual bool CanInteract()
    {
        return canInteract;
    }
    protected virtual void Awake()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
    protected enum InteractionType
    {
        Instant,
        Hold
    }
    public virtual string GetInteractText()
    {
        return Interaction_UI_String;
    }
}
