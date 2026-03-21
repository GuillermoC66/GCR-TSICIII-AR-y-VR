using UnityEngine;

public class Caminar : MonoBehaviour
{
    public GameObject modelo;
    public float speed = 1.0f;
    private bool isMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving && speed > 1)
        {
            modelo.transform.Rotate(Vector3.up, speed * 10 * Time.deltaTime);
        }
    }
}
