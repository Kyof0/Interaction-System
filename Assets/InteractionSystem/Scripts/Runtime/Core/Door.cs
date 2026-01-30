using System.Collections;
using TMPro.EditorUtilities;
using UnityEngine;

public class Door : ToggleInteractable
{
    [Header("UI Tooltip")]
    [SerializeField] private string _name = "Door";
    private enum DoorColor
    {
        None,
        Red,
        Yellow
    }
    [SerializeField] private DoorColor doorColor;
    [SerializeField] private float openTime = 2f;
    private Quaternion closedRotation = Quaternion.Euler(0, 90, 0);
    private Quaternion openRotation = Quaternion.Euler(0, 0, 0);
    public override void Interact()
    {
        if (!CanInteract())
        {
            return;
        }
        base.Interact();
        StartCoroutine(DoorAnimation());
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
    public override bool CanInteract()
    {
        if(doorColor == DoorColor.Red)
        {
            GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
            if (playerGO.GetComponent<PlayerInteract>().HasRedKey == false) return false;
        }
        else if (doorColor == DoorColor.Yellow)
        {
            GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
            if (playerGO.GetComponent<PlayerInteract>().HasYellowKey == false) return false;
        }
        return base.CanInteract();
    }
    IEnumerator DoorAnimation()
    {
        Quaternion rotation = openRotation;
        if (isOpen)
        {
            rotation = closedRotation;
        }
        canInteract = false;
        float time = 0;
        while(time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, time);
            time += Time.deltaTime * openTime;
            yield return null;
        }
        canInteract = true;
    }
}
