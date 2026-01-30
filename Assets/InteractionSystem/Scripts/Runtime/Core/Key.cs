using UnityEngine;

public class Key : InstantInteractable
{
    [Header("UI Tooltip")]
    [SerializeField] private string _name = "Key";
    private enum KeyColor
    {
        None,
        Red,
        Yellow
    }
    [SerializeField] private KeyColor keyColor = KeyColor.None;
    public override void Interact()
    {
        base.Interact();
        if(keyColor == KeyColor.Red)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteract>().HasRedKey = true;
        }
        else if (keyColor == KeyColor.Yellow)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteract>().HasYellowKey = true;
        }
        Destroy(gameObject);
    }
    protected override void Awake()
    {
        base.Awake();
        Interaction_UI_String = _name;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }
}
