using UnityEngine;
public class Key : InstantInteractable
{
    private enum KeyColor
    {
        None,
        Red,
        Yellow
    }
    [SerializeField] private KeyColor m_KeyColor = KeyColor.None;
    public override void Interact()
    {
        base.Interact();
        if(m_KeyColor == KeyColor.Red)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteract>().HasRedKey = true;
        }
        else if (m_KeyColor == KeyColor.Yellow)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInteract>().HasYellowKey = true;
        }
        Destroy(gameObject);
    }
}