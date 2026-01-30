using UnityEngine;

public abstract class BaseInteractable : MonoBehaviour, IInteractable
{
    protected InteractionType interactionType;

    public virtual void Interact()
    {
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
}
