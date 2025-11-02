using WebSocketSharp;
using UnityEngine;

public class MCPClient : MonoBehaviour
{
    private WebSocket mcpSocket;

    private string mcpUrl = "wss://api.xiaozhi.me/mcp/?token=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOjI1MTQxNywiYWdlbnRJZCI6MjA4ODkxLCJlbmRwb2ludElkIjoiYWdlbnRfMjA4ODkxIiwicHVycG9zZSI6Im1jcC1lbmRwb2ludCIsImlhdCI6MTc1OTEzODU2OCwiZXhwIjoxNzkwNjk2MTY4fQ.M3igYb9ZmIkAdqr5MBFMvKhsMNU0jBr2jvpWuqyalObKihSryGRTKWf0sLDW3CAQT19j9xgvSTYZO5qq8XZlvQ";

    void Start()
    {
        mcpSocket = new WebSocket(mcpUrl);

        mcpSocket.OnOpen += (sender, e) => { Debug.Log("Connected to MCP server"); };
        mcpSocket.OnMessage += (sender, e) => { Debug.Log("Received message: " + e.Data); };
        //mcpSocket.OnClose += (sender, e) => { Debug.Log("Disconnected from MCP server"); };
        OnApplicationQuit();

        mcpSocket.Connect();
    }

    void OnApplicationQuit()
    {
        if (mcpSocket != null && mcpSocket.ReadyState == WebSocketState.Open)
        {
            mcpSocket.Close();
        }
    }
}
