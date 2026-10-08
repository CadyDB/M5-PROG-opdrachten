using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float speed = 2f;
    public int health = 3;

    void Update()
    {
        if (health > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
