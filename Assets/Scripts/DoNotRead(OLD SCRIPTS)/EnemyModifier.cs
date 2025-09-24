
// using UnityEngine;

// public class EnemyModifier : MonoBehaviour
// {
//     GameObject[] objetos;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         objetos = GameObject.FindGameObjectsWithTag("Enemy");
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        

//         foreach (GameObject obj in objetos) {
//             EnemyAI ai = obj.GetComponent<EnemyAI>();
//             if (ai == null) {
//                 obj.GetComponent<SpriteRenderer>().material.color = Color.red;
//                 continue;
//             } else {
//                 ai.SetSpeedMult(1.25f);
//                 obj.GetComponent<SpriteRenderer>().material.color = Color.green;
//                 Debug.Log("Objeto: " + obj.name);
//             }
//         }
//     }
// }
