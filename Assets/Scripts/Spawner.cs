using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempo = 10.0f;
    public GameObject modeloEnemigo;
    public List<GameObject> posiciones;

    IEnumerator Spawn() {
        while (true) {
            yield return new WaitForSeconds(tiempo);
            if (posiciones.Count > 0) {
                Random rnd = new Random();
                int idx = (int)Random.Range(0.0f, posiciones.Count-1);
                //GameObject.Instantiate(modeloEnemigo, transform.position, transform.rotation);
                GameObject.Instantiate(modeloEnemigo, posiciones[idx].transform.position, posiciones[idx].transform.rotation);
                //hay que crear 3 game object empty en diferentes posiciones
            }


        }
    }
    private bool activo = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!activo && other.gameObject.CompareTag("Player")) { // si player entra en la zona
            activo = true;
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.Play();
            StartCoroutine("Spawn");
        }
            
    }
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Spawn");
    }
}
