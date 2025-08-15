using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerGameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerGameObject.SetActive(false);
            playerGameObject.transform.position = destination.position;
            playerGameObject.SetActive(true);
        }
    }
}
