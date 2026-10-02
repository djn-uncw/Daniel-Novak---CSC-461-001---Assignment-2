using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class proximityTrigger : MonoBehaviour
{

   public GameObject infoPanel;

   private void OnTriggerEnter(Collider other)
   {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
        }
   }

   private void OnTriggerExit(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           infoPanel.SetActive(false);
       }
   }
}
