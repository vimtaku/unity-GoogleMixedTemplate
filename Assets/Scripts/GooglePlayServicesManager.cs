using UnityEngine;
using System.Collections;

public class GooglePlayServicesManager : Singleton<GooglePlayServicesManager> {
    static public string clientId;
    public string iOSClientId = "1050922872089.apps.googleusercontent.com";
    public string androidClientId = "1050922872089-jo3ocos509p8rvi0bbllfprt69996bl4.apps.googleusercontent.com";
    public string[] leaderBoardIds = new string[5];

    public GameObject signInButton;
    public GameObject signOutButton;

    private float timer = 0.0f;
    private float wait = 2.0f;

    public enum LEADER_BOARD
    {
        ONE, // 使う分をいい感じに修正する
        TWO, // 使う分をいい感じに修正する
    }

    public void Awake() {
        #if UNITY_IPHONE
            clientId = iOSClientId;
        #elif UNITY_ANDROID
            clientId = androidClientId;
        #endif

        NerdGPG.Instance().init(clientId, "GooglePlayServicesManager");
        DontDestroyOnLoad(this.gameObject);
    }


    public void Start() {
        StartCoroutine( SignIn() );
    }

    public void Update() {
        timer += Time.deltaTime;
        if (timer < wait) {
            return;
        }

        timer = 0.0f;
        _Toggle();
    }

    IEnumerator SignIn() {
        yield return new WaitForSeconds(0.5f);
        #if UNITY_IPHONE
            // ios のときは silent authentication を利用
            NerdGPG.Instance().signInSilently();
        #elif UNITY_ANDROID
            // android はゲーム開始時に自動ログインを行わない
        #endif
    }

    public void _Toggle() {
        if (NerdGPG.Instance().isSignedIn()) {
            Debug.Log("has logined...");
            if (signInButton != null) {
                signInButton.active = false;
            }
            if (signOutButton != null) {
                signOutButton.active = true;
            }
        } else {
            Debug.Log("has logouted...");
            if (signInButton != null) {
                signInButton.active = true;
            }
            if (signOutButton != null) {
                signOutButton.active = false;
            }
        }
    }

    public string GetLeaderBoardId(int index) {
        return leaderBoardIds[ index ];
    }

    public void OnGPGSubmitScoreResult() {
        _Toggle();
    }


}
