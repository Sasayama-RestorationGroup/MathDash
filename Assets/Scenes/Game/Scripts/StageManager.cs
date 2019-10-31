using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StageManager : MonoBehaviour
{
    /// <summary>
	/// 現在走っている道
	/// </summary>
    [SerializeField]
	private QuestionRoad currentRoad;

	/// <summary>
	/// 次の左の道
	/// </summary>
	[SerializeField]
	private QuestionRoad nextLeftRoad;

	/// <summary>
	/// 次の右の道
	/// </summary>
	[SerializeField]
	private QuestionRoad nextRightRoad;

    /// <summary>
	/// 道のオブジェクトのプレハブ
	/// </summary>
	private GameObject roadObj;

	private List<QuestionRoad> questionRoadList;

	// Start is called before the first frame update
	void Start()
    {
		// プレハブを取得
		roadObj = (GameObject)Resources.Load("Prefabs/QuestionRoad");

		questionRoadList = new List<QuestionRoad>();
		questionRoadList.Add(currentRoad);
		questionRoadList.Add(nextLeftRoad);
		questionRoadList.Add(nextRightRoad);
		currentRoad.UpdateState();
	}

	// Update is called once per frame
	void Update()
	{
        // 左に曲がったとする
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			UpdateRoadList();
			CreateNextRoad(nextLeftRoad);
		}
        // 右に曲がったとする
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			UpdateRoadList();
			CreateNextRoad(nextRightRoad);
		}
	}

    /// <summary>
	/// 道の状態の更新
	/// </summary>
    private void UpdateRoadList()
	{
        // 道の状態更新
        foreach(var road in questionRoadList)
		{
			road.UpdateState();
		}

        // 削除する道は削除用のリストに移してから削除する
		var destroyList = questionRoadList.Where(road => road.ShouldDestroy()).ToList();
		questionRoadList.RemoveAll(road => road.ShouldDestroy());

        // 古い道は削除する
        foreach(var road in destroyList)
		{
			Destroy(road.gameObject);
		}
	}

	/// <summary>
	/// 次の道の作成
	/// </summary>
	/// <param name="questionRoad">曲がった側のQuestionRoad</param>
	private void CreateNextRoad(QuestionRoad _questionRoad)
	{
		// 次の道を作成する
		var leftObjPoint = _questionRoad.GetLeftTransform();
		var rightObjPoint = _questionRoad.GetRightTransform();
		var leftObj = (GameObject)Instantiate(roadObj, leftObjPoint.position, leftObjPoint.rotation);
		var rightObj = (GameObject)Instantiate(roadObj, rightObjPoint.position, rightObjPoint.rotation);
		// 階層を"Stage"のオブジェクトの下にする
		leftObj.transform.parent = this.transform;
		rightObj.transform.parent = this.transform;

		// リストに追加する
		var leftScript = leftObj.GetComponent<QuestionRoad>();
		var rightScript = rightObj.GetComponent<QuestionRoad>();
		questionRoadList.Add(leftScript);
		questionRoadList.Add(rightScript);

        // オブジェクト名変更(for Debug)
		currentRoad.gameObject.name = "OldCurrent";
		nextLeftRoad.gameObject.name = "OldLeft";
		nextRightRoad.gameObject.name = "OldRight";
		_questionRoad.gameObject.name = "Current";
		leftObj.name = "NextLeft";
		rightObj.name = "NextRight";

		// 現在の道の状態を更新する。
		currentRoad = _questionRoad;
		nextLeftRoad = leftScript;
		nextRightRoad = rightScript;
	}
}
