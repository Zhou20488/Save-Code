using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class gamesave : MonoBehaviour
{
    public NewBehaviourScript ne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    public void savegame()
    {
        Debug.Log(Application.persistentDataPath);
        if (!Directory.Exists(Application.persistentDataPath+"/game save"))
        {
            Directory.CreateDirectory(Application.persistentDataPath+"/game save");
        }
        BinaryFormatter bin = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath+"/game save/Fix.txt");
        var json = JsonUtility.ToJson(ne);
        bin.Serialize(file,json);
        file.Close();
    }
    public void lovegame()
    {
        BinaryFormatter form = new BinaryFormatter();
        if (File.Exists(Application.persistentDataPath+"/game save/Fix.txt"))
        {
            FileStream file = File.Open(Application.persistentDataPath+"/game save/Fix.txt",FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)form.Deserialize(file),ne);
            file.Close();
        }
    }
}
