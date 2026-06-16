using UnityEngine;

public class Crystal : MonoBehaviour
{
    public GameObject collectEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddCrystal();

            Instantiate(
                collectEffect,
                transform.position,
                Quaternion.identity);

            Destroy(gameObject);
        }
    }
}