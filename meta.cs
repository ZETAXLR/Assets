
using UnityEngine;


public class DetectorDeColision : MonoBehaviour
{
    public GameObject PANELGANASTE;

    public void OnCollisionEnter(Collision objetoChocado)
    {
        if (objetoChocado.gameObject.CompareTag("Obstaculo"))
        {
            PANELGANASTE.SetActive(true);
        }
    }

}
    


