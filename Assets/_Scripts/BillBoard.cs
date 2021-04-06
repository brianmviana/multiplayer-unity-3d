using System.Collections;
using UnityEngine;

namespace Assets._Scripts {
    public class BillBoard : MonoBehaviour {

        void Update() {
            transform.LookAt(Camera.main.transform);
        }
    }
}