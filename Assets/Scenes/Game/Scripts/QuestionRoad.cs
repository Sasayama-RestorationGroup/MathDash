using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionRoad : MonoBehaviour
{
	/// <summary>
	/// 分岐点
	/// </summary>
	[SerializeField]
	private Transform curvePoint;

	/// <summary>
	/// 左の道のオブジェクト生成座標
	/// </summary>
	[SerializeField]
	private Transform leftObjPoint;

	/// <summary>
	/// 右の道のオブジェクト生成座標
	/// </summary>
	[SerializeField]
	private Transform rightObjPoint;

    /// <summary>
	/// 生成からの経過(問題回答回数)
	/// </summary>
	private int passTime;

    void Awake()
	{
		passTime = 0;
	}

	public Transform GetCurveTransform()
	{
		return curvePoint.transform;
	}

	public Transform GetLeftTransform()
	{
		return leftObjPoint.transform;
	}

	public Transform GetRightTransform()
	{
		return rightObjPoint.transform;
	}

    /// <summary>
	/// 1問回答するたびにコールされる。
	/// </summary>
    public void UpdateState()
	{
		passTime++;
	}

    /// <summary>
	/// オブジェクト消すべきかどうか判定する
	/// </summary>
	/// <returns></returns>
    public bool ShouldDestroy()
	{
        // 生成されてから3問回答されたら消す
        if (passTime >= 3)
		{
			return true;
		}
		return false;
	}
}
