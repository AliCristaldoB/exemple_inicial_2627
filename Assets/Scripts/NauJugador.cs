using UnityEngine;
using UnityEngine.InputSystem;

public class NauJugador : MonoBehaviour
{

float vel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      vel = 30f;

    }

    // Update is called once per frame
    void Update()
    {
    
    MovimentJugador();
    ControlLimitsPantalla();
            
    }

    void ControlLimitsPantalla()
    {
        Vector3 posicioActual = transform.position;

        posicioActual.x = Mathf.Clamp(posicioActual.x, ValorsGlobals.limitEsquerraX, ValorsGlobals.limitDretaX);

        posicioActual.y = Mathf.Clamp(posicioActual.y, ValorsGlobals.limitInferiorY, ValorsGlobals.limitSuperiorY);

        transform.position = posicioActual;
    }

    void MovimentJugador()
    {
         // Mirem si jugador fa moviment horitzontal; decidim fer servir les tecles "A" i "D" per moure la nau horizontalment.
        float movimentHorizontal = Keyboard.current.aKey.isPressed ? -1f : Keyboard.current.dKey.isPressed ? 1f : 0f;
        // només 3 possibles: -1 esquerra, 0 (cap moviment) o 1 dreta.

        //Mirem si jugador fa moviment vertical; decidim fer servir les tecles "W" i "S" per moure la nau verticalment.
        float movimentVertical = Keyboard.current.sKey.isPressed ? -1f : Keyboard.current.wKey.isPressed ? 1f : 0f;
        //només 3 possibles: -1 baix, 0 (cap moviment) o 1 amunt.

        // Vector3: té tres components: x, y i z. L'ordre es x, y, z.
        Vector3 vectorDesplacament = new Vector3 (movimentHorizontal, movimentVertical,0f);

        // Per assegurarnos que la direccio no afecti la velocitat, normalitzem el vector de desplaçament.
        vectorDesplacament = vectorDesplacament.normalized;

        // Movem l'objecte segons el vector de desplaçament i la velocitat.
        Vector3 nouDesplacament = new Vector3 (

            vel * vectorDesplacament.x * Time.deltaTime,
            vel * vectorDesplacament.y * Time.deltaTime,
            0f

        );

        // transform.position: és la posició de l'objecte que té assignat aquest script.
        transform.position += nouDesplacament;
    }

}
