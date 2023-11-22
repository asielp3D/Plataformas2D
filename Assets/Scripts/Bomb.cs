using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float radio;
    [SerializeField] private float fuerzaBomba;

   
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.P))
        {
            Explosion();
        }*/
    }

    public void Explosion()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(transform.position,radio);

        foreach(Collider2D collider in objetos)
        { 
            Rigidbody2D rBody = collider.GetComponent<Rigidbody2D>();
            if(rBody != null)
            {
                Vector2 direction = collider.transform.position - transform.position;
                float distancia = 1 + direction.magnitude;
                float fuerzaFinal = fuerzaBomba / distancia;
                rBody.AddForce(direction * fuerzaFinal);

            }

            Destroy(gameObject);
        }

        
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,radio);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            Player player = collider.gameObject.GetComponent<Player>();
            //player.Muerte();
            GameManager.instance.GameOver();
        }
    }
}
