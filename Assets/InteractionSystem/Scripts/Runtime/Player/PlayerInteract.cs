using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public bool HasRedKey = false;
    public bool HasYellowKey = false;
    [SerializeField] private Camera m_playerCamera;

    [Header("Settings")]
    [SerializeField] private float m_interactDistance = 4f;
    [SerializeField] private LayerMask m_interactLayer;
    [SerializeField] private KeyCode m_interactKey = KeyCode.E;
    [SerializeField] private GameObject m_interactTextPanel;
    private IInteractable m_currentInteractable;

    void Update()
    {
        DetectInteractable();

        if (Input.GetKeyDown(m_interactKey) && m_currentInteractable != null)
        {
            m_currentInteractable.Interact();
        }
    }

    void DetectInteractable()
    {
        if(m_currentInteractable != null)
        {
            if (!m_interactTextPanel.gameObject.activeSelf)
            {
                m_interactTextPanel.gameObject.SetActive(true);
            }
        }
        else
        {
            if(m_interactTextPanel.gameObject.activeSelf)
            {
                m_interactTextPanel.gameObject.SetActive(false);
            }
        }
        m_currentInteractable = null;

        Ray ray = new Ray(m_playerCamera.transform.position,
                          m_playerCamera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, m_interactDistance, m_interactLayer))
        {
            if (hit.collider.GetComponentInParent<IInteractable>() is not null)
            {
                m_currentInteractable = hit.collider.GetComponentInParent<IInteractable>();
            }
        }
    }
}
