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

    // Update is called on
    // ce per frame


    private void SpawnPipes()
    {
        Instantiate(
            pipes, //Instancia dos pilares
            source.transform.position, //na posicao do objeto source
            Quaternion.identity // com rotação padrão (sem rotação, identidade)
        );
    }
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
