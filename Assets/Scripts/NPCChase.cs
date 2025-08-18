using UnityEngine;
using System.Collections;

public enum NPCState
{
    Idle,
    Roaming
}

public class NPCChase : MonoBehaviour
{
    private string currentState = "Idle";

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(2f);

    }

    IEnumerator Chase()
    {
        while (currentState == "chasing")
        {
            yield return null;
        }
    }

    IEnumerator ChangeState(string newState)
    {
        if (currentState == newState)
        {
            yield break;
        }

        currentState = newState;
        switch (currentState)
        {
            case "Idle":
                yield return StartCoroutine(Idle());
                break;
            case "Chasing":
                yield return StartCoroutine(Chase());
                break;
        }
    }
}