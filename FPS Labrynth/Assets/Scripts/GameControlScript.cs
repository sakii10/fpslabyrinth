using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public GameObject door;
    public float floatHeight = 5f;
    private Vector3 initialPosition;
    private Vector3 targetPosition;
    public float speed = 2f;
    private bool isActive = false;
    void Start()
    {
        initialPosition = door.transform.position;
        targetPosition = door.transform.position + Vector3.up * floatHeight;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Level_2");
        }

        if (other.CompareTag("Pressure"))
        {
            isActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the player leaves the pressure plate
        if (other.CompareTag("Pressure"))
        {
            isActive = false;
        }
    }

    void Update()
    {
        if (isActive)
        {
            // Lift the door up
            door.transform.position = Vector3.MoveTowards(door.transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            // Lower the door back to the original position
            door.transform.position = Vector3.MoveTowards(door.transform.position, initialPosition, speed / 10 * Time.deltaTime);
        }
    }
}
