using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    void Update()
    {
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f),
            Mathf.Clamp(transform.position.y, -4f, 4f), transform.position.z);
    }

}
