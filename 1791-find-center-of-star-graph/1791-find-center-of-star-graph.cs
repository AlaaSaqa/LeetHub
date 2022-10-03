public class Solution {
    public int FindCenter(int[][] edges) {
    Dictionary<int , int> numOfInvolvedEdges = new Dictionary<int, int>();
    for (var edge = 0; edge <edges.Length; edge ++)
    {
        if (numOfInvolvedEdges.ContainsKey(edges[edge][0]))
        {
            numOfInvolvedEdges[edges[edge][0]]++;
        }
        else
        {
            numOfInvolvedEdges.Add(edges[edge][0],1);
        }
        if (numOfInvolvedEdges.ContainsKey(edges[edge][1]))
        {
            numOfInvolvedEdges[edges[edge][1]]++;
        }
        else
        {
            numOfInvolvedEdges.Add(edges[edge][1],1);
        }

    }
    return numOfInvolvedEdges.FirstOrDefault(x => x.Value == edges.Length).Key;
    }
}