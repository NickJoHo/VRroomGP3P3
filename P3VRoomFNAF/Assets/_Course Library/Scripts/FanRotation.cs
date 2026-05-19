using JetBrains.Annotations;
using UnityEngine;

public class FanRotation : MonoBehaviour
{
    
    public float rotationSpeed = 500f;
    
    public Vector3 rotationAxis = Vector3.forward;

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}
