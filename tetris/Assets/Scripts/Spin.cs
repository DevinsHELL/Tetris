using UnityEngine;

public class Spin : MonoBehaviour
{
    public float rotationAngle = 90f;  
    public float interval = 3f;        
    public float rotationSpeed = 2f;   

    private Quaternion targetRotation;
    private float timer;

    void Start()
    {
        targetRotation = transform.rotation; 
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            RotateCamera();
            timer = 0f; 
        }

        
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    void RotateCamera()
    {
        targetRotation *= Quaternion.Euler(0, 0, rotationAngle); // Rotate by 90 degrees
    }
}


