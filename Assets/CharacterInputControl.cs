using UnityEngine;

public class CharacterInputControl : MonoBehaviour
{

    [Header("Controls")]
    [Tooltip("use Keys to move")]
    [SerializeField] private KeyCode forwardKey = KeyCode.W;
    [SerializeField] private KeyCode backwardKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    public Vector3 inputVector;
    private CharacterMovement charMove;

    private void Awake()
    {
        charMove = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        charMove.Move(inputVector);
        HandleInput();
    }

    public void HandleInput()
    {
        float xInput = 0;
        float zInput = 0;
        if (Input.GetKey(forwardKey))
        {
            zInput++;
        }
        if (Input.GetKey(backwardKey))
        {
            zInput--;
        }
        if (Input.GetKey(leftKey))
        {
            xInput--;
        }
        if (Input.GetKey(rightKey))
        {
            xInput++;
        }
        inputVector = new Vector3(xInput, 0, zInput);

    }

}
