using UnityEngine;

public class Target : MonoBehaviour
{
    public int hitsToDestroy = 3; // Number of hits required to destroy the target
    private int currentHits = 0;

    // Method to handle the target being hit by a projectile
    public void HitByProjectile()
    {
        currentHits++;
        Debug.Log("Target hit. Current hits: " + currentHits);
        if (currentHits >= hitsToDestroy)
        {
            Destroy(gameObject);
        }
    }

    // Method to handle collision with projectiles
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            HitByProjectile();
        }
    }
}
