using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AStar3D
{
    public class Path
    {

        public readonly Vector3[] lookPoints;
        public readonly int finishLineIndex;

        public Path(Vector3[] waypoints, Vector3 startPos, float turnDist)
        {
            lookPoints = waypoints;
            finishLineIndex = waypoints.Length - 1;


        }
    }
}
