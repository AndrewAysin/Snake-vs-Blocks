using UnityEngine;

public class WIN : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            PlayerManager.isGameWin = true;
        }

    }
}
