using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace GonzalezA_CBootcamp
{
    public static class DataManagement
    {
        public static void SavePlayerData(Player p)
        {
            string jsP = JsonSerializer.Serialize(p);
            Console.WriteLine("Serializing {0}...", jsP);

            string fileName = "e:\\vgd\\PMPlayerData.txt";
            File.WriteAllText(fileName, jsP);
            Console.WriteLine("Player Data Saved!");
        }

        public static Player LoadPlayerData(Player p)
        {
            string fileName = "e:\\vgd\\PMPlayerData.txt";
            string jsP = File.ReadAllText(fileName);

            Player x = JsonSerializer.Deserialize<Player>(jsP);
            return x;
        }

    }
}
