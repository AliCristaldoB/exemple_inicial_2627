using UnityEngine;

public class GeneradorMeteorits : MonoBehaviour
{
    public GameObject meteoritPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        InvokeRepeating("GeneraMeteorit", 1f, 0.1f);
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    private void GeneraMeteorit()
    {
        GameObject meteoritNou = Instantiate(meteoritPrefab);

        meteoritNou.transform.position = new Vector3(
            Random.Range(ValorsGlobals.limitEsquerraX, ValorsGlobals.limitDretaX),
            Random.Range(ValorsGlobals.limitInferiorY, ValorsGlobals.limitSuperiorY), 
            ValorsGlobals.limitSuperiorZ);



    }

}
