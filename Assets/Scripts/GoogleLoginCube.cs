
using UnityEngine;

public class GoogleLoginCube : MonoBehaviour {

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit rayHit;
            var ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayHit, 100))
            {
                var googleLoginCube = rayHit.collider.gameObject;
                if (googleLoginCube.name != "GoogleLoginCube") return;
                NerdGPG.Instance().signIn();
            }
        }
    }

}
