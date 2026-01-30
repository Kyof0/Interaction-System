using System.Collections;
using UnityEngine;
public class Door : ToggleInteractable
{
    private enum DoorColorEnum
    {
        None,
        Red,
        Yellow
    }
    [SerializeField] private DoorColorEnum DoorColor = DoorColorEnum.None;
    [SerializeField] private float openTime = 2f;
    private readonly Quaternion m_ClosedRotation = Quaternion.Euler(0, 90, 0);
    private readonly Quaternion m_OpenRotation = Quaternion.Euler(0, 0, 0);
    public override void Interact()
    {
        if (!GetCanInteract())
        {
            return;
        }
        base.Interact();
        StartCoroutine(DoorAnimation());
    }
    public override bool GetCanInteract()
    {
        if(DoorColor == DoorColorEnum.Red)
        {
            GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
            if (playerGO.GetComponent<PlayerInteract>().HasRedKey == false) return false;
        }
        else if (DoorColor == DoorColorEnum.Yellow)
        {
            GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
            if (playerGO.GetComponent<PlayerInteract>().HasYellowKey == false) return false;
        }
        return base.GetCanInteract();
    }
    IEnumerator DoorAnimation()
    {
        Quaternion rotation = m_OpenRotation;
        if (IsOpen)
        {
            rotation = m_ClosedRotation;
        }
        CanInteract = false;
        float time = 0;
        while(time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, time);
            time += Time.deltaTime * openTime;
            yield return null;
        }
        CanInteract = true;
    }
}