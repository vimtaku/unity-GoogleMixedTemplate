using UnityEngine;

public class LeaderBoardSphere2 : MonoBehaviour {

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit rayHit;
            var ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayHit, 100))
            {
                var go = rayHit.collider.gameObject;
                if (go.name != "LeaderBoardSphere2") return;

                NerdGPG.Instance().showLeaderBoards(
                    GooglePlayServicesManager.Instance.GetLeaderBoardId(
                        (int)GooglePlayServicesManager.LEADER_BOARD.TWO
                    )
                );
            }
        }
    }

}
