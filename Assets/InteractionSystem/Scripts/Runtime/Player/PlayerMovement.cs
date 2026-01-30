using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float m_moveSpeed = 5f;

    [Header("Mouse Look")]
    [SerializeField] private float m_mouseSensitivity = 150f;
    [SerializeField] private Transform m_cameraTransform;

    private CharacterController m_controller;
    private float m_xRotation = 0f;

    void Start()
    {
        m_controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        HandleMouseLook();
        HandleMovement();
    }

    void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        m_controller.Move(move * m_moveSpeed * Time.deltaTime);
    }

    void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * m_mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * m_mouseSensitivity * Time.deltaTime;

        m_xRotation -= mouseY;
        m_xRotation = Mathf.Clamp(m_xRotation, -80f, 80f);

        m_cameraTransform.localRotation = Quaternion.Euler(m_xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
