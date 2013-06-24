using UnityEngine;

public class LeaderBoardSphere1 : MonoBehaviour {

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit rayHit;
            var ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayHit, 100))
            {
                var go = rayHit.collider.gameObject;
                if (go.name != "LeaderBoardSphere1") return;

                NerdGPG.Instance().showLeaderBoards(
                    GooglePlayServicesManager.Instance.GetLeaderBoardId(
                        (int)GooglePlayServicesManager.LEADER_BOARD.ONE
                    )
                );
            }
        }
    }

}
