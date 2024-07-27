using UnityEngine;

public class Projectile : MonoBehaviour
{
    public void SetColor(Color color)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = color;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Projectile")
        {
            Destroy(gameObject);
        }
    }
}
