using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject message, duck;
    [SerializeField] private GameObject pipes, source;
    private float interval = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0f, interval);
    }

    private void SpawnPipes()
    {
        Instantiate(
            pipes,                      // Instancia os pilares
            source.transform.position,  // Na posição do objeto source
            Quaternion.identity         // Com rotação padrão (sem rotação, identidade)
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // message.SetActive(true);
            Destroy(message);
            duck.SetActive(true);
        }


    }
}
