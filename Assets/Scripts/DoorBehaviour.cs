using UnityEngine;

// making door move 
public class DoorBehaviour : MonoBehaviour
{
    public void Interact()
    {
        Vector3 doorRotation = transform.eulerAngles;
        doorRotation.y += 90f; //will rotate door 90 degrees
        transform.eulerAngles = doorRotation; //is to apply the rotation
    }
}
