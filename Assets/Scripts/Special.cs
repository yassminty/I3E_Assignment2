using UnityEngine;

public class Special : MonoBehaviour
{
    public GameObject teleportPlatform; // assign your teleport platform

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            teleportPlatform.SetActive(true); // activate the teleport platform
            Debug.Log("Teleport platform activated!");
            Destroy(gameObject); // remove the special item
        }
    }
}
