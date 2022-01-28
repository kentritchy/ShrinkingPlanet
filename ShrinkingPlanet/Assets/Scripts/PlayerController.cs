using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 10f;
	public float rotationSpeed = 10f;

	private float rotation;
    private float x = 1f;
	private Rigidbody rb;

    public RightTouch rightTouch;
    public LeftTouch leftTouch;

  

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
        leftTouch = FindObjectOfType<LeftTouch>();
        rightTouch = FindObjectOfType<RightTouch>();
        Application.targetFrameRate = 30;
    }

	void Update ()
	{
		rotation = Input.GetAxisRaw("Horizontal");
        RotateLeft();
        RotateRight();
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
		//transform.Rotate(0f, rotation * rotationSpeed * Time.fixedDeltaTime, 0f, Space.Self);
	}

    public void RotateLeft()
    {
        if (leftTouch.Pressed)
        {
            rotation = -x;
        }
    }

    public void RotateRight()
    {
        if (rightTouch.Pressed)
        {
            rotation = x;
        }
    }
    
}
