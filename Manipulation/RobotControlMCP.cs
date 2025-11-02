using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MCPForUnity;
using MCPForUnity.Editor.Models;

public class RobotControlMCP : MonoBehaviour
{
    public ArticulationBody robotBody;
    public McpClient mcpClient;
    void Start()
    {
        //mcpClient = new McpClient("RobotController");
    }

    void Update()
    {
        
    }
}
