using UnityEngine;

public class Elf : EnemyParent
{
    private Renderer renderer;

    void Start()
    {
        health = 2;
        speed = 5f;

        renderer = GetComponent<Renderer>();
        InvokeRepeating(nameof(ToggleVisibility), 3f, 3f);
    }

    void ToggleVisibility()
    {
        renderer.enabled = false;
        Invoke(nameof(ShowAgain), 0.5f);
    }

    void ShowAgain()
    {
        renderer.enabled = true;
    }
}
