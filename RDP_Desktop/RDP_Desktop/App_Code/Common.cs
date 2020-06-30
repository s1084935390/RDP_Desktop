using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

public class Common
{
    static string path = Application.StartupPath + "/config.json";

    /// <summary>
    /// 读取json配置文件
    /// </summary>
    /// <returns></returns>
    public static JArray Read() {
        JArray jArray = new JArray();
        try
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                jArray = JArray.Parse(File.ReadAllText(path));
            }
        }
        catch (Exception)
        {

            return jArray; 
        }
        return jArray;
    }


    public static void Write(JArray array) {
        string result = JsonConvert.SerializeObject(array);
        File.WriteAllText(path, result);
    }



}          