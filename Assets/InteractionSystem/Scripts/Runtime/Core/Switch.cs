using UnityEngine;

public class Switch : ToggleInteractable
{
    [Header("UI Tooltip")]
    [SerializeField] private string _name = "Switch";
    [SerializeField] BaseInteractable target;
    public override void Interact()
    {
        if (target == null || !target.CanInteract())
        {
            Debug.LogWarning("Switch cannot interact");
            return;
        }
        base.Interact();
        target.Interact();
        SwitchAnimation();
    }
    protected override void Awake()
    {

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {

    }

    // Update is called once per frame
    protected override void Update()
    {

    }
    void SwitchAnimation()
    {
        Transform stick = transform.Find("SM_Stick");
        if (isOpen)
        {
            stick.GetComponent<MeshRenderer>().material.color = Color.green;
            stick.rotation = Quaternion.Euler(8, 0, 0);
        }
        else
        {
            stick.GetComponent<MeshRenderer>().material.color = Color.red;
            stick.rotation = Quaternion.Euler(-8, 0, 0);
        }
    }
}
