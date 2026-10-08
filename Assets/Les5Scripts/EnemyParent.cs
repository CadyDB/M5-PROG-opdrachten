using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float speed = 2f;
    public int health = 3;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    protected void Damage()
    {
        health -= 1;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Damage();
        }
    }
}
