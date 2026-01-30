using UnityEngine;
public class Switch : ToggleInteractable
{
    [SerializeField] private BaseInteractable m_target;
    private const int k_StickAngle = 8;
    private readonly Quaternion m_Stick_Open_Angle = Quaternion.Euler(k_StickAngle, 0,0);
    private readonly Quaternion m_Stick_Close_Angle = Quaternion.Euler(-k_StickAngle, 0, 0);
    public override void Interact()
    {
        if (m_target == null || !m_target.GetCanInteract())
        {
            Debug.LogWarning("Switch cannot interact");
            return;
        }
        base.Interact();
        m_target.Interact();
        SwitchAnimation();
    }
    void SwitchAnimation()
    {
        Transform stick = transform.Find("SM_Stick");
        if (IsOpen)
        {
            stick.GetComponent<MeshRenderer>().material.color = Color.green;
            stick.rotation = m_Stick_Open_Angle;
        }
        else
        {
            stick.GetComponent<MeshRenderer>().material.color = Color.red;
            stick.rotation = m_Stick_Close_Angle;
        }
    }
}