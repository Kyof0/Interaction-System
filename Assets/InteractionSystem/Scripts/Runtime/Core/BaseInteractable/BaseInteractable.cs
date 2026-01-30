using UnityEngine;
public abstract class BaseInteractable : MonoBehaviour, IInteractable
{
    protected string Interaction_UI_String = "";
    protected enum InteractionTypeEnum
    {
        Instant,
        Hold
    }
    protected InteractionTypeEnum InteractionType;
    protected bool CanInteract = true;
    protected virtual void Awake(){}
    protected virtual void Start(){}
    protected virtual void Update(){}
    public virtual void Interact(){}
    public virtual bool GetCanInteract()
    {
        return CanInteract;
    }
    public virtual string GetInteractText()
    {
        return Interaction_UI_String;
    }
}