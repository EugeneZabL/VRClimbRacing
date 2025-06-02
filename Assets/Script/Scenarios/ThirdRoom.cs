using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ThirdRoom : MonoBehaviour
{
    [SerializeField] private List<CubeColider> _cubes;

    [SerializeField] private RoomAnimation _nextRoom;
    public void CubeHit(CubeColider cube)
    {
        _cubes.Remove(cube);

        cube.DisapearAnim();

        if (_cubes.Count <= 0)
        {
            _nextRoom.AppearRoom();
        }
    }
}
