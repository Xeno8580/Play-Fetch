using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;
    public float fireDelay = 1f;
    private float shotTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (shotTimer > 0)
        {
            shotTimer -= Time.deltaTime;
        }
        
        // On spacebar press, send dog
        if (fireAction.triggered)
        {
            if (shotTimer <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                shotTimer = fireDelay;
            }
        }
    }
}
